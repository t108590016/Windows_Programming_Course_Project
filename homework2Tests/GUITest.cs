using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace homework2Tests
{
    [TestClass]
    public class GUITest
    {
        private Robot _robot;
        private string targetAppPath;
        private const string START_UP_FORM = "StartUpForm";
        private const string COURSE_MANAGEMENT_FORM = "CourseManagementForm";
        private const string COURSE_SELECTING_FORM = "CourseSelectingForm";
        private const string COURSE_SELECTION_RESULT_FORM = "CourseSelectionResultForm";
        /// <summary>
        /// Launches the Calculator
        /// </summary>
        // init
        [TestInitialize]
        public void Initialize()
        {
            var projectName = "homework2";
            string solutionPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
            targetAppPath = Path.Combine(solutionPath, projectName, "bin", "Debug", "homework2.exe");
            _robot = new Robot(targetAppPath, START_UP_FORM);
        }


        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            _robot.CleanUp();
        }

        //測試開啟COURSE_SELECTING_FORM
        private async Task RunScriptOpenCourseSelectingFormAsync()
        {
            _robot.SwitchTo(START_UP_FORM);
            _robot.ClickButton("Course Selecting System");
            await Task.Delay(1000);
            _robot.SwitchTo(COURSE_SELECTING_FORM);
        }


        //測試開啟COURSE_MANAGEMENT_FORM
        private async Task RunScriptOpenCourseManagementFormAsync()
        {
            _robot.SwitchTo(START_UP_FORM);
            _robot.ClickButton("Course Management System");
            await Task.Delay(1000);
            _robot.SwitchTo(COURSE_MANAGEMENT_FORM);
        }

        //測試加選課程
        private void RunScriptAddCourse()
        {
            _robot.ClickTabControl("資工三");
            _robot.ClickDataGridViewCellBy("_dataGridView0", 1, "選");
            _robot.ClickTabControl("電子三甲");
            _robot.ClickDataGridViewCellBy("_dataGridView1", 1, "選");
            _robot.ClickButton("確認送出");
            _robot.ClickButton("確定");
        }

        //測試開啟COURSE_SELECTION_RESULT_FORM
        private async Task RunScriptOpenCourseSelectionResultFormAsync()
        {
            _robot.ClickButton("查看選課結果");
            await Task.Delay(1000);
            _robot.SwitchTo(COURSE_SELECTION_RESULT_FORM);
        }

        //測試退選課程
        private void RunScriptWithdrawCourse()
        {
            //_robot.ClickButton("退選");
            //_robot.ClickButton("退選");
            _robot.ClickDataGridViewCellBy("_courseSelectionResult", 0, "退選");
            _robot.ClickDataGridViewCellBy("_courseSelectionResult", 0, "退選");
            //_robot.AssertDataGridViewRowDataBy("_dataGridView0", 1, testData);
            //_robot.CloseWindow();
        }

        //測試加選衝堂課程
        private async Task RunScriptAddConflictCourseAsync()
        {
            _robot.ClickTabControl("資工三");
            _robot.ClickDataGridViewCellBy("_dataGridView0", 1, "選");
            _robot.ClickTabControl("電子三甲");
            _robot.ClickDataGridViewCellBy("_dataGridView1", 7, "選");
            _robot.ClickDataGridViewCellBy("_dataGridView1", 11, "選");
            _robot.ClickButton("確認送出");
            await Task.Delay(200);
            _robot.SwitchTo(COURSE_SELECTING_FORM);
        }


        //測試修改課程
        private void RunScriptModifyCourse()
        {
            _robot.ClickButton("資料庫系統");
            _robot.ModifyText("_courseName", "test");
        }

        //測試清空課程其中一欄
        private void RunScriptClearCourseElement()
        {
            //_robot.ClickButton("資料庫系統");
            _robot.ClearText("_teacher");
        }

        //測試修改課程時間
        private void RunScriptModifyCourseTime()
        {
            _robot.ClickButton("視窗程式設計");
            _robot.ClickDataGridViewCellBy("_classTime", 5, "四");
            _robot.ClickDataGridViewCellBy("_classTime", 6, "四");
        }

        //測試AddCourse
        [TestMethod]
        public async Task TestAddCourseAsync()
        {
            string[] testData = { "False", "291702", "體育", "5", "0.0", "2", "△", "", "", "", "", "", "", "8 9", "", "", "0", "0", "", "", "", "*", "", "" };
            string[] testData2 = { "False", "291503", "博雅選修課程", "1", "2.0", "2", "△", "", "", "", "", "", "", "1 2", "", "", "0", "0", "", "", "", "請選：通識中心/博雅選修(四)", "", "" };
            string[] testData3 = { "False", "291703", "博雅選修課程", "1", "2.0", "2", "△", "", "", "", "", "", "", "1 2", "", "", "0", "0", "", "", "", "請選：通識中心/博雅選修(四)", "", "" };
            string[] testData4 = { "False", "291504", "通訊系統實習", "1", "1.0", "3", "▲", "曾德樟", "", "", "", "2 3 4", "", "", "", "綜科306", "63", "0", "", "", "查詢", "*綜科306", "", "是" };
            await RunScriptOpenCourseSelectingFormAsync();
            _robot.AssertDataGridViewRowDataBy("_dataGridView0", 1, testData);
            _robot.ClickTabControl("電子三甲");
            _robot.AssertDataGridViewRowDataBy("_dataGridView1", 1, testData2);
            RunScriptAddCourse();
            _robot.AssertDataGridViewRowDataBy("_dataGridView0", 1, testData3);
            _robot.ClickTabControl("電子三甲");
            _robot.AssertDataGridViewRowDataBy("_dataGridView1", 1, testData4);
            //await RunScriptOpenCourseSelectionResultFormAsync();
            testData[0] = "退選";
            testData2[0] = "退選";
            _robot.ClickButton("查看選課結果");
            _robot.Sleep(1);
            _robot.SwitchTo(COURSE_SELECTION_RESULT_FORM);
            _robot.AssertDataGridViewRowDataBy("_courseSelectionResult", 0, testData);
            _robot.AssertDataGridViewRowDataBy("_courseSelectionResult", 1, testData2);
            RunScriptWithdrawCourse();
            _robot.AssertDataGridViewRowCountBy("_courseSelectionResult", 0);
            _robot.SwitchTo(COURSE_SELECTING_FORM);
            testData[0] = "False";
            testData2[0] = "False";
            _robot.AssertDataGridViewRowDataBy("_dataGridView0", 1, testData);
            _robot.ClickTabControl("電子三甲");
            _robot.AssertDataGridViewRowDataBy("_dataGridView1", 1, testData2);
        }

        //測試ImportCourse
        public async Task RunScriptImportCourseAsync()
        {
            _robot.ClickButton("匯入資工系所有課程");
            await Task.Delay(6000);
            //_robot.Sleep(10);

        }

        //測試AddConflictCourse
        [TestMethod]
        public async Task TestAddConflictCourseAsync()
        {
            await RunScriptOpenCourseSelectingFormAsync();
            await RunScriptAddConflictCourseAsync();
            _robot.AssertText("65535", "加選失敗\r\n衝堂：「291539-數位信號處理」、「291548-FPGA系統設計實務」\r\n");
            _robot.CloseMessageBox();
            _robot.CloseWindow();
        }

        //測試ModifyCourse
        [TestMethod]
        public async Task TestModifyCourseAsync()
        {
            await RunScriptOpenCourseManagementFormAsync();
            RunScriptModifyCourse();
            _robot.AssertEnable("儲存", true);
            RunScriptClearCourseElement();
            _robot.AssertEnable("儲存", false);
            RunScriptModifyCourseTime();
            _robot.AssertEnable("儲存", true);
            _robot.ClickDataGridViewCellBy("_classTime", 5, "四");
            _robot.ClickDataGridViewCellBy("_classTime", 6, "四");
            _robot.AssertEnable("儲存", false);
        }

        //測試ModifyCourseToAllForm
        [TestMethod]
        public async Task TestModifyCourseToAllFormAsync()
        {
            await RunScriptOpenCourseSelectingFormAsync();
            _robot.ClickDataGridViewCellBy("_dataGridView0", 9, "選");
            _robot.ClickButton("確認送出");
            _robot.CloseMessageBox();
            await RunScriptOpenCourseSelectionResultFormAsync();
            await RunScriptOpenCourseManagementFormAsync();
            _robot.ClickButton("視窗程式設計");
            _robot.ModifyText("_number", "270915");
            _robot.ModifyText("_courseName", "物件導向分析與設計" + OpenQA.Selenium.Keys.Enter);
            _robot.ModifyText("_credit", "2");
            _robot.ModifyText("_hour", "2");
            _robot.ClickDataGridViewCellBy("_classTime", 2, "一");
            _robot.ClickDataGridViewCellBy("_classTime", 2, "二");
            _robot.ClickDataGridViewCellBy("_classTime", 2, "四");
            _robot.ClickDataGridViewCellBy("_classTime", 3, "四");
            _robot.ClickDataGridViewCellBy("_classTime", 6, "四");
            _robot.ClickComboBox("_class");
            _robot.ClickButton("電子三甲");
            _robot.ClickButton("儲存");
            _robot.SwitchTo(COURSE_SELECTING_FORM);
            string[] testData = { "False", "294321", "巨量資料分析導論", "1", "3.0", "3", "★", "王正豪", "", "5 6", "", "7", "", "", "", "六教325(e)", "73", "4", "", "", "查詢", "◎", "", "" };
            _robot.AssertDataGridViewRowDataBy("_dataGridView0", 9, testData);
            string[] testData2 = { "退選", "270915", "物件導向分析與設計", "1", "2", "2", "★", "陳偉凱", "", "3", "3", "", "", "", "", "二教206(e)\r\n二教205(e)", "43", "20", "", "", "查詢", "◎兼任陳偉凱老師,限52人", "", "" };
            //_robot.ClickTabControl("電子三甲");
            _robot.SwitchTo(COURSE_SELECTION_RESULT_FORM);
            _robot.AssertDataGridViewRowDataBy("_courseSelectionResult", 0, testData2);
        }

        //測試AddNewCourse
        [TestMethod]
        public async Task TestAddNewCourseAsync()
        {
            string[] componentName = { "_number", "_courseName", "_stage", "_credit", "_teacher" };
            string[] testData = { "123456", "testCourse", "1", "1.0", "test" };
            await RunScriptOpenCourseSelectingFormAsync();
            await RunScriptOpenCourseManagementFormAsync();
            _robot.ClickButton("新增課程");
            _robot.AssertText("_storeButton", "新增");
            _robot.AssertEnable("新增", false);
            for (int i = 0; i < testData.Length; i++)
                _robot.ModifyText(componentName[i], testData[i]);
            _robot.ClickDataGridViewCellBy("_classTime", 1, "一");
            _robot.AssertEnable("新增", true);
            _robot.ClickButton("新增");
            _robot.ClickButton("testCourse");
            _robot.AssertText("_courseName", "testCourse");
        }

        //測試ImportCourse
        [TestMethod]
        public async Task TestImportCourseAsync()
        {
            string[] testData = { "False", "", "班週會及導師時間", "", "", "", "", "", "", "", "3 4", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            string[] testData2 = { "False", "291502", "體育", "5", "0.0", "2", "△", "", "", "", "", "", "8 9", "", "", "", "0", "0", "", "", "", "*", "", "" };
            string[] testData3 = { "False", "290966", "體育", "1", "1.0", "2", "☆", "", "", "", "", "", "", "", "", "", "0", "0", "", "", "", "", "", "" };
            string[] testData4 = { "False", "292161", "體育", "3", "0.0", "2", "△", "", "", "", "", "", "6 7", "", "", "", "0", "0", "", "", "", "*", "", "" };
            string[] testData5 = { "False", "292689", "體育", "1", "0.0", "2", "△", "", "", "", "", "", "3 4", "", "", "", "0", "0", "", "", "", "*", "", "" };
            string[] testData6 = { "False", "293642", "論文", "1", "3.0", "3", "▲", "", "", "", "", "", "", "", "", "", "100", "0", "", "", "", "碩士班", "", "" };
            await RunScriptOpenCourseSelectingFormAsync();
            await RunScriptOpenCourseManagementFormAsync();
            await RunScriptImportCourseAsync();
            _robot.CloseWindow();
            _robot.SwitchTo(COURSE_SELECTING_FORM);
            _robot.AssertDataGridViewRowDataBy("_dataGridView0", 0, testData);
            _robot.ClickTabControl("電子三甲");
            _robot.AssertDataGridViewRowDataBy("_dataGridView1", 0, testData2);
            _robot.ClickTabControl("資工四");
            _robot.AssertDataGridViewRowDataBy("_dataGridView2", 0, testData3);
            _robot.ClickTabControl("資工二");
            _robot.AssertDataGridViewRowDataBy("_dataGridView3", 0, testData4);
            _robot.ClickTabControl("資工一");
            _robot.AssertDataGridViewRowDataBy("_dataGridView4", 0, testData5);
            _robot.ClickTabControl("資工所");
            _robot.AssertDataGridViewRowDataBy("_dataGridView5", 0, testData6);
        }

        //測試TestAddClass
        [TestMethod]
        public async Task TestAddClassAsync()
        {
            await RunScriptOpenCourseSelectingFormAsync();
            await RunScriptOpenCourseManagementFormAsync();
            _robot.ClickButton("班級管理");
            _robot.ClickButton("新增班級");
            _robot.ModifyText("_classNameTextBox", "test");
            _robot.ClickButton("新增");
            _robot.ClickButton("test");
            _robot.AssertText("_classNameTextBox", "test");
        }

    }
}
;