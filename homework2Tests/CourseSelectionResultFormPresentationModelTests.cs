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
    public class CourseSelectionResultFormPresentationModelTests
    {
        Model _model;
        CourseSelectionResultFormPresentationModel _presentationModel;
        PrivateObject _presentationModelPrivate;
        Course _course;
        Course _anotherCourse;
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _presentationModel = new CourseSelectionResultFormPresentationModel(_model);
            _presentationModelPrivate = new PrivateObject(_presentationModel);
            _course = new Course();
            _anotherCourse = new Course();
        }

        //測試RemoveRow
        [TestMethod()]
        public void RemoveRowTest()
        {            
            _model.AddCourse(_course);
            int original = _model.GetAddedCourseCount();
            _presentationModel.RemoveRow(0);
            int now = _model.GetAddedCourseCount();
            Assert.AreEqual(1, original - now);
        }
    }
}