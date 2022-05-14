using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2.Tests
{
    [TestClass()]
    public class CourseSelectingFormPresentationModelTests
    {
        Model _model;
        CourseSelectingFormPresentationModel _presentationModel;
        PrivateObject _presentationModelPrivate;
        Course _course;
        Course _anotherCourse;
        List<string> classTime = new List<string>();
        List<string> classTime2 = new List<string>();
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _presentationModel = new CourseSelectingFormPresentationModel(_model);
            _presentationModelPrivate = new PrivateObject(_presentationModel);
            _course = new Course();
            _anotherCourse = new Course();
            
            for (int i = 0; i < 6; i++)
            {
                classTime.Add("");
                classTime2.Add("");
            }
            classTime.Add("1 2");
            classTime2.Add("3 4");
        }

        //測試AddCourse
        [TestMethod()]
        public void AddCourseTest()
        {
            int original = _presentationModel.GetAddedCourse().GetCount();
            _presentationModel.AddCourse(_course);
            int now = _presentationModel.GetAddedCourse().GetCount();
            Assert.AreEqual(1, now - original);
        }

        //測試RemoveCourse
        [TestMethod()]
        public void RemoveCourseTest()
        {
            _presentationModel.AddCourse(_course);
            int original = _presentationModel.GetAddedCourse().GetCount();
            _presentationModel.RemoveCourse(_course);
            int now = _presentationModel.GetAddedCourse().GetCount();
            Assert.AreEqual(1, original - now);
        }

        //測試ClearCourse
        [TestMethod()]
        public void ClearCourseTest()
        {
            _presentationModel.AddCourse(_course);
            _presentationModel.ClearCourse();
            Assert.AreEqual(0, _presentationModel.GetAddedCourse().GetCount());
        }

        //測試SetConfirmEnabled
        [TestMethod()]
        public void SetConfirmEnabledTest()
        {
            _presentationModel.ClearCourse();
            Assert.IsFalse(_presentationModel.IsConfirmEnabled());
            _presentationModel.AddCourse(_course);
            Assert.IsTrue(_presentationModel.IsConfirmEnabled());
        }

        //測試IsAddedCourseConflict
        [TestMethod]
        public void IsAddedCourseConflictTest()
        {
            Assert.AreEqual("", _presentationModel.IsAddedCourseConflict(_course));
            _course._name = "test";
            _course._number = "123456";
            _course._classTime = new ClassTime(classTime);
            _model.AddCourse(_course);
            _anotherCourse._name = "test2";
            _anotherCourse._number = "123457";
            _anotherCourse._classTime = new ClassTime(classTime);
            Assert.AreEqual("衝堂：「123456-test」、「123457-test2」\n", _presentationModel.IsAddedCourseConflict(_anotherCourse));
        }

        //測試CheckResult
        [TestMethod]
        public void CheckResultTest()
        {
            Assert.AreEqual("加選成功", _presentationModel.CheckResult(""));
            Assert.AreEqual("加選失敗\ntest", _presentationModel.CheckResult("test"));
        }

        //測試CourseConflict
        [TestMethod()]
        public void CourseConflictTest()
        {
            _course._name = "test";
            _course._number = "123456";
            _course._classTime = new ClassTime(classTime);
            _model.AddCourse(_course);
            Assert.AreEqual("加選成功", _presentationModel.CourseConflict());
            _course._name = "test2";
            _course._number = "123456";
            _course._classTime = new ClassTime(classTime2);
            _presentationModel.AddCourse(_course);
            Assert.AreEqual("加選失敗\n課號相同：「123456-test2」、「123456-test2」\n", _presentationModel.CourseConflict());
        }
    }
}