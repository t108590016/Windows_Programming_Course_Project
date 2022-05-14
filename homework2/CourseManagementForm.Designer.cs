
namespace homework2
{
    partial class CourseManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this._modeControl = new System.Windows.Forms.TabControl();
            this._courseManagement = new System.Windows.Forms.TabPage();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._courseInfo = new System.Windows.Forms.GroupBox();
            this._classTime = new System.Windows.Forms.DataGridView();
            this._allTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanelFive = new System.Windows.Forms.TableLayoutPanel();
            this._hourLabel = new System.Windows.Forms.Label();
            this._classLabel = new System.Windows.Forms.Label();
            this._hour = new System.Windows.Forms.ComboBox();
            this._class = new System.Windows.Forms.ComboBox();
            this._tableLayoutPanelFour = new System.Windows.Forms.TableLayoutPanel();
            this._noteLabel = new System.Windows.Forms.Label();
            this._note = new System.Windows.Forms.TextBox();
            this._tableLayoutPanelThree = new System.Windows.Forms.TableLayoutPanel();
            this._languageLabel = new System.Windows.Forms.Label();
            this._assistantLabel = new System.Windows.Forms.Label();
            this._assistant = new System.Windows.Forms.TextBox();
            this._language = new System.Windows.Forms.TextBox();
            this._tableLayoutPanelTwo = new System.Windows.Forms.TableLayoutPanel();
            this._stage = new System.Windows.Forms.TextBox();
            this._creditLabel = new System.Windows.Forms.Label();
            this._credit = new System.Windows.Forms.TextBox();
            this._teacherLabel = new System.Windows.Forms.Label();
            this._required = new System.Windows.Forms.ComboBox();
            this._requiredLabel = new System.Windows.Forms.Label();
            this._teacher = new System.Windows.Forms.TextBox();
            this._stageLabel = new System.Windows.Forms.Label();
            this._tableLayoutPanelOne = new System.Windows.Forms.TableLayoutPanel();
            this._number = new System.Windows.Forms.TextBox();
            this._numberLabel = new System.Windows.Forms.Label();
            this._courseNameLabel = new System.Windows.Forms.Label();
            this._modeComboBox = new System.Windows.Forms.ComboBox();
            this._courseName = new System.Windows.Forms.TextBox();
            this._courseList = new System.Windows.Forms.ListBox();
            this._storeButton = new System.Windows.Forms.Button();
            this._buttonPanel = new System.Windows.Forms.Panel();
            this._importButton = new System.Windows.Forms.Button();
            this._addCourseButton = new System.Windows.Forms.Button();
            this._classManagement = new System.Windows.Forms.TabPage();
            this._classTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this._addClassButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this._classGroupBox = new System.Windows.Forms.GroupBox();
            this._courseListInClass = new System.Windows.Forms.ListBox();
            this._courseInClassLabel = new System.Windows.Forms.Label();
            this._classNameTextBox = new System.Windows.Forms.TextBox();
            this._classNameLabel = new System.Windows.Forms.Label();
            this._classList = new System.Windows.Forms.ListBox();
            this._modeControl.SuspendLayout();
            this._courseManagement.SuspendLayout();
            this._tableLayoutPanel.SuspendLayout();
            this._courseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._classTime)).BeginInit();
            this._allTableLayoutPanel.SuspendLayout();
            this._tableLayoutPanelFive.SuspendLayout();
            this._tableLayoutPanelFour.SuspendLayout();
            this._tableLayoutPanelThree.SuspendLayout();
            this._tableLayoutPanelTwo.SuspendLayout();
            this._tableLayoutPanelOne.SuspendLayout();
            this._buttonPanel.SuspendLayout();
            this._classManagement.SuspendLayout();
            this._classTabLayout.SuspendLayout();
            this._classGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _modeControl
            // 
            this._modeControl.Controls.Add(this._courseManagement);
            this._modeControl.Controls.Add(this._classManagement);
            this._modeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._modeControl.Location = new System.Drawing.Point(0, 0);
            this._modeControl.Name = "_modeControl";
            this._modeControl.SelectedIndex = 0;
            this._modeControl.Size = new System.Drawing.Size(897, 575);
            this._modeControl.TabIndex = 1;
            // 
            // _courseManagement
            // 
            this._courseManagement.Controls.Add(this._tableLayoutPanel);
            this._courseManagement.Location = new System.Drawing.Point(4, 22);
            this._courseManagement.Name = "_courseManagement";
            this._courseManagement.Padding = new System.Windows.Forms.Padding(3);
            this._courseManagement.Size = new System.Drawing.Size(889, 549);
            this._courseManagement.TabIndex = 0;
            this._courseManagement.Text = "課程管理";
            this._courseManagement.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.68958F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.31042F));
            this._tableLayoutPanel.Controls.Add(this._courseInfo, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._courseList, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._storeButton, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._buttonPanel, 0, 1);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 2;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.33334F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.66667F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(883, 543);
            this._tableLayoutPanel.TabIndex = 6;
            // 
            // _courseInfo
            // 
            this._courseInfo.AutoSize = true;
            this._courseInfo.Controls.Add(this._classTime);
            this._courseInfo.Controls.Add(this._allTableLayoutPanel);
            this._courseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseInfo.Location = new System.Drawing.Point(238, 3);
            this._courseInfo.Name = "_courseInfo";
            this._courseInfo.Size = new System.Drawing.Size(642, 468);
            this._courseInfo.TabIndex = 2;
            this._courseInfo.TabStop = false;
            this._courseInfo.Text = "編輯課程";
            // 
            // _classTime
            // 
            this._classTime.AllowUserToAddRows = false;
            this._classTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._classTime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._classTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._classTime.DefaultCellStyle = dataGridViewCellStyle2;
            this._classTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this._classTime.Location = new System.Drawing.Point(3, 199);
            this._classTime.Name = "_classTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._classTime.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._classTime.RowHeadersVisible = false;
            this._classTime.RowTemplate.Height = 24;
            this._classTime.Size = new System.Drawing.Size(636, 266);
            this._classTime.TabIndex = 5;
            this._classTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellContent);
            this._classTime.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeCellValue);
            // 
            // _allTableLayoutPanel
            // 
            this._allTableLayoutPanel.ColumnCount = 1;
            this._allTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._allTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._allTableLayoutPanel.Controls.Add(this._tableLayoutPanelFive, 0, 4);
            this._allTableLayoutPanel.Controls.Add(this._tableLayoutPanelFour, 0, 3);
            this._allTableLayoutPanel.Controls.Add(this._tableLayoutPanelThree, 0, 2);
            this._allTableLayoutPanel.Controls.Add(this._tableLayoutPanelTwo, 0, 1);
            this._allTableLayoutPanel.Controls.Add(this._tableLayoutPanelOne, 0, 0);
            this._allTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._allTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this._allTableLayoutPanel.Name = "_allTableLayoutPanel";
            this._allTableLayoutPanel.RowCount = 5;
            this._allTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.83333F));
            this._allTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._allTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this._allTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._allTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this._allTableLayoutPanel.Size = new System.Drawing.Size(636, 181);
            this._allTableLayoutPanel.TabIndex = 6;
            // 
            // _tableLayoutPanelFive
            // 
            this._tableLayoutPanelFive.ColumnCount = 4;
            this._tableLayoutPanelFive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.125F));
            this._tableLayoutPanelFive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.875F));
            this._tableLayoutPanelFive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._tableLayoutPanelFive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this._tableLayoutPanelFive.Controls.Add(this._hourLabel, 0, 0);
            this._tableLayoutPanelFive.Controls.Add(this._classLabel, 2, 0);
            this._tableLayoutPanelFive.Controls.Add(this._hour, 1, 0);
            this._tableLayoutPanelFive.Controls.Add(this._class, 3, 0);
            this._tableLayoutPanelFive.Dock = System.Windows.Forms.DockStyle.Top;
            this._tableLayoutPanelFive.Location = new System.Drawing.Point(3, 143);
            this._tableLayoutPanelFive.Name = "_tableLayoutPanelFive";
            this._tableLayoutPanelFive.RowCount = 1;
            this._tableLayoutPanelFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelFive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelFive.Size = new System.Drawing.Size(632, 30);
            this._tableLayoutPanelFive.TabIndex = 5;
            // 
            // _hourLabel
            // 
            this._hourLabel.AutoSize = true;
            this._hourLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._hourLabel.Location = new System.Drawing.Point(3, 0);
            this._hourLabel.Name = "_hourLabel";
            this._hourLabel.Size = new System.Drawing.Size(100, 30);
            this._hourLabel.TabIndex = 0;
            this._hourLabel.Text = "時數(*)";
            this._hourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _classLabel
            // 
            this._classLabel.AutoSize = true;
            this._classLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._classLabel.Location = new System.Drawing.Point(323, 0);
            this._classLabel.Name = "_classLabel";
            this._classLabel.Size = new System.Drawing.Size(94, 30);
            this._classLabel.TabIndex = 1;
            this._classLabel.Text = "班級(*)";
            this._classLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _hour
            // 
            this._hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._hour.FormattingEnabled = true;
            this._hour.Location = new System.Drawing.Point(109, 3);
            this._hour.Name = "_hour";
            this._hour.Size = new System.Drawing.Size(121, 20);
            this._hour.TabIndex = 2;
            this._hour.SelectedValueChanged += new System.EventHandler(this.ChangeHourSelectedValue);
            // 
            // _class
            // 
            this._class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._class.FormattingEnabled = true;
            this._class.Location = new System.Drawing.Point(423, 3);
            this._class.Name = "_class";
            this._class.Size = new System.Drawing.Size(121, 20);
            this._class.TabIndex = 3;
            this._class.SelectedValueChanged += new System.EventHandler(this.ChangeClassSelectedValue);
            // 
            // _tableLayoutPanelFour
            // 
            this._tableLayoutPanelFour.ColumnCount = 2;
            this._tableLayoutPanelFour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.168459F));
            this._tableLayoutPanelFour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.83154F));
            this._tableLayoutPanelFour.Controls.Add(this._noteLabel, 0, 0);
            this._tableLayoutPanelFour.Controls.Add(this._note, 1, 0);
            this._tableLayoutPanelFour.Dock = System.Windows.Forms.DockStyle.Top;
            this._tableLayoutPanelFour.Location = new System.Drawing.Point(3, 108);
            this._tableLayoutPanelFour.Name = "_tableLayoutPanelFour";
            this._tableLayoutPanelFour.RowCount = 1;
            this._tableLayoutPanelFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelFour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelFour.Size = new System.Drawing.Size(632, 29);
            this._tableLayoutPanelFour.TabIndex = 4;
            // 
            // _noteLabel
            // 
            this._noteLabel.AutoSize = true;
            this._noteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._noteLabel.Location = new System.Drawing.Point(3, 0);
            this._noteLabel.Name = "_noteLabel";
            this._noteLabel.Size = new System.Drawing.Size(39, 29);
            this._noteLabel.TabIndex = 0;
            this._noteLabel.Text = "備註";
            this._noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _note
            // 
            this._note.Location = new System.Drawing.Point(48, 3);
            this._note.Name = "_note";
            this._note.Size = new System.Drawing.Size(457, 22);
            this._note.TabIndex = 1;
            // 
            // _tableLayoutPanelThree
            // 
            this._tableLayoutPanelThree.ColumnCount = 4;
            this._tableLayoutPanelThree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.87013F));
            this._tableLayoutPanelThree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.12987F));
            this._tableLayoutPanelThree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this._tableLayoutPanelThree.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this._tableLayoutPanelThree.Controls.Add(this._languageLabel, 2, 0);
            this._tableLayoutPanelThree.Controls.Add(this._assistantLabel, 0, 0);
            this._tableLayoutPanelThree.Controls.Add(this._assistant, 1, 0);
            this._tableLayoutPanelThree.Controls.Add(this._language, 3, 0);
            this._tableLayoutPanelThree.Dock = System.Windows.Forms.DockStyle.Top;
            this._tableLayoutPanelThree.Location = new System.Drawing.Point(3, 75);
            this._tableLayoutPanelThree.Name = "_tableLayoutPanelThree";
            this._tableLayoutPanelThree.RowCount = 1;
            this._tableLayoutPanelThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelThree.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelThree.Size = new System.Drawing.Size(632, 27);
            this._tableLayoutPanelThree.TabIndex = 3;
            // 
            // _languageLabel
            // 
            this._languageLabel.AutoSize = true;
            this._languageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._languageLabel.Location = new System.Drawing.Point(316, 0);
            this._languageLabel.Name = "_languageLabel";
            this._languageLabel.Size = new System.Drawing.Size(91, 27);
            this._languageLabel.TabIndex = 20;
            this._languageLabel.Text = "授課語言";
            this._languageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _assistantLabel
            // 
            this._assistantLabel.AutoSize = true;
            this._assistantLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._assistantLabel.Location = new System.Drawing.Point(3, 0);
            this._assistantLabel.Name = "_assistantLabel";
            this._assistantLabel.Size = new System.Drawing.Size(87, 27);
            this._assistantLabel.TabIndex = 19;
            this._assistantLabel.Text = "教學助理";
            this._assistantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _assistant
            // 
            this._assistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this._assistant.Location = new System.Drawing.Point(96, 3);
            this._assistant.Name = "_assistant";
            this._assistant.Size = new System.Drawing.Size(214, 22);
            this._assistant.TabIndex = 20;
            // 
            // _language
            // 
            this._language.Dock = System.Windows.Forms.DockStyle.Fill;
            this._language.Location = new System.Drawing.Point(413, 3);
            this._language.Name = "_language";
            this._language.Size = new System.Drawing.Size(216, 22);
            this._language.TabIndex = 21;
            // 
            // _tableLayoutPanelTwo
            // 
            this._tableLayoutPanelTwo.ColumnCount = 8;
            this._tableLayoutPanelTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanelTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.68421F));
            this._tableLayoutPanelTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this._tableLayoutPanelTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this._tableLayoutPanelTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this._tableLayoutPanelTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this._tableLayoutPanelTwo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this._tableLayoutPanelTwo.Controls.Add(this._stage, 1, 0);
            this._tableLayoutPanelTwo.Controls.Add(this._creditLabel, 2, 0);
            this._tableLayoutPanelTwo.Controls.Add(this._credit, 3, 0);
            this._tableLayoutPanelTwo.Controls.Add(this._teacherLabel, 4, 0);
            this._tableLayoutPanelTwo.Controls.Add(this._required, 7, 0);
            this._tableLayoutPanelTwo.Controls.Add(this._requiredLabel, 6, 0);
            this._tableLayoutPanelTwo.Controls.Add(this._teacher, 5, 0);
            this._tableLayoutPanelTwo.Controls.Add(this._stageLabel, 0, 0);
            this._tableLayoutPanelTwo.Dock = System.Windows.Forms.DockStyle.Top;
            this._tableLayoutPanelTwo.Location = new System.Drawing.Point(3, 39);
            this._tableLayoutPanelTwo.Name = "_tableLayoutPanelTwo";
            this._tableLayoutPanelTwo.RowCount = 1;
            this._tableLayoutPanelTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this._tableLayoutPanelTwo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelTwo.Size = new System.Drawing.Size(632, 30);
            this._tableLayoutPanelTwo.TabIndex = 2;
            // 
            // _stage
            // 
            this._stage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stage.Location = new System.Drawing.Point(52, 3);
            this._stage.Name = "_stage";
            this._stage.Size = new System.Drawing.Size(100, 22);
            this._stage.TabIndex = 6;
            this._stage.TextChanged += new System.EventHandler(this.ChangeStageText);
            this._stage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressStageKey);
            // 
            // _creditLabel
            // 
            this._creditLabel.AutoSize = true;
            this._creditLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._creditLabel.Location = new System.Drawing.Point(158, 0);
            this._creditLabel.Name = "_creditLabel";
            this._creditLabel.Size = new System.Drawing.Size(51, 12);
            this._creditLabel.TabIndex = 7;
            this._creditLabel.Text = "學分(*)";
            this._creditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _credit
            // 
            this._credit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._credit.Location = new System.Drawing.Point(215, 3);
            this._credit.Name = "_credit";
            this._credit.Size = new System.Drawing.Size(94, 22);
            this._credit.TabIndex = 8;
            this._credit.TextChanged += new System.EventHandler(this.ChangeCreditText);
            this._credit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressCreditKey);
            // 
            // _teacherLabel
            // 
            this._teacherLabel.AutoSize = true;
            this._teacherLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._teacherLabel.Location = new System.Drawing.Point(315, 0);
            this._teacherLabel.Name = "_teacherLabel";
            this._teacherLabel.Size = new System.Drawing.Size(66, 12);
            this._teacherLabel.TabIndex = 9;
            this._teacherLabel.Text = "教師(*)";
            this._teacherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _required
            // 
            this._required.Dock = System.Windows.Forms.DockStyle.Fill;
            this._required.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._required.FormattingEnabled = true;
            this._required.Location = new System.Drawing.Point(517, 3);
            this._required.Name = "_required";
            this._required.Size = new System.Drawing.Size(112, 20);
            this._required.TabIndex = 13;
            this._required.SelectedIndexChanged += new System.EventHandler(this.ChangeRequiredSelectedIndex);
            // 
            // _requiredLabel
            // 
            this._requiredLabel.AutoSize = true;
            this._requiredLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._requiredLabel.Location = new System.Drawing.Point(478, 0);
            this._requiredLabel.Name = "_requiredLabel";
            this._requiredLabel.Size = new System.Drawing.Size(33, 12);
            this._requiredLabel.TabIndex = 12;
            this._requiredLabel.Text = "修(*)";
            this._requiredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _teacher
            // 
            this._teacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this._teacher.Location = new System.Drawing.Point(387, 3);
            this._teacher.Name = "_teacher";
            this._teacher.Size = new System.Drawing.Size(85, 22);
            this._teacher.TabIndex = 11;
            this._teacher.TextChanged += new System.EventHandler(this.ChangeTeacherText);
            // 
            // _stageLabel
            // 
            this._stageLabel.AutoSize = true;
            this._stageLabel.Location = new System.Drawing.Point(3, 0);
            this._stageLabel.Name = "_stageLabel";
            this._stageLabel.Size = new System.Drawing.Size(43, 12);
            this._stageLabel.TabIndex = 5;
            this._stageLabel.Text = "階段(*)";
            this._stageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _tableLayoutPanelOne
            // 
            this._tableLayoutPanelOne.ColumnCount = 5;
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.71428F));
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.88811F));
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.47086F));
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this._tableLayoutPanelOne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanelOne.Controls.Add(this._number, 2, 0);
            this._tableLayoutPanelOne.Controls.Add(this._numberLabel, 1, 0);
            this._tableLayoutPanelOne.Controls.Add(this._courseNameLabel, 3, 0);
            this._tableLayoutPanelOne.Controls.Add(this._modeComboBox, 0, 0);
            this._tableLayoutPanelOne.Controls.Add(this._courseName, 4, 0);
            this._tableLayoutPanelOne.Dock = System.Windows.Forms.DockStyle.Top;
            this._tableLayoutPanelOne.Location = new System.Drawing.Point(3, 3);
            this._tableLayoutPanelOne.Name = "_tableLayoutPanelOne";
            this._tableLayoutPanelOne.RowCount = 1;
            this._tableLayoutPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this._tableLayoutPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tableLayoutPanelOne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanelOne.Size = new System.Drawing.Size(632, 27);
            this._tableLayoutPanelOne.TabIndex = 1;
            // 
            // _number
            // 
            this._number.Location = new System.Drawing.Point(164, 3);
            this._number.Name = "_number";
            this._number.Size = new System.Drawing.Size(123, 22);
            this._number.TabIndex = 10;
            this._number.TextChanged += new System.EventHandler(this.ChangeNumberText);
            this._number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressNumberKey);
            // 
            // _numberLabel
            // 
            this._numberLabel.AutoSize = true;
            this._numberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._numberLabel.Location = new System.Drawing.Point(113, 0);
            this._numberLabel.Name = "_numberLabel";
            this._numberLabel.Size = new System.Drawing.Size(45, 28);
            this._numberLabel.TabIndex = 0;
            this._numberLabel.Text = "課號(*)";
            this._numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _courseNameLabel
            // 
            this._courseNameLabel.AutoSize = true;
            this._courseNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseNameLabel.Location = new System.Drawing.Point(293, 0);
            this._courseNameLabel.Name = "_courseNameLabel";
            this._courseNameLabel.Size = new System.Drawing.Size(67, 28);
            this._courseNameLabel.TabIndex = 3;
            this._courseNameLabel.Text = "課程名稱(*)";
            this._courseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _modeComboBox
            // 
            this._modeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._modeComboBox.FormattingEnabled = true;
            this._modeComboBox.Location = new System.Drawing.Point(3, 3);
            this._modeComboBox.Name = "_modeComboBox";
            this._modeComboBox.Size = new System.Drawing.Size(104, 20);
            this._modeComboBox.TabIndex = 14;
            this._modeComboBox.SelectedValueChanged += new System.EventHandler(this.ChangeModeComboBoxSelectedValue);
            // 
            // _courseName
            // 
            this._courseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseName.Location = new System.Drawing.Point(366, 3);
            this._courseName.Name = "_courseName";
            this._courseName.Size = new System.Drawing.Size(263, 22);
            this._courseName.TabIndex = 15;
            this._courseName.TextChanged += new System.EventHandler(this.ChangeCourseNameText);
            // 
            // _courseList
            // 
            this._courseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._courseList.FormattingEnabled = true;
            this._courseList.ItemHeight = 12;
            this._courseList.Location = new System.Drawing.Point(3, 3);
            this._courseList.Name = "_courseList";
            this._courseList.Size = new System.Drawing.Size(229, 468);
            this._courseList.TabIndex = 0;
            this._courseList.SelectedIndexChanged += new System.EventHandler(this.ChangeCourseListSelectedIndex);
            // 
            // _storeButton
            // 
            this._storeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._storeButton.Location = new System.Drawing.Point(755, 477);
            this._storeButton.Name = "_storeButton";
            this._storeButton.Size = new System.Drawing.Size(125, 63);
            this._storeButton.TabIndex = 3;
            this._storeButton.Text = "儲存";
            this._storeButton.UseVisualStyleBackColor = true;
            this._storeButton.Click += new System.EventHandler(this.ClickStoreButton);
            // 
            // _buttonPanel
            // 
            this._buttonPanel.Controls.Add(this._importButton);
            this._buttonPanel.Controls.Add(this._addCourseButton);
            this._buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buttonPanel.Location = new System.Drawing.Point(3, 477);
            this._buttonPanel.Name = "_buttonPanel";
            this._buttonPanel.Size = new System.Drawing.Size(229, 63);
            this._buttonPanel.TabIndex = 4;
            // 
            // _importButton
            // 
            this._importButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._importButton.Location = new System.Drawing.Point(106, 0);
            this._importButton.Name = "_importButton";
            this._importButton.Size = new System.Drawing.Size(123, 63);
            this._importButton.TabIndex = 4;
            this._importButton.Text = "匯入資工系所有課程";
            this._importButton.UseVisualStyleBackColor = true;
            this._importButton.Click += new System.EventHandler(this.ClickImportButton);
            // 
            // _addCourseButton
            // 
            this._addCourseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._addCourseButton.Location = new System.Drawing.Point(0, 0);
            this._addCourseButton.Name = "_addCourseButton";
            this._addCourseButton.Size = new System.Drawing.Size(89, 63);
            this._addCourseButton.TabIndex = 3;
            this._addCourseButton.Text = "新增課程";
            this._addCourseButton.UseVisualStyleBackColor = true;
            this._addCourseButton.Click += new System.EventHandler(this.ClickAddCourseButton);
            // 
            // _classManagement
            // 
            this._classManagement.Controls.Add(this._classTabLayout);
            this._classManagement.Location = new System.Drawing.Point(4, 22);
            this._classManagement.Name = "_classManagement";
            this._classManagement.Padding = new System.Windows.Forms.Padding(3);
            this._classManagement.Size = new System.Drawing.Size(889, 549);
            this._classManagement.TabIndex = 1;
            this._classManagement.Text = "班級管理";
            this._classManagement.UseVisualStyleBackColor = true;
            // 
            // _classTabLayout
            // 
            this._classTabLayout.ColumnCount = 2;
            this._classTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25708F));
            this._classTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.74292F));
            this._classTabLayout.Controls.Add(this._addClassButton, 0, 1);
            this._classTabLayout.Controls.Add(this._addButton, 1, 1);
            this._classTabLayout.Controls.Add(this._classGroupBox, 1, 0);
            this._classTabLayout.Controls.Add(this._classList, 0, 0);
            this._classTabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._classTabLayout.Location = new System.Drawing.Point(3, 3);
            this._classTabLayout.Name = "_classTabLayout";
            this._classTabLayout.RowCount = 2;
            this._classTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.92449F));
            this._classTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.07551F));
            this._classTabLayout.Size = new System.Drawing.Size(883, 543);
            this._classTabLayout.TabIndex = 0;
            // 
            // _addClassButton
            // 
            this._addClassButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addClassButton.Location = new System.Drawing.Point(3, 474);
            this._addClassButton.Name = "_addClassButton";
            this._addClassButton.Size = new System.Drawing.Size(270, 66);
            this._addClassButton.TabIndex = 0;
            this._addClassButton.Text = "新增班級";
            this._addClassButton.UseVisualStyleBackColor = true;
            this._addClassButton.Click += new System.EventHandler(this.ClickAddClassButton);
            // 
            // _addButton
            // 
            this._addButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._addButton.Enabled = false;
            this._addButton.Location = new System.Drawing.Point(730, 474);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(150, 66);
            this._addButton.TabIndex = 1;
            this._addButton.Text = "新增";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.ClickAddButton);
            // 
            // _classGroupBox
            // 
            this._classGroupBox.Controls.Add(this._courseListInClass);
            this._classGroupBox.Controls.Add(this._courseInClassLabel);
            this._classGroupBox.Controls.Add(this._classNameTextBox);
            this._classGroupBox.Controls.Add(this._classNameLabel);
            this._classGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._classGroupBox.Location = new System.Drawing.Point(279, 3);
            this._classGroupBox.Name = "_classGroupBox";
            this._classGroupBox.Size = new System.Drawing.Size(601, 465);
            this._classGroupBox.TabIndex = 2;
            this._classGroupBox.TabStop = false;
            this._classGroupBox.Text = "班級";
            // 
            // _courseListInClass
            // 
            this._courseListInClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._courseListInClass.FormattingEnabled = true;
            this._courseListInClass.ItemHeight = 12;
            this._courseListInClass.Location = new System.Drawing.Point(3, 194);
            this._courseListInClass.Name = "_courseListInClass";
            this._courseListInClass.Size = new System.Drawing.Size(595, 268);
            this._courseListInClass.TabIndex = 4;
            // 
            // _courseInClassLabel
            // 
            this._courseInClassLabel.AutoSize = true;
            this._courseInClassLabel.Location = new System.Drawing.Point(19, 170);
            this._courseInClassLabel.Name = "_courseInClassLabel";
            this._courseInClassLabel.Size = new System.Drawing.Size(65, 12);
            this._courseInClassLabel.TabIndex = 2;
            this._courseInClassLabel.Text = "班級內課程";
            // 
            // _classNameTextBox
            // 
            this._classNameTextBox.Location = new System.Drawing.Point(79, 91);
            this._classNameTextBox.Name = "_classNameTextBox";
            this._classNameTextBox.Size = new System.Drawing.Size(520, 22);
            this._classNameTextBox.TabIndex = 1;
            this._classNameTextBox.TextChanged += new System.EventHandler(this.ChangeClassNameTextBox);
            // 
            // _classNameLabel
            // 
            this._classNameLabel.AutoSize = true;
            this._classNameLabel.Location = new System.Drawing.Point(19, 94);
            this._classNameLabel.Name = "_classNameLabel";
            this._classNameLabel.Size = new System.Drawing.Size(53, 12);
            this._classNameLabel.TabIndex = 0;
            this._classNameLabel.Text = "班級名稱";
            // 
            // _classList
            // 
            this._classList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._classList.FormattingEnabled = true;
            this._classList.ItemHeight = 12;
            this._classList.Location = new System.Drawing.Point(3, 3);
            this._classList.Name = "_classList";
            this._classList.Size = new System.Drawing.Size(270, 465);
            this._classList.TabIndex = 3;
            this._classList.SelectedIndexChanged += new System.EventHandler(this.ChangeClassListIndex);
            // 
            // CourseManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 575);
            this.Controls.Add(this._modeControl);
            this.Name = "CourseManagementForm";
            this.Text = "CourseManagementForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseCourseManagementForm);
            this.Load += new System.EventHandler(this.LoadCourseManagementForm);
            this._modeControl.ResumeLayout(false);
            this._courseManagement.ResumeLayout(false);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this._courseInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._classTime)).EndInit();
            this._allTableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanelFive.ResumeLayout(false);
            this._tableLayoutPanelFive.PerformLayout();
            this._tableLayoutPanelFour.ResumeLayout(false);
            this._tableLayoutPanelFour.PerformLayout();
            this._tableLayoutPanelThree.ResumeLayout(false);
            this._tableLayoutPanelThree.PerformLayout();
            this._tableLayoutPanelTwo.ResumeLayout(false);
            this._tableLayoutPanelTwo.PerformLayout();
            this._tableLayoutPanelOne.ResumeLayout(false);
            this._tableLayoutPanelOne.PerformLayout();
            this._buttonPanel.ResumeLayout(false);
            this._classManagement.ResumeLayout(false);
            this._classTabLayout.ResumeLayout(false);
            this._classGroupBox.ResumeLayout(false);
            this._classGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _modeControl;
        private System.Windows.Forms.TabPage _courseManagement;
        private System.Windows.Forms.TabPage _classManagement;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.GroupBox _courseInfo;
        private System.Windows.Forms.DataGridView _classTime;
        private System.Windows.Forms.TableLayoutPanel _allTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelFive;
        private System.Windows.Forms.Label _hourLabel;
        private System.Windows.Forms.Label _classLabel;
        private System.Windows.Forms.ComboBox _hour;
        private System.Windows.Forms.ComboBox _class;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelFour;
        private System.Windows.Forms.Label _noteLabel;
        private System.Windows.Forms.TextBox _note;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelThree;
        private System.Windows.Forms.Label _languageLabel;
        private System.Windows.Forms.Label _assistantLabel;
        private System.Windows.Forms.TextBox _assistant;
        private System.Windows.Forms.TextBox _language;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelTwo;
        private System.Windows.Forms.TextBox _stage;
        private System.Windows.Forms.Label _creditLabel;
        private System.Windows.Forms.TextBox _credit;
        private System.Windows.Forms.Label _teacherLabel;
        private System.Windows.Forms.ComboBox _required;
        private System.Windows.Forms.Label _requiredLabel;
        private System.Windows.Forms.TextBox _teacher;
        private System.Windows.Forms.Label _stageLabel;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelOne;
        private System.Windows.Forms.TextBox _number;
        private System.Windows.Forms.Label _numberLabel;
        private System.Windows.Forms.Label _courseNameLabel;
        private System.Windows.Forms.ComboBox _modeComboBox;
        private System.Windows.Forms.TextBox _courseName;
        private System.Windows.Forms.ListBox _courseList;
        private System.Windows.Forms.Button _storeButton;
        private System.Windows.Forms.Panel _buttonPanel;
        private System.Windows.Forms.Button _importButton;
        private System.Windows.Forms.Button _addCourseButton;
        private System.Windows.Forms.TableLayoutPanel _classTabLayout;
        private System.Windows.Forms.Button _addClassButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.GroupBox _classGroupBox;
        private System.Windows.Forms.ListBox _courseListInClass;
        private System.Windows.Forms.Label _courseInClassLabel;
        private System.Windows.Forms.TextBox _classNameTextBox;
        private System.Windows.Forms.Label _classNameLabel;
        private System.Windows.Forms.ListBox _classList;
    }
}