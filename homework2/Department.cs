using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Department
    {
        public Department()
        {
            this._name = "";
            this._code = "";
            this._curriculum = new Curriculum();
        }

        public Department(string name)
        {
            this._name = name;
            this._code = "";
            this._curriculum = new Curriculum();
        }

        public Department(string name, string code)
        {
            this._name = name;
            this._code = code;
            this._curriculum = new Curriculum();
        }

        public Department(string name, string code, Curriculum curriculum)
        {
            this._name = name;
            this._code = code;
            this._curriculum = curriculum;
        }

        public string _name
        {
            get; set;
        }

        public string _code
        {
            get; set;
        }

        public Curriculum _curriculum
        {
            get; set;
        }

        //刪除課程
        public void RemoveCourse(int index)
        {
            this._curriculum.RemoveAt(index);
        }

        //新增課程
        public void AddCourse(Course course)
        {
            this._curriculum.Add(course);
        }

        //回傳共幾堂課
        public int GetCourseCount()
        {
            int count = 0;
            foreach (Course course in this._curriculum._curriculum)
                count++;
            return count;
        }

        //修改課程(true)或刪除後新增課程(false)
        public bool ModifyOrRemove(string name, Course course, int index)
        {
            if (name != this._name)
            {
                //department._curriculum.RemoveAt(index);
                this.RemoveCourse(index);
                //this.AddCourse(course);
                return false;
            }
            else
            {
                this._curriculum.ModifyCourse(index, course);
            }
            return true;
        }

        //回傳是否超出index
        public bool IsOutOfIndex(ref int index)
        {
            if (index >= this.GetCourseCount())
            {
                index -= GetCourseCount();
                return true;
            }
            return false;
        }
        
        //根據輸入課程刪除指定課程，若無該課程則無動作
        public void RemoveCourse(Course inputCourse)
        {
            this._curriculum.Remove(inputCourse);
        }

    }
}
