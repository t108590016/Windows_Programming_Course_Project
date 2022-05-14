using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class ClassTime
    {
        public ClassTime()
        {
            this._classTimeList = new List<string>();
        }

        public ClassTime(List<string> input)
        {
            const int SUNDAY = 0;
            const int MONDAY = 1;
            const int TUESDAY = 2;
            const int WEDNESDAY = 3;
            const int THURSDAY = 4;
            const int FRIDAY = 5;
            const int SATURDAY = 6;
            this._classTimeSunday = input[SUNDAY];
            this._classTimeMonday = input[MONDAY];
            this._classTimeTuesday = input[TUESDAY];
            this._classTimeWednesday = input[WEDNESDAY];
            this._classTimeThursday = input[THURSDAY];
            this._classTimeFriday = input[FRIDAY];
            this._classTimeSaturday = input[SATURDAY];
            this._classTimeList = input;
        }

        public string _classTimeSunday
        {
            get; set;
        }

        public string _classTimeMonday
        {
            get; set;
        }

        public string _classTimeTuesday
        {
            get; set;
        }

        public string _classTimeWednesday
        {
            get; set;
        }

        public string _classTimeThursday
        {
            get; set;
        }

        public string _classTimeFriday
        {
            get; set;
        }

        public string _classTimeSaturday
        {
            get; set;
        }

        public List<string> _classTimeList
        {
            get; set;
        }

        //回傳是否為空
        public bool IsNull()
        {
            foreach (string time in _classTimeList)
                if (time != "")
                    return false;
            return true;
        }

        //是否有衝堂
        private bool IsSameTime(string[] week, string[] anotherWeek)
        {
            for (int i = 0; i < week.Length; i++)
            {
                if (week[i].Equals(""))
                    break;
                for (int j = 0; j < anotherWeek.Length; j++)
                {
                    if (anotherWeek[j].Equals(""))
                        break;
                    else if (week[i].Equals(anotherWeek[j]))
                        return true;
                }
            }
            return false;
        }

        //確認是否為相同時段
        public bool CheckSameTime(ClassTime anotherTime)
        {
            const char SPACE = ' ';
            string[] week;
            string[] anotherWeek;
            for (int i = 0; i < this._classTimeList.Count; i++)
            {
                week = this._classTimeList[i].Split(SPACE);
                anotherWeek = anotherTime._classTimeList[i].Split(SPACE);
                if (IsSameTime(week, anotherWeek))
                    return true;
            }
            return false;
        }

        //是否相同
        public bool Equal(ClassTime anotherTime)
        {
            for (int i = 0; i < this._classTimeList.Count(); i++)
                if (!this._classTimeList[i].Equals(anotherTime._classTimeList[i]))
                    return false;
            return true;
        }
    }
}
