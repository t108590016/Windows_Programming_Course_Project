using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class CourseSelectingFormPresentationModel
    {
        Model _model;
        bool _isConfirmEnabled;
        bool _isConflict;
        Curriculum _allDatasList = new Curriculum();
        Curriculum _addedDatasList = new Curriculum();

        const string NUMBER = "課號相同：「";
        const string NAME = "課程名稱相同：「";
        const string CONFLICT = "衝堂：「";
        const string DASH = "-";
        const string MIDDLE = "」、「";
        const string END = "」\n";
        public CourseSelectingFormPresentationModel(Model model)
        {
            this._model = model;
        }

        //加選課程
        public void AddCourse(Course course)
        {
            _addedDatasList.Add(course);
            SetConfirmEnabled();
        }

        //刪除課程
        public void RemoveCourse(Course course)
        {
            _addedDatasList.Remove(course);
        }

        //清空已選課程
        public void ClearCourse()
        {
            _addedDatasList = new Curriculum();
            SetConfirmEnabled();
        }

        //設定ConfirmButton的enable
        public void SetConfirmEnabled()
        {
            _isConfirmEnabled = _addedDatasList.GetCount() > 0;
        }

        //回傳ConfirmButton的enable
        public bool IsConfirmEnabled()
        {
            return _isConfirmEnabled;
        }

        //回傳CheckButton的enable
        public bool IsCheckEnabled()
        {
            return _model.GetAddedCourse().GetCount() > 0;
        }

        //是否與已加選課程衝突，如果有則回傳衝突內容，無則回傳空字串
        public string IsAddedCourseConflict(Course inputCourse)
        {
            string result = "";
            Curriculum addedCourse = _model.GetAddedCourse();
            foreach (Course course in _model.GetAddedCourse()._curriculum)
                result += course.CheckConflict(inputCourse);
                //result += CheckConflict(course, inputCourse);
            return result;
        }

        //如果加選成功回傳加選成功，加選失敗回傳加選失敗+原本的衝突訊息
        public string CheckResult(string result)
        {
            const string SUCCESS = "加選成功";
            const string FAILURE = "加選失敗\n";
            if (result.Equals(""))
            {
                _model.AddCourse(_addedDatasList);
                _addedDatasList = new Curriculum();
                _isConflict = false;
                return SUCCESS;
            }
            _isConflict = true;
            return FAILURE + result;
        }

        //課號相同、課程名稱相同或衝堂
        public string CourseConflict()
        {
            string result = "";
            if (_model.GetAddedCourseCount() > 0)
                foreach (Course course in _addedDatasList._curriculum)
                    result += IsAddedCourseConflict(course);
            result += _addedDatasList.CourseConflict();
            return CheckResult(result);
        }

        //回傳AllDatasList
        public Curriculum GetAllDataList()
        {
            return _model.GetAddedCourse();
        }

        //回傳_addedDatasList
        public Curriculum GetAddedCourse()
        {
            return _addedDatasList;
        }

        //是否衝突
        public bool IsConflict()
        {
            return _isConflict;
        }

    }
}
