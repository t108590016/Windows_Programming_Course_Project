using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Course
    {
        const string NUMBER_ERROR = "課號相同：「";
        const string NAME_ERROR = "課程名稱相同：「";
        const string CONFLICT = "衝堂：「";
        const string DASH = "-";
        const string MIDDLE = "」、「";
        const string END = "」\n";
        const int NUMBER = 0;
        const int NAME = 1;
        const int STAGE = 2;
        const int CREDIT = 3;
        const int HOUR = 4;
        const int REQUIRED = 5;
        const int TEACHER = 6;
        const int WEEK = 7;
        const int CLASSROOM = 14;
        const int PEOPLE = 15;
        const int WITHDRAW = 16;
        const int ASSISTANT = 17;
        const int LANGUAGE = 18;
        const int SCHEDULE = 19;
        const int NOTE = 20;
        const int ATTACHED = 21;
        const int EXPERIMENT = 22;
        public Course()
        {
            this._toList = new List<string>();
            this._classTime = new ClassTime();
            this._number = "";
            this._name = "";
            this._stage = "";
            this._credit = "";
            this._teacher = "";
            this._requiredOrElective = "";
            this._teachingAssistant = "";
            this._language = "";
            this._note = "";
            this._hour = "";
            this._classroom = "";
            this._numberOfPeople = "";
            this._numberOfWithdraw = "";
            this._schedule = "";
            this._classAttached = "";
            this._experiment = "";
        }

        public Course(string number, string name, string stage, string credit, string teacher, string requiredOrElective, string teacherAssistant, string language, string note, string hour, ClassTime classTime)
        {
            this._toList = new List<string>();
            this._number = number;
            this._name = name;
            this._stage = stage;
            this._credit = credit;
            this._teacher = teacher;
            this._requiredOrElective = requiredOrElective;
            this._teachingAssistant = teacherAssistant;
            this._language = language;
            this._note = note;
            this._hour = hour;
            this._classTime = classTime;
            this._classroom = "";
            this._numberOfPeople = "";
            this._numberOfWithdraw = "";
            this._schedule = "";
            this._classAttached = "";
            this._experiment = "";
            this._toList.Add(_number);
            this._toList.Add(_name);
            this._toList.Add(_stage);
            this._toList.Add(_credit);
            this._toList.Add(_hour);
            this._toList.Add(_requiredOrElective);
            this._toList.Add(_teacher);
            this._toList.AddRange(_classTime._classTimeList);
            this._toList.Add(_classroom);
            this._toList.Add(_numberOfPeople);
            this._toList.Add(_numberOfWithdraw);
            this._toList.Add(_teachingAssistant);
            this._toList.Add(_language);
            this._toList.Add(_schedule);
            this._toList.Add(_note);
            this._toList.Add(_classAttached);
            this._toList.Add(_experiment);
        }

        public Course(List<string> input)
        {

            this._number = input[NUMBER];
            this._name = input[NAME];
            this._stage = input[STAGE];
            this._credit = input[CREDIT];
            this._hour = input[HOUR];
            this._requiredOrElective = input[REQUIRED];
            this._teacher = input[TEACHER];
            this._classTime = new ClassTime(input.GetRange(WEEK, WEEK));
            this._classroom = input[CLASSROOM];
            this._numberOfPeople = input[PEOPLE];
            this._numberOfWithdraw = input[WITHDRAW];
            this._teachingAssistant = input[ASSISTANT];
            this._language = input[LANGUAGE];
            this._schedule = input[SCHEDULE];
            this._note = input[NOTE];
            this._classAttached = input[ATTACHED];
            this._experiment = input[EXPERIMENT];
            this._toList = input;
        }

        public Course(Course course, string number, string courseName, string stage, string credit, string teacher, string required, string assistant, string language, string note, string hour, ClassTime classTime)
        {
            this._number = number;
            this._name = courseName;
            this._stage = stage;
            this._credit = credit;
            this._hour = hour;
            this._requiredOrElective = required;
            this._teacher = teacher;
            this._classTime = classTime;
            this._classroom = course._classroom;
            this._numberOfPeople = course._numberOfPeople;
            this._numberOfWithdraw = course._numberOfWithdraw;
            this._teachingAssistant = assistant;
            this._language = language;
            this._schedule = course._schedule;
            this._note = note;
            this._classAttached = course._classAttached;
            this._experiment = course._experiment;
            List<string> result = new List<string>();
            result.Add(this._number);
            result.Add(this._name);
            result.Add(this._stage);
            result.Add(this._credit);
            result.Add(this._hour);
            result.Add(this._requiredOrElective);
            result.Add(this._teacher);
            result.AddRange(this._classTime._classTimeList);
            result.Add(this._classroom);
            result.Add(this._numberOfPeople);
            result.Add(this._numberOfWithdraw);
            result.Add(this._teachingAssistant);
            result.Add(this._language);
            result.Add(this._schedule);
            result.Add(this._note);
            result.Add(this._classAttached);
            result.Add(this._experiment);
            this._toList = result;
        }

        public string _number
        {
            get; set;
        }
        
        public string _name
        {
            get; set;
        }
        
        public string _stage
        {
            get; set;
        }
        
        public string _credit
        {
            get; set;
        }
        
        public string _hour
        {
            get; set;
        }
       
        public string _requiredOrElective
        {
            get; set;
        }
        
        public string _teacher
        {
            get; set;
        }

        public ClassTime _classTime
        {
            get; set;
        }

        public string _classroom
        {
            get; set;
        }
        
        public string _numberOfPeople
        {
            get; set;
        }

        public string _numberOfWithdraw
        {
            get; set;
        }

        public string _teachingAssistant
        {
            get; set;
        }

        public string _language
        {
            get; set;
        }

        public string _schedule
        {
            get; set;
        }

        public string _note
        {
            get; set;
        }

        public string _classAttached
        {
            get; set;
        }

        public string _experiment
        {
            get; set;
        }

        public List<string> _toList
        {
            get; set;
        }

        //是否為同一門課程
        public bool Equals(Course anotherCourse)
        {
            if (this._toList.Equals(new List<string>()) || anotherCourse._toList.Equals(new List<string>()))
                return false;
            return this._toList.Equals(anotherCourse._toList);
        }
        
        //課號是否相同
        public bool IsNumberEqual(Course anotherCourse)
        {
            return this._number.Equals(anotherCourse._number);
        }

        //課程名稱是否相同
        public bool IsNameEqual(Course anotherCourse)
        {
            return this._name.Equals(anotherCourse._name);
        }

        //兩門課程是否衝堂
        public string CheckConflict(Course anotherCourse)
        {
            const int WEEK = 7;
            if (this.IsNumberEqual(anotherCourse))
                return NUMBER_ERROR + this._number + DASH + this._name + MIDDLE + anotherCourse._number + DASH + anotherCourse._name + END;
            else if (this.IsNameEqual(anotherCourse))
                return NAME_ERROR + this._number + DASH + this._name + MIDDLE + anotherCourse._number + DASH + anotherCourse._name + END;
            else
                for (int i = 0; i < WEEK; i++)
                {
                    if (this._classTime.CheckSameTime(anotherCourse._classTime))
                        return CONFLICT + this._number + DASH + this._name + MIDDLE + anotherCourse._number + DASH + anotherCourse._name + END;
                }
            return "";
        }
    }
}
