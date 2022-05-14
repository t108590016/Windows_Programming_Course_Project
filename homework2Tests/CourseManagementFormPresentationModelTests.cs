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
    public class CourseManagementFormPresentationModelTests
    {
        Model _model;
        CourseManagementFormPresentationModel _presentationModel;
        //初始化
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _presentationModel = new CourseManagementFormPresentationModel(_model);
        }

        //測試IsNull
        [TestMethod()]
        public void IsNullTest()
        {
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
            _presentationModel.SetNumber("test");
            _presentationModel.SetName("test");
            _presentationModel.SetStage("test");
            _presentationModel.SetCredit("test");
            _presentationModel.SetTeacher("test");
            _presentationModel.SetRequired("test");
            _presentationModel.SetHour("test");
            _presentationModel.SetClass("test");
            _presentationModel.IsNull();
            Assert.IsTrue(_presentationModel.IsButtonEnabled);
        }

        //測試SetNumber
        [TestMethod()]
        public void SetNumberTest()
        {
            _presentationModel.SetNumber("");
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }

        //測試SetName
        [TestMethod()]
        public void SetNameTest()
        {
            _presentationModel.SetName("");
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }

        //測試SetStage
        [TestMethod()]
        public void SetStageTest()
        {
            _presentationModel.SetStage("");
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }

        //測試SetStage
        [TestMethod()]
        public void SetCreditTest()
        {
            _presentationModel.SetCredit("");
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }

        //測試SetTeacher
        [TestMethod()]
        public void SetTeacherTest()
        {
            _presentationModel.SetTeacher("");
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }

        //測試SetRequired
        [TestMethod()]
        public void SetRequiredTest()
        {
            _presentationModel.SetRequired("");
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }

        //測試SetHour
        [TestMethod()]
        public void SetHourTest()
        {
            _presentationModel.SetHour("");
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }

        //測試SetClass
        [TestMethod()]
        public void SetClassTest()
        {
            _presentationModel.SetClass("");
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }

        //測試SelectedIndexChanged
        [TestMethod()]
        public void SelectedIndexChangedTest()
        {
            _presentationModel.IsButtonEnabled = true;
            _presentationModel.SelectedIndexChanged();
            Assert.IsFalse(_presentationModel.IsButtonEnabled);
        }
    }
}