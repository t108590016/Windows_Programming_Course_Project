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
    public partial class CourseSelectingForm : Form
    {
        CourseSelectingFormPresentationModel _presentationModel;
        string[] _datasName;
        Model _model;
        List<DataGridView> _allDataGridView = new List<DataGridView>();
        //DataGridView _computerScience = new DataGridView();
        //DataGridView _electronicEngineer = new DataGridView();
        //Department _informationThird = new Department("資工三", "2433");
        //Department _electronicThird = new Department("電子三甲", "2423");
        //Department _informationThird;
        //Department _electronicThird;
        List<Department> _allDepartments = new List<Department>();

        public CourseSelectingForm(CourseSelectingFormPresentationModel presentationModel, Model model)
        {
            this._model = model;
            this._presentationModel = presentationModel;
            int count = _model.GetAllDepartments().Count;
            for (int i = 0; i < count; i++)
                _allDepartments.Add(new Department());
            _model._modelChanged += Update;
            _model.NotifyObserver();
            _model._modelChanged += UpdateView;
            InitializeComponent();
            RefreshDepartments();
            RefreshDataGridView();
            RefreshTab();
            _checkResultButton.DataBindings.Add("Enabled", this._model, "IsCheckResultButtonEnabled");
        }

        //刷新
        static new void Update()
        {
            System.Console.WriteLine("Notified");
        }

        //刷新頁面
        private void UpdateView()
        {
            RefreshDepartments();
            Invalidate();
            RefreshDataGridView();
            RefreshTab();
            for (int i = 0; i < _allDataGridView.Count(); i++)
            {
                RefreshDataGridView(_allDataGridView[i], i);
                if (!_tabControl.TabPages[i].Text.Equals(_allDepartments[i]._name))
                    _tabControl.TabPages.Add(_allDepartments[i]._name);
            }
            RefreshButtonState();
        }

        //刷新DataGridView
        private void RefreshDataGridView()
        {
            _allDataGridView.Clear();
            for (int i = 0; i < _allDepartments.Count; i++)
            {
                _allDataGridView.Add(new DataGridView());
                SetDefaultDataGridView(_allDataGridView[i]);
                InitializeDataGridViewValue(_allDataGridView[i], _allDepartments[i], i);
                _allDataGridView[i].CellContentClick += ClickComputerScienceCellContent;
                _allDataGridView[i].CellValueChanged += ChangedComputerScienceThirdCellValue;
                _allDataGridView[i].Name = "_dataGridView" + i.ToString();
            }
        }

        //刷新頁面
        private void RefreshTab()
        {
            _tabControl.TabPages.Clear();
            _computerScienceThirdPage.Controls.Clear();
            for (int i = 0; i < _allDepartments.Count; i++)
            {
                _tabControl.TabPages.Add(_allDepartments[i]._name);
                (_tabControl.TabPages[i]).Controls.Add(_allDataGridView[i]);
            }
            //_tabControl.SelectedIndex = 0;
            //_computerScienceThirdPage.Controls.Add(_allDataGridView[0]);
        }

        //刷新科系
        private void RefreshDepartments()
        {
            _allDepartments.Clear();
            foreach (Department department in _model.GetAllDepartments())
                _allDepartments.Add(department);
            _datasName = _model.GetCourseTitle();
        }

        public CourseSelectingForm()
        {
            InitializeComponent();
        }

        //載入CourseSelectingForm
        private void LoadCourseSelectingForm(object sender, EventArgs e)
        {
            //_computerScienceThirdPage.Controls.Add(_allDataGridView[0]);
            //_computerScienceThirdPage.Show();
        }

        //設定DataGridView的預設屬性
        private void SetDefaultDataGridView(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.RowHeadersVisible = false;
        }

        //初始化DataGridView的內容
        private void InitializeDataGridViewValue(DataGridView dataGridView, Department department, int index)
        {
            dataGridView.ColumnCount = _model.GetColumnsNumber();
            SetDataGridView(dataGridView, department._curriculum);
        }

        //設定DataGridView的值
        private void SetDataGridView(DataGridView dataGridView, Curriculum datasList)
        {
            bool isNotNull = datasList.GetCount() != 0;
            //isNotNull &= _presentationModel.GetAllDataList().GetCount() != 0;
            isNotNull &= _model.GetAddedCourseCount() != 0;
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            column.HeaderText = "選";
            dataGridView.ColumnCount = _model.GetColumnsNumber();
            for (int i = 0; i < dataGridView.ColumnCount; i++)
                dataGridView.Columns[i].Name = _datasName[i];
            Curriculum choice = datasList;
            if (isNotNull)
                choice = choice.FindDifferentCourse(_presentationModel.GetAllDataList());
            foreach (Course course in choice._curriculum)
            {
                dataGridView.Rows.Add(course._toList.ToArray());
            }
            dataGridView.Columns.Insert(0, column);
        }

        //設定DataGridView的值
        private void AddDataGridViewValue(DataGridView dataGridView, List<string> data)
        {
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            dataGridView.Rows.Add(data.ToArray());
            dataGridView.Columns.RemoveAt(0);
            dataGridView.Columns.Insert(0, column);
        }

        //刷新按鈕的狀態
        private void RefreshButtonState()
        {
            _confirmButton.Enabled = _presentationModel.IsConfirmEnabled();
            _model.IsCheckResultButtonEnabled = _presentationModel.IsCheckEnabled();
        }

        //刷新DataGridView的內容
        private void RefreshDataGridView(DataGridView dataGridView, int index)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            SetDataGridView(_allDataGridView[index], _allDepartments[index]._curriculum);
            /*if (index == 0)
                SetDataGridView(dataGridView, _informationThird._curriculum);
            else
                SetDataGridView(dataGridView, _electronicThird._curriculum);*/
            _presentationModel.ClearCourse();
        }

        //當按下ComputerScience的CellContent
        private void ClickComputerScienceCellContent(object sender, DataGridViewCellEventArgs e)
        {
            int index = _tabControl.SelectedIndex;
            _allDataGridView[index].CommitEdit(DataGridViewDataErrorContexts.Commit);
            //_computerScience.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        //當ComputerScienceThird的CellValue改變時
        private void ChangedComputerScienceThirdCellValue(object sender, DataGridViewCellEventArgs e)
        {
            int index = _tabControl.SelectedIndex;
            if ((bool)_allDataGridView[index][0, e.RowIndex].Value)
                _presentationModel.AddCourse(_allDepartments[index]._curriculum.FindDifferentCourse(_model.GetAddedCourse()).IndexAt(e.RowIndex));
            else
                _presentationModel.RemoveCourse(_allDepartments[index]._curriculum.IndexAt(e.RowIndex));
            RefreshButtonState();
        }
        
        //當按下ConfirmButton時
        private void ClickConfirmButton(object sender, EventArgs e)
        {
            MessageBox.Show(_presentationModel.CourseConflict());
            if (!_presentationModel.IsConflict())
            {
                RefreshDataGridView();
                RefreshButtonState();
                _model.NotifyObserver();
            }
        }

        //當按下CheckResultButton時
        private void ClickCheckResultButton(object sender, EventArgs e)
        {
            CourseSelectionResultForm courseSelectionResultForm = new CourseSelectionResultForm(new CourseSelectionResultFormPresentationModel(_model), _model);
            courseSelectionResultForm.SetAllDataList(_model.GetAddedCourse());
            courseSelectionResultForm.SetDatasName(_datasName);
            courseSelectionResultForm.Show();
            _model.IsCheckResultButtonEnabled = false;
        }
        
        //當關閉CourseSelectingForm
        private void CloseCourseSelectingForm(object sender, FormClosedEventArgs e)
        {
            _model.IsCourseSelectButtonEnabled = true;
        }
    }
}
