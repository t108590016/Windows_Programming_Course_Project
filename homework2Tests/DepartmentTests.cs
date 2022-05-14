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
    public class DepartmentTests
    {
        PrivateObject _departmentPrivate;
        Department _department;
        Curriculum _curriculum;
        Course _course;
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            _department = new Department();
            _curriculum = new Curriculum();
            _course = new Course();
            _departmentPrivate = new PrivateObject(_department);
        }

        //測試RemoveCourse
        [TestMethod()]
        public void RemoveCourseTest()
        {
            _course._name = "test";
            _curriculum.Add(_course);
            _department._curriculum = _curriculum;
            int original = _department.GetCourseCount();
            _department.RemoveCourse(0);
            int now = _department.GetCourseCount();
            Assert.AreEqual(1, original - now);
        }

        //測試AddCourse
        [TestMethod()]
        public void AddCourseTest()
        {
            _curriculum.Add(_course);
            _department._curriculum = _curriculum;
            Assert.AreEqual(1, _department.GetCourseCount());
        }

        //測試GetCourseCount
        [TestMethod()]
        public void GetCourseCountTest()
        {
            _curriculum.Add(_course);
            _department._curriculum = _curriculum;
            Assert.AreEqual(1, _department.GetCourseCount());
        }

        //測試ModifyOrRemove
        [TestMethod()]
        public void ModifyOrRemoveTest()
        {
            _department._name = "資工三";
            _curriculum.Add(_course);
            _department._curriculum = _curriculum;
            Assert.IsTrue(_department.ModifyOrRemove("資工三", _course, 0));
            Assert.IsFalse(_department.ModifyOrRemove("電子三甲", _course, 0));
        }

        //測試IsOutOfIndex
        [TestMethod()]
        public void IsOutOfIndexTest()
        {
            int index = 1;
            Assert.IsTrue(_department.IsOutOfIndex(ref index));
            _curriculum.Add(_course);
            _department._curriculum = _curriculum;
            index = 0;
            Assert.IsFalse(_department.IsOutOfIndex(ref index));
        }

        //測試AddCourse
        [TestMethod()]
        public void AddCourse()
        {
            int original = _department.GetCourseCount();
            _department.AddCourse(_course);
            int now = _department.GetCourseCount();
            Assert.AreEqual(1, now - original);
        }

        //測試RemoveCourse
        [TestMethod()]
        public void RemoveCourse()
        {
            _department.AddCourse(_course);
            int original = _department.GetCourseCount();
            _department.RemoveCourse(_course);
            int now = _department.GetCourseCount();
            Assert.AreEqual(1, original - now);
        }
    }
}