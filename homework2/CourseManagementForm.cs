using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class CourseManagementForm : Form
    {
        public CourseManagementForm(Model model, CourseManagementFormPresentationModel presentationModel)
        {
            ImeMode = ImeMode.Off;
            this._model = model;
            this._presentationModel = presentationModel;
            _mode = _presentationModel.GetMode();
            _requiredArray = _presentationModel.GetRequiredArray();
            _classTimeName = _presentationModel.GetClassTimeName();
            InitializeComponent();
            _storeButton.DataBindings.Add("Enabled", this._presentationModel, "IsButtonEnabled");
            _model._modelChanged += SetListBox;
            _model._modelChanged += SetClassListBox;
        }

        //設定_classTime Row
        private void SetDataGridViewRow()
        {
            for (int i = 1; i <= HOUR; i++)
            {
                if (i >= CARRY)
                {
                    _classTime.Rows.Insert(i - 1, ((char)(LATTER + (i % CARRY))).ToString());
                    _classTimeList.Add(((char)(LATTER + (i % CARRY))).ToString());
                }
                else
                {
                    _classTime.Rows.Insert(i - 1, i.ToString());
                    _classTimeList.Add(i.ToString());
                }
            }
        }
        
        //設定_classTime
        private void SetDataGridView()
        {
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            _classTime.ColumnCount = 1;
            for (int i = 0; i < _classTimeName.Length; i++)
            {
                if (i > 0)
                    _classTime.Columns.Insert(i, new DataGridViewCheckBoxColumn());
                _classTime.Columns[i].Name = _classTimeName[i];
            }
            SetDataGridViewRow();
            _classTime.Rows.Insert(NOON_INDEX, NOON);
            _classTimeList.Insert(NOON_INDEX, NOON);
        }

        //設定_courseList
        private void SetListBox()
        {
            int index = _courseList.SelectedIndex;
            _className.Clear();
            _allCourses.Clear();
            _courseList.Items.Clear();
            foreach (Department department in _allDepartments)
            {
                _className.Add(department._name);
                _allCourses.Add(department._curriculum);
            }
            foreach (Course course in _allCourses._curriculum)
            {
                _courseList.Items.Add(course._name);
            }
            SetComboBox();
            _courseList.SelectedIndex = index;
        }

        //清除所有comboBox
        private void ClearComboBox()
        {
            _modeComboBox.Items.Clear();
            _required.Items.Clear();
            _hourList.Clear();
            _hour.Items.Clear();
            _class.Items.Clear();
        }

        //設定所有comboBox
        private void SetComboBox()
        {
            ClearComboBox();
            foreach (string m in _mode)
                _modeComboBox.Items.Add(m);
            foreach (string r in _requiredArray)
                _required.Items.Add(r);
            for (int i = 1; i <= HOUR_MAXIMUM; i++)
            {
                _hourList.Add(i.ToString());
                _hour.Items.Add(_hourList[i - 1]);
            }
            foreach (Department department in _allDepartments)
                _class.Items.Add(department._name);
        }

        //載入CourseSelectingForm
        private void LoadCourseManagementForm(object sender, EventArgs e)
        {
            _allDepartments = _model.GetAllDepartments();
            SetDataGridView();
            SetListBox();
            SetClassListBox();
            SetComboBox();
            _courseList.SelectedIndex = 0;
        }

        //設定開課班級
        private void SetClassName(int index)
        {
            Department temporaryDepartment = new Department();
            foreach (Department department in _allDepartments)
            {
                temporaryDepartment = department;
                if (!department.IsOutOfIndex(ref index))
                    break;
            }
            _class.SelectedIndex = _className.IndexOf(temporaryDepartment._name);
        }

        //設定上課時間
        private void SetClassTime(int index)
        {
            int day = 1;
            foreach (string time in _allCourses._curriculum[index]._classTime._classTimeList)
            {
                if (time.Length != 0)
                    foreach (string split in time.Split(' '))
                        _classTime.Rows[_classTimeList.IndexOf(split)].Cells[day].Value = true;
                day++;
            }
        }

        // Checkbox全選或取消
        private void SelectAllCheckBox(DataGridView dataGridView, Boolean status)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 1; j < dataGridView.ColumnCount; j++)
                    dataGridView.Rows[i].Cells[j].Value = status;
            }
        }

        //將所有欄位初始化
        private void InitializeCourseInfo()
        {
            _modeComboBox.SelectedIndex = 0;
            _number.Text = "";
            _courseName.Text = "";
            _stage.Text = "";
            _credit.Text = "";
            _teacher.Text = "";
            _required.SelectedIndex = 0;
            _assistant.Text = "";
            _language.Text = "";
            _note.Text = "";
            _hour.SelectedIndex = 0;
            _class.SelectedIndex = 0;
            SelectAllCheckBox(_classTime, false);
        }

        //刷新元件內容
        private void RefreshComponent()
        {
            _number.Text = _allCourses._curriculum[_courseList.SelectedIndex]._number;
            _courseName.Text = _allCourses._curriculum[_courseList.SelectedIndex]._name;
            _stage.Text = _allCourses._curriculum[_courseList.SelectedIndex]._stage;
            _credit.Text = _allCourses._curriculum[_courseList.SelectedIndex]._credit;
            _teacher.Text = _allCourses._curriculum[_courseList.SelectedIndex]._teacher;
            _required.SelectedIndex = Array.IndexOf(_requiredArray, _allCourses._curriculum[_courseList.SelectedIndex]._requiredOrElective);
            _assistant.Text = _allCourses._curriculum[_courseList.SelectedIndex]._teachingAssistant;
            _language.Text = _allCourses._curriculum[_courseList.SelectedIndex]._language;
            _note.Text = _allCourses._curriculum[_courseList.SelectedIndex]._note;
            _hour.SelectedIndex = _hourList.IndexOf(_allCourses._curriculum[_courseList.SelectedIndex]._hour);
        }

        //當_courseList選擇的項目改變時
        private void ChangeCourseListSelectedIndex(object sender, EventArgs e)
        {
            InitializeCourseInfo();
            EnableAllComponent(true);
            _allDepartments = _model.GetAllDepartments();
            _storeButton.Text = STORE;
            _courseInfo.Text = CHANGE_COURSE;
            _addCourseButton.Enabled = true;
            _modeComboBox.SelectedIndex = 0;
            RefreshComponent();
            SetClassName(_courseList.SelectedIndex);
            SetClassTime(_courseList.SelectedIndex);
            _presentationModel.SelectedIndexChanged();
            _presentationModel.SetNowTime(_allCourses._curriculum[_courseList.SelectedIndex]._classTime);
        }

        //當按下_addCourseButton
        private void ClickAddCourseButton(object sender, EventArgs e)
        {
            _storeButton.Text = ADD;
            _addCourseButton.Enabled = false;
            _storeButton.Enabled = false;
            _courseInfo.Text = ADD_COURSE;
            EnableAllComponent(true);
            InitializeCourseInfo();
        }

        //編輯課程
        private void ModifyCourse()
        {
            _storeButton.Enabled = false;
            ClassTime classTime = this.GetClassTime();
            Course newCourse = new Course(_model.GetCourse(_courseList.SelectedIndex), _number.Text, _courseName.Text, _stage.Text, _credit.Text, _teacher.Text, _required.Text, _assistant.Text, _language.Text, _note.Text, _hour.Text, classTime);
            _presentationModel.SetNowTime(classTime);
            if (_modeComboBox.Text == _mode[0])
                _model.ModifyCourse(_class.Text, _courseList.SelectedIndex, _allCourses.IndexAt(_courseList.SelectedIndex), newCourse);
            else
            {
                Course RemovedCourse = _allCourses.IndexAt(_courseList.SelectedIndex);
                _model.RemoveCourseAt(RemovedCourse);
                _model.RemoveAddedCourse(RemovedCourse);
            }
        }

        //新增課程
        private void AddCourse()
        {
            _addCourseButton.Enabled = true;
            _storeButton.Enabled = false;
            ClassTime classTime = this.GetClassTime();
            Course course = new Course(_number.Text, _courseName.Text, _stage.Text, _credit.Text, _teacher.Text, _required.Text, _assistant.Text, _language.Text, _note.Text, _hour.Text, classTime);
            _model.AddCourse(_class.Text, course);
            InitializeCourseInfo();
            EnableAllComponent(false);
        }

        //當按下_storeButton
        private void ClickStoreButton(object sender, EventArgs e)
        {
            if (_storeButton.Text == STORE)
            {
                ModifyCourse();
            }
            else
            {
                AddCourse();
            }
            SetListBox();
        }

        //控制所有元件的enable
        private void EnableAllComponent(bool status)
        {
            _modeComboBox.Enabled = status;
            _number.Enabled = status;
            _courseName.Enabled = status;
            _stage.Enabled = status;
            _credit.Enabled = status;
            _teacher.Enabled = status;
            _required.Enabled = status;
            _assistant.Enabled = status;
            _language.Enabled = status;
            _note.Enabled = status;
            _hour.Enabled = status;
            _class.Enabled = status;
        }

        //hour與DGV勾選的數量是否符合
        private bool IsHourEqual()
        {
            int number = 0;
            for (int i = 0; i < _classTime.ColumnCount - 1; i++)
                for (int j = 0; j < _classTime.RowCount; j++)
                    if (_classTime.Rows[j].Cells[i + 1].Value != null && (bool)_classTime.Rows[j].Cells[i + 1].Value)
                        number++;
            return number.ToString().Equals(_hour.Text);
        }

        //設定_presentationModel中的值
        private void SetPresentationModel()
        {
            _presentationModel.SetClass(_class.Text);
            _presentationModel.SetCredit(_credit.Text);
            _presentationModel.SetHour(_hour.Text);
            _presentationModel.SetName(_courseName.Text);
            _presentationModel.SetNumber(_number.Text);
            _presentationModel.SetRequired(_required.Text);
            _presentationModel.SetStage(_stage.Text);
            _presentationModel.SetTeacher(_teacher.Text);
        }
    }
}
