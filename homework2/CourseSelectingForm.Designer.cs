
namespace homework2
{
    partial class CourseSelectingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._checkResultButton = new System.Windows.Forms.Button();
            this._confirmButton = new System.Windows.Forms.Button();
            this._electronicThirdPage = new System.Windows.Forms.TabPage();
            this._computerScienceThirdPage = new System.Windows.Forms.TabPage();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // _checkResultButton
            // 
            this._checkResultButton.Enabled = false;
            this._checkResultButton.Location = new System.Drawing.Point(669, 412);
            this._checkResultButton.Name = "_checkResultButton";
            this._checkResultButton.Size = new System.Drawing.Size(106, 47);
            this._checkResultButton.TabIndex = 4;
            this._checkResultButton.Text = "查看選課結果";
            this._checkResultButton.UseVisualStyleBackColor = true;
            this._checkResultButton.Click += new System.EventHandler(this.ClickCheckResultButton);
            // 
            // _confirmButton
            // 
            this._confirmButton.Enabled = false;
            this._confirmButton.Location = new System.Drawing.Point(483, 412);
            this._confirmButton.Name = "_confirmButton";
            this._confirmButton.Size = new System.Drawing.Size(106, 47);
            this._confirmButton.TabIndex = 3;
            this._confirmButton.Text = "確認送出";
            this._confirmButton.UseVisualStyleBackColor = true;
            this._confirmButton.Click += new System.EventHandler(this.ClickConfirmButton);
            // 
            // _electronicThirdPage
            // 
            this._electronicThirdPage.Location = new System.Drawing.Point(4, 22);
            this._electronicThirdPage.Name = "_electronicThirdPage";
            this._electronicThirdPage.Padding = new System.Windows.Forms.Padding(3);
            this._electronicThirdPage.Size = new System.Drawing.Size(792, 356);
            this._electronicThirdPage.TabIndex = 1;
            this._electronicThirdPage.Text = "電子三甲";
            this._electronicThirdPage.UseVisualStyleBackColor = true;
            // 
            // _computerScienceThirdPage
            // 
            this._computerScienceThirdPage.Location = new System.Drawing.Point(4, 22);
            this._computerScienceThirdPage.Name = "_computerScienceThirdPage";
            this._computerScienceThirdPage.Padding = new System.Windows.Forms.Padding(3);
            this._computerScienceThirdPage.Size = new System.Drawing.Size(792, 356);
            this._computerScienceThirdPage.TabIndex = 0;
            this._computerScienceThirdPage.Text = "資工三";
            this._computerScienceThirdPage.UseVisualStyleBackColor = true;
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._computerScienceThirdPage);
            this._tabControl.Controls.Add(this._electronicThirdPage);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(800, 382);
            this._tabControl.TabIndex = 1;
            // 
            // CourseSelectingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this._checkResultButton);
            this.Controls.Add(this._confirmButton);
            this.Controls.Add(this._tabControl);
            this.Name = "CourseSelectingForm";
            this.Text = "CourseSelectingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseCourseSelectingForm);
            this.Load += new System.EventHandler(this.LoadCourseSelectingForm);
            this._tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button _checkResultButton;
        private System.Windows.Forms.Button _confirmButton;
        private System.Windows.Forms.TabPage _electronicThirdPage;
        private System.Windows.Forms.TabPage _computerScienceThirdPage;
        private System.Windows.Forms.TabControl _tabControl;
    }
}