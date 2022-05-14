
namespace homework2
{
    partial class CourseSelectionResultForm
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
            this._courseSelectionResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._courseSelectionResult)).BeginInit();
            this.SuspendLayout();
            // 
            // _courseSelectionResult
            // 
            this._courseSelectionResult.AllowUserToAddRows = false;
            this._courseSelectionResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._courseSelectionResult.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this._courseSelectionResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._courseSelectionResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseSelectionResult.GridColor = System.Drawing.Color.DarkGray;
            this._courseSelectionResult.Location = new System.Drawing.Point(0, 0);
            this._courseSelectionResult.Name = "_courseSelectionResult";
            this._courseSelectionResult.RowHeadersVisible = false;
            this._courseSelectionResult.RowTemplate.Height = 24;
            this._courseSelectionResult.Size = new System.Drawing.Size(800, 450);
            this._courseSelectionResult.TabIndex = 0;
            this._courseSelectionResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContent);
            // 
            // CourseSelectionResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._courseSelectionResult);
            this.Name = "CourseSelectionResultForm";
            this.Text = "CourseSelectionResultForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseCourseSelectionResultForm);
            this.Load += new System.EventHandler(this.LoadCourseSelectionResultForm);
            ((System.ComponentModel.ISupportInitialize)(this._courseSelectionResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _courseSelectionResult;
    }
}