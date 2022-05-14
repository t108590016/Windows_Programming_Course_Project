using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2
{
    public partial class StartUpForm : Form
    {
        Model _model;
        const string ENABLED = "Enabled";
        public StartUpForm(Model model)
        {
            this._model = model;
            InitializeComponent();
            _courseManagementButton.DataBindings.Add(ENABLED, this._model, "IsCourseManageButtonEnabled");
            _courseSelectingButton.DataBindings.Add(ENABLED, this._model, "IsCourseSelectButtonEnabled");
        }

        //當按下CourseSelectingButton時
        private void ClickCourseSelectingButton(object sender, EventArgs e)
        {
            _model.IsCourseSelectButtonEnabled = false;
            Form courseSelectingForm = new CourseSelectingForm(new CourseSelectingFormPresentationModel(_model), _model);
            courseSelectingForm.Show();
            /*if (courseSelectingForm.ShowDialog() == DialogResult.Cancel)
            {
                _courseManagementButton.Enabled = true;
                _courseSelectingButton.Enabled = true;
            }*/

        }

        //當按下CourseManagementButton時
        private void ClickCourseManagementButton(object sender, EventArgs e)
        {
            _model.IsCourseManageButtonEnabled = false;
            Form courseManagementForm = new CourseManagementForm(_model, new CourseManagementFormPresentationModel(_model));
            courseManagementForm.Show();
            /*if (courseManagementForm.ShowDialog() == DialogResult.Cancel)
            {
                _courseManagementButton.Enabled = true;
                _courseSelectingButton.Enabled = true;
            }*/
        }

        //當按下ExitButton時
        private void ClickExitButton(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
