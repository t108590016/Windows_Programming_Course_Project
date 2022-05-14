using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Text.RegularExpressions;

namespace homework2
{
    public partial class Model : INotifyPropertyChanged
    {
        public Model()
        {            
            for (int i = 0; i < _allClassCode.Length; i++)
            {
                Department TemporaryDepartment = new Department(_allClassName[i], _allClassCode[i]);
                if (!_allDepartments.Contains(TemporaryDepartment))
                    _allDepartments.Add(TemporaryDepartment);
            }
            CatchCourseInfo();
            this.ProgressBarValueChanged = 0;
            this.ProgressChanged = IMPORTING + ProgressBarValueChanged.ToString() + PERCENT;
        }

        //是否有通知
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //通知
        public void NotifyObserver()
        {
            if (_modelChanged != null)
                _modelChanged();
        }

        //回傳有幾行
        public int GetColumnsNumber()
        {
            return _columnsNumber;
        }

        //回傳已加選課程
        public Curriculum GetAddedCourse()
        {
            return this._addedCourse;
        }

        //回傳共幾堂課
        public int GetAddedCourseCount()
        {
            return this._addedCourse.GetCount();
        }

        //是否有已加選課程
        public void IsAddedCourse()
        {
            if (_addedCourse.GetCount() > 0)
            {
                _isCheckResultButtonEnabled = true;
                Notify(NOTIFY_CHECK_RESULT);
            }

        }

        //加選課程
        public void AddCourse(Course course)
        {
            this._addedCourse.Add(course);
            NotifyObserver();
            IsAddedCourse();        
        }

        //加選課程
        public void AddCourse(Curriculum curriculum)
        {
            foreach (Course course in curriculum._curriculum)
                AddCourse(course);
            IsAddedCourse();
        }

        //退選課程
        public void RemoveAt(int index)
        {
            this._addedCourse.RemoveAt(index);
            IsAddedCourse();
        }

        //移除課程
        public void RemoveCourseAt(Course course)
        {
            foreach (Department department in _allDepartments)
            {
                department.RemoveCourse(course);
            }
        }

        //匯入所有資工系的課程
        public async void ImportAllInformationCourse(string[] departmentName, string[] code)
        {
            const int BURDEN = 3;
            for (int i = 0; i < code.Length; i++)
            {
                if (this.FindDepartmentIndex(departmentName[i]) == -1)
                {
                    int index = _allDepartments.Count();
                    _allDepartments.Add(new Department(departmentName[i], code[i]));
                    _allDepartments[index]._curriculum = this.GetCourseInfo(LINK + _allDepartments[index]._code, BURDEN);
                }
                await Task.Delay(DELAY);
                this.ProgressBarValueChanged = ((i + 1) * (PROGRESS_MAXIMUM / code.Length));
                if (ProgressBarValueChanged == PROGRESS_MAXIMUM)
                    this.ProgressChanged = IMPORTED + ProgressBarValueChanged.ToString() + PERCENT;
                else
                    this.ProgressChanged = IMPORTING + ProgressBarValueChanged.ToString() + PERCENT;
            }
            NotifyObserver();
        }

        //設定所有Departments的課表
        public void CatchCourseInfo()
        {
            const int BURDEN = 3; //抓info時不需要的行數
            foreach (Department department in this._allDepartments)
            {
                string link = LINK + department._code;
                Curriculum datasList = this.GetCourseInfo(link, BURDEN);
                department._curriculum = datasList;
            }
        }

        //回傳所有Department
        public List<Department> GetAllDepartments()
        {
            return _allDepartments;
        }

        //利用班級名稱尋找index
        public int GetDepartmentIndex(string name)
        {
            int index = 0;
            foreach (Department department in _allDepartments)
            {
                if (department._name == name)
                    return index;
                index++;
            }
            return -1;
        }

        //根據index回傳對應的Department
        public Department GetDepartment(int index)
        {
            return _allDepartments[index];
        }

        //根據班級新增課程
        public void AddCourse(string name, Course course)
        {
            int index = this.GetDepartmentIndex(name);
            _allDepartments[index]._curriculum.Add(course);
            NotifyObserver();
        }

        //尋找department的index
        public int FindDepartmentIndex(string name)
        {
            int index = 0;
            foreach (Department department in _allDepartments)
            {
                if (name == department._name)
                    return index;
                index++;
            }
            return -1;
        }

        //修改已加選課程
        public void ModifyAddedCourse(Course originalCourse, Course newCourse)
        {
            int index = _addedCourse.IndexOf(originalCourse);
            if (index != -1)
                _addedCourse._curriculum[index] = newCourse;
        }

        //刪除已加選課程
        public void RemoveAddedCourse(Course course)
        {
            _addedCourse.Remove(course);
            NotifyObserver();
        }

        //根據班級修改課程
        public void ModifyCourse(string className, int index, Course originalCourse, Course newCourse)
        {
            Department temporaryDepartment = new Department();
            foreach (Department department in _allDepartments)
            {
                temporaryDepartment = department;
                if (!department.IsOutOfIndex(ref index))
                    break;
            }
            if (!temporaryDepartment.ModifyOrRemove(className, newCourse, index))
            {
                AddCourse(_allDepartments[FindDepartmentIndex(className)]._name, newCourse);
            }
            ModifyAddedCourse(originalCourse, newCourse);
            NotifyObserver();
        }

        //根據index回傳指定的Course
        public Course GetCourse(int index)
        {
            Department temporaryDepartment = new Department();
            foreach (Department department in _allDepartments)
            {
                temporaryDepartment = department;
                if (!department.IsOutOfIndex(ref index))
                    break;
            }
            return temporaryDepartment._curriculum.IndexAt(index);
        }

        //新增department
        public void AddDepartment(Department inputDepartment)
        {
            foreach (Department department in _allDepartments)
                if (department._name.Equals(inputDepartment._name))
                    return;
            this._allDepartments.Add(inputDepartment);
            NotifyObserver();
        }

        //回傳_allDepartments的count
        public int GetAllDepartmentCount()
        {
            return _allDepartments.Count();
        }
    }
}
