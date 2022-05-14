using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class ImportingCourseForm : Form
    {
        Model _model;
        ImportCourseFormPresentationModel _presentationMode;
        const string TEXT = "Text";
        const string VALUE = "Value";
        const string PROGRESS_CHANGED = "ProgressChanged";
        const string PROGRESS_BAR_VALUE_CHANGED = "ProgressBarValueChanged";

        public ImportingCourseForm(Model model, ImportCourseFormPresentationModel presentationModel)
        {
            this._model = model;
            this._presentationMode = presentationModel;
            InitializeComponent();
            _progress.DataBindings.Add(TEXT, this._model, PROGRESS_CHANGED);
            _progressBar.DataBindings.Add(VALUE, this._model, PROGRESS_BAR_VALUE_CHANGED);
        }

        //當ImportingCourseForm顯示後
        private void ShowImportingCourseForm(object sender, EventArgs e)
        {
            _presentationMode.ImportCourse();
        }
    }
}
