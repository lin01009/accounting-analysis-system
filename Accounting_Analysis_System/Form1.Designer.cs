namespace Accounting_Analysis_System
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsage = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.btnGenerateChart = new System.Windows.Forms.Button();
            this.lblChartType = new System.Windows.Forms.Label();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.tabBudget = new System.Windows.Forms.TabPage();
            this.btnSaveBudget = new System.Windows.Forms.Button();
            this.dgvBudgets = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.tabChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.tabBudget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1208, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟ToolStripMenuItem,
            this.mnuSave,
            this.mnuExit});
            this.mnuFile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mnuFile.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(77, 34);
            this.mnuFile.Text = "檔案";
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(164, 38);
            this.開啟ToolStripMenuItem.Text = "開啟";
            this.開啟ToolStripMenuItem.Click += new System.EventHandler(this.開啟ToolStripMenuItem_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(164, 38);
            this.mnuSave.Text = "儲存";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(164, 38);
            this.mnuExit.Text = "離開";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsage});
            this.mnuHelp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(77, 34);
            this.mnuHelp.Text = "說明";
            this.mnuHelp.Click += new System.EventHandler(this.說明ToolStripMenuItem_Click);
            // 
            // mnuUsage
            // 
            this.mnuUsage.Name = "mnuUsage";
            this.mnuUsage.Size = new System.Drawing.Size(212, 38);
            this.mnuUsage.Text = "操作說明";
            this.mnuUsage.Click += new System.EventHandler(this.mnuUsage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInput);
            this.tabControl1.Controls.Add(this.tabHistory);
            this.tabControl1.Controls.Add(this.tabChart);
            this.tabControl1.Controls.Add(this.tabBudget);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1208, 646);
            this.tabControl1.TabIndex = 1;
            // 
            // tabInput
            // 
            this.tabInput.BackColor = System.Drawing.Color.Black;
            this.tabInput.Controls.Add(this.label1);
            this.tabInput.Controls.Add(this.btnAdd);
            this.tabInput.Controls.Add(this.txtNote);
            this.tabInput.Controls.Add(this.txtAmount);
            this.tabInput.Controls.Add(this.cmbCategory);
            this.tabInput.Controls.Add(this.dtpDate);
            this.tabInput.Controls.Add(this.lblNote);
            this.tabInput.Controls.Add(this.lblAmount);
            this.tabInput.Controls.Add(this.lblCategory);
            this.tabInput.Controls.Add(this.lblDate);
            this.tabInput.Location = new System.Drawing.Point(4, 39);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(1200, 603);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "記帳輸入";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(623, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "元";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(701, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "新增記帳";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNote.Location = new System.Drawing.Point(506, 337);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(100, 39);
            this.txtNote.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(506, 275);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 39);
            this.txtAmount.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(506, 213);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 38);
            this.cmbCategory.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpDate.Location = new System.Drawing.Point(506, 157);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(252, 39);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNote.Location = new System.Drawing.Point(384, 346);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(85, 30);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "備註：";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmount.Location = new System.Drawing.Point(384, 280);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 30);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "金額：";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategory.Location = new System.Drawing.Point(384, 219);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 30);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "類別：";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(384, 163);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "日期：";
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.Black;
            this.tabHistory.Controls.Add(this.label4);
            this.tabHistory.Controls.Add(this.label3);
            this.tabHistory.Controls.Add(this.label2);
            this.tabHistory.Controls.Add(this.dgvRecords);
            this.tabHistory.Controls.Add(this.btnSearch);
            this.tabHistory.Controls.Add(this.dtpEnd);
            this.tabHistory.Controls.Add(this.dtpStart);
            this.tabHistory.Controls.Add(this.cmbFilterCategory);
            this.tabHistory.Location = new System.Drawing.Point(4, 39);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(1200, 603);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "支出紀錄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(271, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "類別：";
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRecords.Location = new System.Drawing.Point(3, 80);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersWidth = 62;
            this.dgvRecords.RowTemplate.Height = 31;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(1194, 520);
            this.dgvRecords.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1019, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查詢紀錄";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Location = new System.Drawing.Point(653, 19);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(248, 39);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Location = new System.Drawing.Point(362, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(248, 39);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Location = new System.Drawing.Point(97, 19);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(121, 38);
            this.cmbFilterCategory.TabIndex = 0;
            // 
            // tabChart
            // 
            this.tabChart.BackColor = System.Drawing.Color.Gray;
            this.tabChart.Controls.Add(this.btnGenerateChart);
            this.tabChart.Controls.Add(this.lblChartType);
            this.tabChart.Controls.Add(this.chartExpenses);
            this.tabChart.Controls.Add(this.cmbChartType);
            this.tabChart.Location = new System.Drawing.Point(4, 39);
            this.tabChart.Name = "tabChart";
            this.tabChart.Size = new System.Drawing.Size(1200, 603);
            this.tabChart.TabIndex = 2;
            this.tabChart.Text = "圖表分析";
            // 
            // btnGenerateChart
            // 
            this.btnGenerateChart.BackColor = System.Drawing.Color.DimGray;
            this.btnGenerateChart.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenerateChart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerateChart.Location = new System.Drawing.Point(712, 19);
            this.btnGenerateChart.Name = "btnGenerateChart";
            this.btnGenerateChart.Size = new System.Drawing.Size(85, 35);
            this.btnGenerateChart.TabIndex = 3;
            this.btnGenerateChart.Text = "確定";
            this.btnGenerateChart.UseVisualStyleBackColor = false;
            this.btnGenerateChart.Click += new System.EventHandler(this.btnGenerateChart_Click);
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChartType.Location = new System.Drawing.Point(243, 22);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(133, 30);
            this.lblChartType.TabIndex = 2;
            this.lblChartType.Text = "圖表類型：";
            // 
            // chartExpenses
            // 
            this.chartExpenses.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea1);
            this.chartExpenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend1);
            this.chartExpenses.Location = new System.Drawing.Point(0, 74);
            this.chartExpenses.Name = "chartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartExpenses.Series.Add(series1);
            this.chartExpenses.Size = new System.Drawing.Size(1200, 529);
            this.chartExpenses.TabIndex = 1;
            this.chartExpenses.Text = "chart1";
            this.chartExpenses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartExpenses_MouseClick);
            // 
            // cmbChartType
            // 
            this.cmbChartType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmbChartType.FormattingEnabled = true;
            this.cmbChartType.Location = new System.Drawing.Point(382, 19);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(154, 31);
            this.cmbChartType.TabIndex = 0;
            // 
            // tabBudget
            // 
            this.tabBudget.BackColor = System.Drawing.Color.Black;
            this.tabBudget.Controls.Add(this.btnSaveBudget);
            this.tabBudget.Controls.Add(this.dgvBudgets);
            this.tabBudget.Location = new System.Drawing.Point(4, 39);
            this.tabBudget.Name = "tabBudget";
            this.tabBudget.Size = new System.Drawing.Size(1200, 603);
            this.tabBudget.TabIndex = 3;
            this.tabBudget.Text = "預算設定";
            // 
            // btnSaveBudget
            // 
            this.btnSaveBudget.BackColor = System.Drawing.Color.DimGray;
            this.btnSaveBudget.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveBudget.Location = new System.Drawing.Point(538, 549);
            this.btnSaveBudget.Name = "btnSaveBudget";
            this.btnSaveBudget.Size = new System.Drawing.Size(127, 46);
            this.btnSaveBudget.TabIndex = 1;
            this.btnSaveBudget.Text = "儲存預算";
            this.btnSaveBudget.UseVisualStyleBackColor = false;
            this.btnSaveBudget.Click += new System.EventHandler(this.btnSaveBudget_Click);
            // 
            // dgvBudgets
            // 
            this.dgvBudgets.AllowUserToAddRows = false;
            this.dgvBudgets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudgets.Location = new System.Drawing.Point(3, 3);
            this.dgvBudgets.Name = "dgvBudgets";
            this.dgvBudgets.RowHeadersVisible = false;
            this.dgvBudgets.RowHeadersWidth = 62;
            this.dgvBudgets.RowTemplate.Height = 31;
            this.dgvBudgets.Size = new System.Drawing.Size(1194, 540);
            this.dgvBudgets.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 684);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "記帳分析系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.tabChart.ResumeLayout(false);
            this.tabChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.tabBudget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.TabPage tabBudget;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuUsage;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.Button btnSaveBudget;
        private System.Windows.Forms.DataGridView dgvBudgets;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateChart;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
    }
}

