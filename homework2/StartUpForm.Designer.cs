
namespace homework2
{
    partial class StartUpForm
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
            this._courseSelectingButton = new System.Windows.Forms.Button();
            this._courseManagementButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _courseSelectingButton
            // 
            this._courseSelectingButton.Location = new System.Drawing.Point(0, 1);
            this._courseSelectingButton.Name = "_courseSelectingButton";
            this._courseSelectingButton.Size = new System.Drawing.Size(484, 166);
            this._courseSelectingButton.TabIndex = 0;
            this._courseSelectingButton.Text = "Course Selecting System";
            this._courseSelectingButton.UseVisualStyleBackColor = true;
            this._courseSelectingButton.Click += new System.EventHandler(this.ClickCourseSelectingButton);
            // 
            // _courseManagementButton
            // 
            this._courseManagementButton.Location = new System.Drawing.Point(0, 163);
            this._courseManagementButton.Name = "_courseManagementButton";
            this._courseManagementButton.Size = new System.Drawing.Size(484, 166);
            this._courseManagementButton.TabIndex = 1;
            this._courseManagementButton.Text = "Course Management System";
            this._courseManagementButton.UseVisualStyleBackColor = true;
            this._courseManagementButton.Click += new System.EventHandler(this.ClickCourseManagementButton);
            // 
            // _exitButton
            // 
            this._exitButton.Location = new System.Drawing.Point(352, 399);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(131, 47);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._courseManagementButton);
            this.Controls.Add(this._courseSelectingButton);
            this.Name = "StartUpForm";
            this.Text = "StartUpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _courseSelectingButton;
        private System.Windows.Forms.Button _courseManagementButton;
        private System.Windows.Forms.Button _exitButton;
    }
}