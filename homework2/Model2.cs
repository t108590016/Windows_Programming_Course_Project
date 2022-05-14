using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public partial class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        const int DELAY = 500;
        const int PROGRESS_MAXIMUM = 100;
        const int COLUMNS = 23;
        const string NOTIFY_COURSE_MANAGE = "IsCourseManageButtonEnabled";
        const string NOTIFY_COURSE_SELECT = "IsCourseSelectButtonEnabled";
        const string NOTIFY_CHECK_RESULT = "IsCheckResultButtonEnabled";
        const string NOTIFY_ADD_TAB_CONTROL = "AddDepartment";
        const string NOTIFY_PROGRESS = "ProgressChanged";
        const string NOTIFY_PROGRESS_BAR = "ProgressBarValueChanged";
        const string INFORMATION_THIRD = "資工三";
        const string CODE_INFORMATION_THIRD = "2433";
        const string ELECTRONIC_THIRD = "電子三甲";
        const string CODE_ELECTRONIC_THIRD = "2423";
        const string IMPORTING = "正在匯入課程......";
        const string IMPORTED = "匯入完成！";
        const string PERCENT = "%";
        const string LINK = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=";
        string[] _allClassName = { INFORMATION_THIRD, ELECTRONIC_THIRD };
        string[] _allClassCode = { CODE_INFORMATION_THIRD, CODE_ELECTRONIC_THIRD };
        private int _columnsNumber = COLUMNS;
        Curriculum _addedCourse = new Curriculum();
        List<Department> _allDepartments = new List<Department>();
        bool _isCourseManageButtonEnabled = true;
        bool _isCourseSelectButtonEnabled = true;
        bool _isCheckResultButtonEnabled = false;
        string _progress = "";
        int _progressBarValue = 0;

        public string ProgressChanged
        {
            get
            {
                return _progress;
            }
            set
            {
                _progress = value;
                Notify(NOTIFY_PROGRESS);
            }
        }

        public int ProgressBarValueChanged
        {
            get
            {
                return _progressBarValue;
            }
            set
            {
                _progressBarValue = value;
                Notify(NOTIFY_PROGRESS_BAR);
            }
        }

        public bool IsCourseManageButtonEnabled
        {
            get
            {
                return _isCourseManageButtonEnabled;
            }
            set
            {
                _isCourseManageButtonEnabled = value;
                Notify(NOTIFY_COURSE_MANAGE);
            }
        }

        public bool IsCourseSelectButtonEnabled
        {
            get
            {
                return _isCourseSelectButtonEnabled;
            }
            set
            {
                _isCourseSelectButtonEnabled = value;
                Notify(NOTIFY_COURSE_SELECT);
            }
        }

        public bool IsCheckResultButtonEnabled
        {
            get
            {
                return _isCheckResultButtonEnabled;
            }
            set
            {
                _isCheckResultButtonEnabled = value;
                Notify(NOTIFY_CHECK_RESULT);
            }
        }

        //刪除前N個元素
        private void RemoveFirstElements(HtmlNodeCollection nodeTableRow, int number)
        {
            for (int i = 0; i < number; i++)
            {
                nodeTableRow.RemoveAt(0);
            }
        }

        //刪除指定index的元素
        private void RemoveAt(HtmlNodeCollection nodeTableRow, int index)
        {
            nodeTableRow.RemoveAt(index);
        }

        //獲取html中的table
        private HtmlNodeCollection GetWebTables(string link)
        {
            const string NODE = "//body/table";
            HtmlWeb webClient = new HtmlWeb();
            webClient.OverrideEncoding = Encoding.Default;
            HtmlAgilityPack.HtmlDocument document = webClient.Load(link);
            HtmlNode nodeTable = document.DocumentNode.SelectSingleNode(NODE);
            HtmlNodeCollection nodeTableRow = nodeTable.ChildNodes;
            return nodeTableRow;
        }

        //將node中的每一項做Trim()
        private List<string> TrimAllNodes(HtmlNodeCollection nodeDatas, int numbers)
        {
            List<string> datas = new List<string>();
            for (int i = 0; i < numbers; i++)
            {
                datas.Add(nodeDatas[i].InnerText.Trim());
            }
            return datas;
        }

        //獲取課程資訊
        private Curriculum GetCourseInfo(string link, int burden)
        {
            HtmlNodeCollection nodeTableRow = this.GetWebTables(link);
            Curriculum courseInfoDetail = new Curriculum();
            RemoveFirstElements(nodeTableRow, burden); // 移除 tbody, <tr>資工三, table header
            RemoveAt(nodeTableRow, nodeTableRow.Count - 1);
            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                nodeTableDatas.RemoveAt(0); // 移除 #text
                Course temporaryCourse = new Course(TrimAllNodes(nodeTableDatas, _columnsNumber));
                if (!IsDuplicateNumber(temporaryCourse) & courseInfoDetail.FindCourseIndexByNumber(temporaryCourse._number) == -1)
                    courseInfoDetail.Add(temporaryCourse);
            }
            return courseInfoDetail;
        }

        //是否已有相同課號的課程
        public bool IsDuplicateNumber(Course inputCourse)
        {
            foreach (Department department in _allDepartments)
                foreach (Course course in department._curriculum._curriculum)
                    if (inputCourse.IsNumberEqual(course))
                        return true;
            return false;
        }

        //獲取課程內容的欄位名稱
        public string[] GetCourseTitle()
        {
            const string LINK = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
            const int BURDEN = 2;
            string link = LINK;
            int burden = BURDEN;
            HtmlNodeCollection nodeTableRow = this.GetWebTables(link);
            RemoveFirstElements(nodeTableRow, burden);
            List<string> title = new List<string>();
            HtmlNodeCollection nodeTableDatas = nodeTableRow[0].ChildNodes;
            foreach (var node in nodeTableDatas)
            {
                title.Add(node.InnerText.Trim());
            }
            _columnsNumber = title.Count();
            return title.ToArray();
        }

    }
}
