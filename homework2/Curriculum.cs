using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Curriculum
    {
        public Curriculum()
        {
            this._curriculum = new List<Course>();
        }

        public Curriculum(List<Course> curriculum)
        {
            this._curriculum = curriculum;
        }

        public Curriculum(Curriculum curriculum)
        {
            this._curriculum = curriculum._curriculum;
        }

        public List<Course> _curriculum
        {
            get; set;
        }

        //增加課程
        public void Add(Course course)
        {
            this._curriculum.Add(course);
        }

        //增加課程
        public void Add(Curriculum curriculum)
        {
            foreach (Course course in curriculum._curriculum)
                if (this.FindCourseIndexByNumber(course._number) == -1)
                    this._curriculum.Add(course);
        }

        //刪除課程
        public void Remove(Course course)
        {
            this._curriculum.Remove(course);
        }

        //刪除課程
        public void RemoveAt(int index)
        {
            this._curriculum.RemoveAt(index);
        }

        //回傳是否包含指定元素
        public bool Contains(Course course)
        {
            return this._curriculum.Contains(course);
        }

        //回傳Count
        public int GetCount()
        {
            return this._curriculum.Count;
        }

        //回傳指定index的元素
        public Course IndexAt(int index)
        {
            return this._curriculum[index];
        }

        //回傳指定元素的index
        public int IndexOf(Course course)
        {
            return this._curriculum.IndexOf(course);
        }

        //回傳指定課號的index
        public int IndexOf(string number)
        {
            int index = -1;
            foreach (Course course in this._curriculum)
            {
                index++;
                if (course._number == number)
                    break;
            }
            return index;
        }

        //修改課程
        public void ModifyCourse(int index, Course course)
        {
            this._curriculum[index] = course;
        }

        //回傳本課表沒有和另一個課表重複的課
        public Curriculum FindDifferentCourse(Curriculum anotherCurriculum)
        {
            Curriculum result = new Curriculum();
            for (int i = 0; i < this._curriculum.Count(); i++)
            {
                result.Add(this.IndexAt(i));
                for (int j = 0; j < anotherCurriculum.GetCount(); j++)
                {
                    if (this.IndexAt(i).Equals(anotherCurriculum.IndexAt(j)))
                        result.Remove(this.IndexAt(i));
                }
            }
            return result;
        }

        //回傳所有課程的名稱
        public List<string> GetAllCourseName()
        {
            List<string> allCourseName = new List<string>();
            foreach (Course course in _curriculum)
                allCourseName.Add(course._name);
            return allCourseName;
        }

        //清除所有課程
        public void Clear()
        {
            _curriculum.Clear();
        }

        //透過課號尋找課程index
        public int FindCourseIndexByNumber(string number)
        {
            int index = 0;
            foreach (Course course in this._curriculum)
            {
                if (course._number.Equals(number))
                    return index;
                index++;
            }
            return -1;
        }

        //是否有衝堂
        public string CourseConflict()
        {
            string result = "";
            for (int i = 0; i < this.GetCount(); i++)
            {
                for (int j = i + 1; j < this.GetCount(); j++)
                {
                    //result += CheckConflict(_addedDatasList.IndexAt(i), _addedDatasList.IndexAt(j));
                    result += this.IndexAt(i).CheckConflict(this.IndexAt(j));
                }
            }
            return result;
        }
    }
}
