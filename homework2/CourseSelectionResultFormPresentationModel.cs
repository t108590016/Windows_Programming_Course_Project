using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class CourseSelectionResultFormPresentationModel
    {
        Model _model;
        Curriculum _allCourseList = new Curriculum();
        public CourseSelectionResultFormPresentationModel(Model model)
        {
            this._model = model;
        }

        //設定allCourseList
        public void SetAllCourseList(Curriculum allCourseList)
        {
            this._allCourseList = allCourseList;
        }

        //刪除row
        public void RemoveRow(int index)
        {
            _model.RemoveAt(index);
            //_allCourseList.RemoveAt(index);
        }
    }
}
