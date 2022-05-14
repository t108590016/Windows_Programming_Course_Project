
namespace homework2
{
    partial class ImportingCourseForm
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
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this._label = new System.Windows.Forms.Label();
            this._progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(2, 56);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(205, 23);
            this._progressBar.TabIndex = 0;
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(0, 30);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(0, 12);
            this._label.TabIndex = 1;
            // 
            // _progress
            // 
            this._progress.AutoSize = true;
            this._progress.Location = new System.Drawing.Point(12, 31);
            this._progress.Name = "_progress";
            this._progress.Size = new System.Drawing.Size(86, 12);
            this._progress.TabIndex = 2;
            this._progress.Text = "正在匯入......0%";
            // 
            // ImportingCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 149);
            this.Controls.Add(this._progress);
            this.Controls.Add(this._label);
            this.Controls.Add(this._progressBar);
            this.Name = "ImportingCourseForm";
            this.Text = "ImportingCourseForm";
            this.Shown += new System.EventHandler(this.ShowImportingCourseForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.Label _label;
        private System.Windows.Forms.Label _progress;
    }
}