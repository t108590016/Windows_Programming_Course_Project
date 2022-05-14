using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace homework2.Tests
{
    [TestClass()]
    public class ModelTests
    {
        PrivateObject _modelPrivate;
        Model _model;
        Course _testCourse;
        Curriculum _testCurriculum;
        Department _testDepartment;
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _modelPrivate = new PrivateObject(_model);
            _testCourse = new Course();
            _testCurriculum = new Curriculum();
            _testDepartment = new Department();
        }

        //測試NotifyObserver
        [TestMethod()]
        public void NotifyObserverTest()
        {
            string changedPropertyName = "Name";
            _model.PropertyChanged += (sender, args) => changedPropertyName = args.PropertyName;
            Assert.AreEqual("Name", changedPropertyName);
        }

        //測試IsAddedCourse
        [TestMethod()]
        public void IsAddedCourseTest()
        {
            _model.AddCourse(_testCourse);
            _model.IsAddedCourse();
            Assert.IsTrue(_model.IsCheckResultButtonEnabled);
        }

        //測試AddCourse
        [TestMethod()]
        public void AddCourseTest()
        {
            int original = _model.GetAddedCourseCount();
            _model.AddCourse(_testCourse);
            int now = _model.GetAddedCourseCount();
            Assert.AreEqual(1, now - original);
        }

        //測試AddCourse
        [TestMethod()]
        public void AddCourseTest1()
        {
            int original = _model.GetAddedCourseCount();
            _testCurriculum.Add(_testCourse);
            _model.AddCourse(_testCurriculum);
            int now = _model.GetAddedCourseCount();
            Assert.AreEqual(1, now - original);
        }

        //測試RemoveCourseAt
        [TestMethod()]
        public void RemoveCourseAtTest()
        {
            _model.AddCourse(_testCourse);
            int original = _model.GetAddedCourseCount();
            _model.RemoveAt(0);
            int now = _model.GetAddedCourseCount();
            Assert.AreEqual(1, original - now);
        }

        //測試GetDepartmentIndex
        [TestMethod()]
        public void GetDepartmentIndexTest()
        {
            Assert.AreEqual(0, _model.GetDepartmentIndex("資工三"));
        }

        //測試AddCourseTestToClass
        [TestMethod()]
        public void AddCourseTestToClass()
        {
            int original = _model.GetDepartment(0).GetCourseCount();
            _model.AddCourse("資工三", _testCourse);
            int now = _model.GetDepartment(0).GetCourseCount();
            Assert.AreEqual(1, now - original);
        }

        //測試FindDepartmentIndex
        [TestMethod()]
        public void FindDepartmentIndexTest()
        {
            Assert.AreEqual(0, _model.FindDepartmentIndex("資工三"));
        }

        //測試ModifyCourse
        [TestMethod()]
        public void ModifyCourseTest()
        {
            Course _anotherCourse = new Course();
            _anotherCourse._name = "test";
            _model.ModifyCourse("資工三", 0, _testCourse, _anotherCourse);
            Assert.AreEqual("test", _model.GetDepartment(0)._curriculum._curriculum[0]._name);
        }

        //測試GetCourse
        [TestMethod()]
        public void GetCourseTest()
        {
            Assert.AreEqual("班週會及導師時間", _model.GetCourse(0)._name);
        }

        //測試ModifyAddedCourse
        [TestMethod()]
        public void ModifyAddedCourseTest()
        {
            Course anotherCourse = new Course();
            anotherCourse._name = "test";
            _model.AddCourse(_testCourse);
            Assert.AreEqual("", _model.GetAddedCourse().IndexAt(0)._name);
            _model.ModifyAddedCourse(_testCourse, anotherCourse);
            Assert.AreEqual("test", _model.GetAddedCourse().IndexAt(0)._name);
        }

        //測試RemoveAddedCourse
        [TestMethod()]
        public void RemoveAddedCourseTest()
        {
            Course anotherCourse = new Course();
            anotherCourse._name = "test";
            _model.AddCourse(_testCourse);
            Assert.AreEqual(1, _model.GetAddedCourseCount());
            _model.RemoveAddedCourse(_testCourse);
            Assert.AreEqual(0, _model.GetAddedCourseCount());
        }

        //測試ImportAllInformationCourse
        [TestMethod()]
        public void ImportAllInformationCourseTest()
        {
            string[] testDepartmentName = { "資工三" };
            string[] testCode = { "2433" };
            _model.ImportAllInformationCourse(testDepartmentName, testCode);
            Assert.AreEqual("班週會及導師時間", _model.GetCourse(0)._name);
        }

        //測試IsDuplicateNumber
        [TestMethod()]
        public void IsDuplicateNumberTest()
        {
            _testDepartment._name = "test";
            _model.AddDepartment(_testDepartment);
            _testCourse._number = "123455";
            _model.AddCourse("test", _testCourse);
            Course anotherCourse = new Course();
            anotherCourse._number = "123455";
            Assert.IsTrue(_model.IsDuplicateNumber(anotherCourse));
        }

        //測試GetCourseTitle
        [TestMethod()]
        public void GetCourseTitleTest()
        {
            Assert.AreEqual("課號", _model.GetCourseTitle()[0]);
        }

        //測試AddDepartment
        [TestMethod()]
        public void AddDepartmentTest()
        {
            //Assert.AreEqual(0, _model.GetAllDepartmentCount());
            int original = _model.GetAllDepartmentCount();
            _model.AddDepartment(_testDepartment);
            int now = _model.GetAllDepartmentCount();
            Assert.AreEqual(1, now - original);
        }
    }
}