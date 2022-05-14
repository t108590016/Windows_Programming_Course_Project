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
    public class ImportCourseFormPresentationModelTests
    {
        Model _model;
        ImportCourseFormPresentationModel _presentationModel;
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _presentationModel = new ImportCourseFormPresentationModel(_model);
        }

        //測試ImportCourse
        [TestMethod()]
        public void ImportCourseTest()
        {
            _presentationModel.ImportCourse();
            int now = _model.GetAllDepartmentCount();
            Assert.AreEqual(3, now);
        }
    }
}