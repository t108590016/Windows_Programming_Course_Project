using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class CourseManagementForm : Form
    {
        Model _model;
        const int HOUR = 13;
        const int CARRY = 10;
        const int LATTER = 65;
        const int ZERO = 48;
        const int NINE = 57;
        const int DOT = 46;
        const int BACK = 8;
        const int NOON_INDEX = 4;
        const int HOUR_MAXIMUM = 3;
        const string NOON = "N";
        const string STORE = "儲存";
        const string ADD = "新增";
        const string ADD_COURSE = "新增課程";
        const string CHANGE_COURSE = "編輯課程";
        const string SPACE_STRING = " ";
        const string ZERO_STRING = "0";
        CourseManagementFormPresentationModel _presentationModel;
        List<Department> _allDepartments = new List<Department>();
        Curriculum _allCourses = new Curriculum();
        List<string> _hourList = new List<string>();
        string[] _mode;
        string[] _requiredArray;
        string[] _classTimeName;
        List<string> _className = new List<string>();
        List<string> _classTimeList = new List<string>();
        //當_number的Text改變時
        private void ChangeNumberText(object sender, EventArgs e)
        {
            //_presentationModel.TextChanged(_number.Text);
            if (IsHourEqual())
                SetPresentationModel();
        }

        //當_courseName的Text改變時
        private void ChangeCourseNameText(object sender, EventArgs e)
        {
            //_presentationModel.TextChanged(_courseName.Text);
            if (IsHourEqual())
                SetPresentationModel();
        }

        //當_stage的Text改變時
        private void ChangeStageText(object sender, EventArgs e)
        {
            // _presentationModel.TextChanged(_stage.Text);
            if (IsHourEqual())
                SetPresentationModel();
        }

        //當_credit的Text改變時
        private void ChangeCreditText(object sender, EventArgs e)
        {
            // _presentationModel.TextChanged(_credit.Text);
            if (IsHourEqual())
                SetPresentationModel();
        }

        //當_teacher的Text改變時
        private void ChangeTeacherText(object sender, EventArgs e)
        {
            //_presentationModel.TextChanged(_teacher.Text);
            if (IsHourEqual())
                SetPresentationModel();
        }

        //當_required選擇的項目改變
        private void ChangeRequiredSelectedIndex(object sender, EventArgs e)
        {
            //_presentationModel.TextChanged(_required.Text);
            if (IsHourEqual())
                SetPresentationModel();
        }

        //當_hour選擇的項目改變
        private void ChangeHourSelectedValue(object sender, EventArgs e)
        {
            //_presentationModel.TextChanged(_hour.Text);
            if (IsHourEqual())
                SetPresentationModel();
            else
                _presentationModel.IsButtonEnabled = false;
        }

        //當_class選擇的項目改變
        private void ChangeClassSelectedValue(object sender, EventArgs e)
        {
            //_presentationModel.TextChanged(_class.Text);
            if (IsHourEqual())
                SetPresentationModel();
        }

        //僅能輸入數字與刪除
        private void InputNumberOnly(KeyPressEventArgs keyPressEvent)
        {
            if (((int)keyPressEvent.KeyChar < ZERO | (int)keyPressEvent.KeyChar > NINE) & (int)keyPressEvent.KeyChar != BACK)
            {
                keyPressEvent.Handled = true;
            }
        }

        //當在_number輸入字時
        private void PressNumberKey(object sender, KeyPressEventArgs e)
        {
            InputNumberOnly(e);
        }

        //當在_stage輸入字時
        private void PressStageKey(object sender, KeyPressEventArgs e)
        {
            InputNumberOnly(e);
        }

        //當在_credit輸入字時
        private void PressCreditKey(object sender, KeyPressEventArgs e)
        {
            const char DOT = '.';
            if ((int)e.KeyChar == DOT & !_credit.Text.Equals("") & !_credit.Text.Contains(DOT))
            {
                _credit.Text += DOT;
                _credit.Select(_credit.Text.Length, 0);
                e.Handled = true;
            }
            else
                InputNumberOnly(e);
        }

        //當_classTime的Cell改變值
        private void ChangeCellValue(object sender, DataGridViewCellEventArgs e)
        {
            _presentationModel.IsButtonEnabled = IsHourEqual() & !_presentationModel.GetNowTime().Equal(this.GetClassTime());
        }

        //當按下_classTime的Cell
        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            _classTime.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }

        //當關閉CourseManagementForm
        private void CloseCourseManagementForm(object sender, FormClosedEventArgs e)
        {
            _model.IsCourseManageButtonEnabled = true;
        }

        //獲取ClassTime
        private ClassTime GetClassTime()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < _classTimeName.Count() - 1; i++)
            {
                string time = "";
                for (int j = 0; j < _classTimeList.Count(); j++)
                    if (_classTime.Rows[j].Cells[i + 1].Value != null && (bool)_classTime.Rows[j].Cells[i + 1].Value)
                    {
                        if (time != "")
                            time += SPACE_STRING;
                        time += _classTimeList[j];
                    }
                result.Add(time);
            }
            return new ClassTime(result);
        }

        //設定_classList
        private void SetClassListBox()
        {
            int index = 0;
            _classList.Items.Clear();
            foreach (Department department in _allDepartments)
            {
                _classList.Items.Add(department._name);
            }
            _classList.SelectedIndex = index;
            SetCourseListInClass();
        }

        //設定_courseListInClass
        private void SetCourseListInClass()
        {
            _classNameTextBox.Enabled = false;
            int index = _classList.SelectedIndex;
            _courseListInClass.Items.Clear();
            foreach (Course course in _allDepartments[index]._curriculum._curriculum)
            {
                _courseListInClass.Items.Add(course._name);
            }
        }

        //當按下_importButton
        private void ClickImportButton(object sender, EventArgs e)
        {
            _importButton.Enabled = false;
            _model.ProgressChanged = ZERO_STRING;
            ImportingCourseForm importingCourseForm = new ImportingCourseForm(_model, new ImportCourseFormPresentationModel(_model));
            importingCourseForm.Show();
        }

        //當_modeComboBox選擇的值改變時
        private void ChangeModeComboBoxSelectedValue(object sender, EventArgs e)
        {
            if (IsHourEqual())
                SetPresentationModel();
        }

        //_classList的index改變時
        private void ChangeClassListIndex(object sender, EventArgs e)
        {
            if (_classList.SelectedIndex != -1)
            {
                SetCourseListInClass();
                _classNameTextBox.Text = _classList.SelectedItem.ToString();
                _addClassButton.Enabled = true;
                _addButton.Enabled = false;
            }
        }

        //當按下_addClassButton
        private void ClickAddClassButton(object sender, EventArgs e)
        {
            _classNameTextBox.Enabled = true;
            _addClassButton.Enabled = false;
            _classList.ClearSelected();
            _classNameTextBox.Text = "";
            _courseListInClass.Items.Clear();
        }

        //改變_classNameTextBox的字時
        private void ChangeClassNameTextBox(object sender, EventArgs e)
        {
            if (_classNameTextBox.Text != "")
                _addButton.Enabled = true;
        }

        //當按下_addButton
        private void ClickAddButton(object sender, EventArgs e)
        {
            _model.AddDepartment(new Department(_classNameTextBox.Text));
            SetClassListBox();
            _addButton.Enabled = false;
            _addClassButton.Enabled = true;
        }
    }
}
