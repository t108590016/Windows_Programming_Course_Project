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
    public class CourseTests
    {
        PrivateObject _coursePrivate;
        Course _course;
        Course _anotherCourse;
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            List<string> testList = new List<string>();
            testList.Add("test");
            _course = new Course();
            _anotherCourse = new Course();
            _coursePrivate = new PrivateObject(_course);
        }

        //測試Equals
        [TestMethod()]
        public void EqualsTest()
        {
            List<string> testList = new List<string>();
            testList.Add("test");
            _course._toList = testList;
            _anotherCourse._toList = testList;
            Assert.AreEqual(true, _course.Equals(_anotherCourse));
        }

        //測試IsNumberEqual
        [TestMethod()]
        public void IsNumberEqualTest()
        {
            _course._number = "123";
            _anotherCourse._number = "123";
            Assert.AreEqual(true, _course.IsNumberEqual(_anotherCourse));
        }

        //測試IsNameEqual
        [TestMethod()]
        public void IsNameEqualTest()
        {
            _course._name = "test";
            _anotherCourse._name = "test";
            Assert.AreEqual(true, _course.IsNameEqual(_anotherCourse));
        }

        //測試CheckConflict
        [TestMethod()]
        public void CheckConflictTest()
        {
            _course._name = "test";
            _course._number = "123456";
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
            _course._classTime = _testClassTime;
            _anotherCourse._classTime = anotherClassTime;
            Assert.AreEqual("課程名稱相同：「123456-test」、「123457-test」\n", _course.CheckConflict(_anotherCourse));
            _anotherCourse._name = "test2";
            _anotherCourse._number = "123456";
            Assert.AreEqual("課號相同：「123456-test」、「123456-test2」\n", _course.CheckConflict(_anotherCourse));
            _anotherCourse._number = "123457";
            anotherTime.Clear();
            anotherTime.Add("2 4 5");
            for (int i = 0; i < 6; i++)
            {
                time.Add("");
                anotherTime.Add("");
            }
            anotherClassTime._classTimeList = anotherTime;
            Assert.AreEqual("衝堂：「123456-test」、「123457-test2」\n", _course.CheckConflict(_anotherCourse));
        }
    }
}