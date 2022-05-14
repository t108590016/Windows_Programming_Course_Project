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
    public class CurriculumTests
    {
        PrivateObject _curriculumPrivate;
        Curriculum _curriculum;
        Curriculum _anotherCurriculum;
        Course _testCourse;
        Course _anotherCourse;
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            _testCourse = new Course();
            _anotherCourse = new Course();
            _curriculum = new Curriculum();
            _anotherCurriculum = new Curriculum();
            _curriculumPrivate = new PrivateObject(_curriculum);
        }

        //測試Add
        [TestMethod()]
        public void AddTest()
        {
            int original = _curriculum.GetCount();
            _curriculum.Add(_testCourse);
            int now = _curriculum.GetCount();
            Assert.AreEqual(1, now - original);
        }

        //測試Add
        [TestMethod()]
        public void AddTest1()
        {
            int original = _curriculum.GetCount();
            _anotherCurriculum.Add(_testCourse);
            _curriculum.Add(_anotherCurriculum);
            int now = _curriculum.GetCount();
            Assert.AreEqual(1, now - original);
        }

        //測試Remove
        [TestMethod()]
        public void RemoveTest()
        {
            int original = _curriculum.GetCount();
            _curriculum.Add(_testCourse);
            _curriculum.Remove(_testCourse);
            int now = _curriculum.GetCount();
            Assert.AreEqual(0, now - original);
        }

        //測試RemoveAt
        [TestMethod()]
        public void RemoveAtTest()
        {
            int original = _curriculum.GetCount();
            _curriculum.Add(_testCourse);
            _curriculum.RemoveAt(0);
            int now = _curriculum.GetCount();
            Assert.AreEqual(0, now - original);
        }

        //測試Contains
        [TestMethod()]
        public void ContainsTest()
        {
            _curriculum.Add(_testCourse);
            Assert.AreEqual(true, _curriculum.Contains(_testCourse));
        }

        //測試GetCount
        [TestMethod()]
        public void GetCountTest()
        {
            _curriculum.Add(_testCourse);
            Assert.AreEqual(1, _curriculum.GetCount());
        }

        //測試IndexAt
        [TestMethod()]
        public void IndexAtTest()
        {
            _curriculum.Add(_testCourse);
            Assert.AreEqual(_testCourse, _curriculum.IndexAt(0));
        }

        //測試IndexOf
        [TestMethod()]
        public void IndexOfTest()
        {
            _curriculum.Add(_testCourse);
            Assert.AreEqual(0, _curriculum.IndexOf(_testCourse));
        }

        //測試IndexOf
        [TestMethod()]
        public void IndexOfTest1()
        {
            _testCourse._number = "123456";
            _curriculum.Add(_testCourse);
            Assert.AreEqual(0, _curriculum.IndexOf("123456"));
        }

        //測試ModifyCourse
        [TestMethod()]
        public void ModifyCourseTest()
        {
            _testCourse._name = "test";
            _curriculum.Add(_testCourse);
            _curriculum.ModifyCourse(0, _anotherCourse);
            Assert.AreEqual(_anotherCourse, _curriculum.IndexAt(0));
        }

        //測試FindDifferentCourse
        [TestMethod()]
        public void FindDifferentCourseTest()
        {
            _testCourse._name = "test";
            _curriculum.Add(_testCourse);
            _curriculum.Add(_anotherCourse);
            _anotherCourse._name = "testtest";
            _anotherCurriculum.Add(_testCourse);
            //Assert.AreEqual(1, _curriculum.FindDifferentCourse(_anotherCurriculum).GetCount());
            Assert.AreEqual(_anotherCourse, _curriculum.FindDifferentCourse(_anotherCurriculum).IndexAt(0));
        }

        //測試GetAllCourseName
        [TestMethod()]
        public void GetAllCourseNameTest()
        {
            _testCourse._name = "test";
            _curriculum.Add(_testCourse);
            _anotherCourse._name = "testtest";
            _curriculum.Add(_anotherCourse);
            Assert.AreEqual("test", _curriculum.GetAllCourseName()[0]);
            Assert.AreEqual("testtest", _curriculum.GetAllCourseName()[1]);
        }

        //測試Clear
        [TestMethod()]
        public void ClearTest()
        {
            _curriculum.Add(_testCourse);
            _curriculum.Clear();
            Assert.AreEqual(0, _curriculum.GetCount());
        }

        //測試FindCourseIndexByNumber
        [TestMethod()]
        public void FindCourseIndexByNumberTest()
        {
            _testCourse._number = "123456";
            _anotherCourse._number = "123457";
            _curriculum.Add(_testCourse);
            _curriculum.Add(_anotherCourse);
            Assert.AreEqual(0, _curriculum.FindCourseIndexByNumber("123456"));
            Assert.AreEqual(1, _curriculum.FindCourseIndexByNumber("123457"));
        }

        //測試CourseConflict
        [TestMethod()]
        public void CourseConflictTest()
        {
            _testCourse._name = "test";
            _testCourse._number = "123456";
            _anotherCourse._name = "test";
            _anotherCourse._number = "123457";
            List<string> time = new List<string>();
            List<string> anotherTime = new List<string>();
            time.Add("1 2");
            anotherTime.Add("3 4 5");
            for (int i = 0; i < 6; i++)
            {
                time.Add("");
                anotherTime.Add("");
            }
            ClassTime _testClassTime = new ClassTime(time);
            ClassTime anotherClassTime = new ClassTime(anotherTime);
            _testCourse._classTime = _testClassTime;
            _anotherCourse._classTime = anotherClassTime;
            _curriculum.Add(_testCourse);
            _curriculum.Add(_anotherCourse);
            Assert.AreEqual("課程名稱相同：「123456-test」、「123457-test」\n", _curriculum.CourseConflict());
            _anotherCourse._name = "test2";
            _anotherCourse._number = "123456";
            Assert.AreEqual("課號相同：「123456-test」、「123456-test2」\n", _curriculum.CourseConflict());
            _anotherCourse._number = "123457";
            anotherTime.Clear();
            anotherTime.Add("2 4 5");
            for (int i = 0; i < 6; i++)
            {
                time.Add("");
                anotherTime.Add("");
            }
            anotherClassTime._classTimeList = anotherTime;
            Assert.AreEqual("衝堂：「123456-test」、「123457-test2」\n", _curriculum.CourseConflict());
        }
    }
}