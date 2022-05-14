using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class ImportCourseFormPresentationModel
    {
        Model _model;
        const string INFORMATION_FOURTH = "資工四";
        const string CODE_INFORMATION_FOURTH = "2314";
        const string INFORMATION_THIRD = "資工三";
        const string CODE_INFORMATION_THIRD = "2433";
        const string INFORMATION_SECOND = "資工二";
        const string CODE_INFORMATION_SECOND = "2550";
        const string INFORMATION_FIRST = "資工一";
        const string CODE_INFORMATION_FIRST = "2676";
        const string INFORMATION = "資工所";
        const string CODE_INFORMATION = "2701";
        string[] _departmentName = { INFORMATION_FOURTH, INFORMATION_THIRD, INFORMATION_SECOND, INFORMATION_FIRST, INFORMATION };
        string[] _code = { CODE_INFORMATION_FOURTH, CODE_INFORMATION_THIRD, CODE_INFORMATION_SECOND, CODE_INFORMATION_FIRST, CODE_INFORMATION };
        public ImportCourseFormPresentationModel(Model model)
        {
            _model = model;
        }

        //匯入指定department的所有課程
        public void ImportCourse()
        {
            _model.ImportAllInformationCourse(_departmentName, _code);
        }

    }
}
