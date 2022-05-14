using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace homework2
{
    public class CourseManagementFormPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Model _model;
        const string NOTIFY = "IsButtonEnabled";
        const string NUMBER = "節數";
        const string SUNDAY = "日";
        const string MONDAY = "一";
        const string TUESDAY = "二";
        const string WEDNESDAY = "三";
        const string THURSDAY = "四";
        const string FRIDAY = "五";
        const string SATURDAY = "六";
        const string MODE_OPEN = "開課";
        const string MODE_CLOSE = "停開";
        const string REQUIRED_ONE = "○";
        const string REQUIRED_TWO = "△";
        const string REQUIRED_THREE = "☆";
        const string REQUIRED_FOUR = "●";
        const string REQUIRED_FIVE = "▲";
        const string REQUIRED_SIX = "★";
        string[] _mode = { MODE_OPEN, MODE_CLOSE };
        string[] _requiredArray = { REQUIRED_ONE, REQUIRED_TWO, REQUIRED_THREE, REQUIRED_FOUR, REQUIRED_FIVE, REQUIRED_SIX };
        string[] _classTimeName = { NUMBER, SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY };
        string _number;
        string _name;
        string _stage;
        string _credit;
        string _teacher;
        string _required;
        string _hour;
        string _class;
        List<List<bool>> _status = new List<List<bool>>();
        bool _isButtonEnabled = false;
        ClassTime _nowTime = new ClassTime();
        public bool IsButtonEnabled
        {
            //沒有這樣做不能binding
            get
            {
                return _isButtonEnabled;
            }
            set
            {
                _isButtonEnabled = value;
                Notify(NOTIFY);
            }
        }

        public CourseManagementFormPresentationModel(Model model)
        {
            this._model = model;
        }

        //是否為空
        public void IsNull()
        {
            if (_number != "" && _name != "" && _stage != "" && _credit != "" && _teacher != "" && _required != "" && _hour != "" && _class != "")
                _isButtonEnabled = true;
        }

        //設定_number
        public void SetNumber(string number)
        {
            this._number = number;
            if (_number == "" && _number == number)
                _isButtonEnabled = false;
            IsNull();
            Notify(NOTIFY);
        }

        //設定_name
        public void SetName(string name)
        {
            this._name = name;
            if (_name == "")
                _isButtonEnabled = false;
            IsNull();
            Notify(NOTIFY);
        }

        //設定_stage
        public void SetStage(string stage)
        {
            this._stage = stage;
            if (_stage == "")
                _isButtonEnabled = false;
            IsNull();
            Notify(NOTIFY);
        }

        //設定_credit
        public void SetCredit(string credit)
        {
            this._credit = credit;
            if (_credit == "")
                _isButtonEnabled = false;
            IsNull();
            Notify(NOTIFY);
        }

        //設定_teacher
        public void SetTeacher(string teacher)
        {
            this._teacher = teacher;
            if (_teacher == "")
                _isButtonEnabled = false;
            IsNull();
            Notify(NOTIFY);
        }

        //設定_required
        public void SetRequired(string required)
        {
            this._required = required;
            if (_required == "")
                _isButtonEnabled = false;
            IsNull();
            Notify(NOTIFY);
        }

        //設定_hour
        public void SetHour(string hour)
        {
            this._hour = hour;
            if (_hour == "")
                _isButtonEnabled = false;
            IsNull();
            Notify(NOTIFY);
        }

        //設定_class
        public void SetClass(string className)
        {
            this._class = className;
            if (_class == "")
                _isButtonEnabled = false;
            IsNull();
            Notify(NOTIFY);
        }

        //設定_nowTime
        public void SetNowTime(ClassTime classTime)
        {
            this._nowTime = classTime;
        }

        //回傳_nowTime
        public ClassTime GetNowTime()
        {
            return _nowTime;
        }

        //是否有通知
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //ListBox改變index
        public void SelectedIndexChanged()
        {
            _isButtonEnabled = false;
            Notify(NOTIFY);
        }

        //回傳_mode
        public string[] GetMode()
        {
            return _mode;
        }

        //回傳_requiredArray
        public string[] GetRequiredArray()
        {
            return _requiredArray;
        }

        //回傳_classTimeName
        public string[] GetClassTimeName()
        {
            return _classTimeName;
        }
    }
}
