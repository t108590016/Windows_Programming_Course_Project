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
    public partial class CourseSelectionResultForm : Form
    {
        Model _model;
        CourseSelectionResultFormPresentationModel _presentationModel;
        Curriculum _allDataList;
        string[] _datasName;
        public CourseSelectionResultForm(CourseSelectionResultFormPresentationModel presentationModel, Model model)
        {
            this._presentationModel = presentationModel;
            this._model = model;
            _model._modelChanged += Update;
            //_model.SetState();
            _model.NotifyObserver();
            _model._modelChanged += UpdateView;
            InitializeComponent();
        }

        //刷新
        static new void Update()
        {
            System.Console.WriteLine("Notified");
        }

        //刷新頁面
        private void UpdateView()
        {
            Invalidate();
            SetDataGridViewValue();
        }

        //載入CourseSelectionResultForm
        private void LoadCourseSelectionResultForm(object sender, EventArgs e)
        {
            SetDataGridViewValue();
        }

        //設定AllDataList
        public void SetAllDataList(Curriculum allDataList)
        {
            this._allDataList = allDataList;
            _presentationModel.SetAllCourseList(_allDataList);
        }

        //設定DatasName
        public void SetDatasName(string[] datasName)
        {
            this._datasName = datasName;
        }

        //清除DataGridView的所有值
        private void ClearDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
        }

        //新增列
        private void AddRow(DataGridView dataGridView, Curriculum curriculum)
        {
            string[] array;
            foreach (Course c in curriculum._curriculum)
            {
                array = c._toList.ToArray();
                dataGridView.Rows.Add(array);
            }
        }

        //設定column名字
        private void SetDataGridViewColumnName(DataGridView dataGridView, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
                dataGridView.Columns[i].Name = array[i];
        }

        //設定DataGridView的內容
        private void SetDataGridViewValue()
        {
            const string WITHDRAW = "退選";
            ClearDataGridView(_courseSelectionResult);
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Text = WITHDRAW;
            column.HeaderText = WITHDRAW;
            _courseSelectionResult.ColumnCount = _datasName.Length;
            SetDataGridViewColumnName(_courseSelectionResult, _datasName);
            AddRow(_courseSelectionResult, _allDataList);
            _courseSelectionResult.Columns.Insert(0, column);
            for (int i = 0; i < _allDataList.GetCount(); i++)
                _courseSelectionResult.Rows[i].Cells[0].Value = WITHDRAW;
        }

        //當按下ComputerScience的CellContent
        private void ClickCellContent(object sender, DataGridViewCellEventArgs e)
        {
            _courseSelectionResult.CommitEdit(DataGridViewDataErrorContexts.Commit);
            _courseSelectionResult.Rows.Remove(_courseSelectionResult.Rows[e.RowIndex]);
            _presentationModel.RemoveRow(e.RowIndex);
            _model.NotifyObserver();
        }

        //當關閉CourseSelectionResultForm
        private void CloseCourseSelectionResultForm(object sender, FormClosedEventArgs e)
        {
            //_model.IsCheckResultButtonEnabled = true;
            _model.IsAddedCourse();
        }
    }
}
