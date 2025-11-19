using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Windows.Forms.DataVisualization.Charting;



namespace Accounting_Analysis_System
{
    public partial class Form1 : Form
    {
        private List<Expense> expenseList = new List<Expense>();
        private List<BudgetItem> budgetList = new List<BudgetItem>();


        private void InitializeBudgetTable()
        {
            // 清除舊欄位與資料
            dgvBudgets.Columns.Clear();
            dgvBudgets.Rows.Clear();

            // 設定表格屬性
            dgvBudgets.AllowUserToAddRows = false;
            dgvBudgets.RowHeadersVisible = false;
            dgvBudgets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudgets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 加入「類別」欄（只讀）
            DataGridViewTextBoxColumn colCategory = new DataGridViewTextBoxColumn();
            colCategory.Name = "colCategory";
            colCategory.HeaderText = "類別";
            colCategory.ReadOnly = true;
            dgvBudgets.Columns.Add(colCategory);

            // 加入「預算金額」欄（可編輯）
            DataGridViewTextBoxColumn colBudget = new DataGridViewTextBoxColumn();
            colBudget.Name = "colBudget";
            colBudget.HeaderText = "預算金額";
            colBudget.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBudgets.Columns.Add(colBudget);

            // 加入預設資料（可根據實際分類調整）
            dgvBudgets.Rows.Add("餐飲", 3000);
            dgvBudgets.Rows.Add("交通", 1000);
            dgvBudgets.Rows.Add("書籍", 500);
            dgvBudgets.Rows.Add("娛樂", 800);
            dgvBudgets.Rows.Add("其他", 600);
        }
        private void InitializeCategoryList()
        {
            cmbCategory.Items.AddRange(new string[] { "餐飲", "交通", "書籍", "娛樂", "其他" });
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.SelectedIndex = 0;

            cmbFilterCategory.Items.Add("全部");
            cmbFilterCategory.Items.AddRange(new string[] { "餐飲", "交通", "書籍", "娛樂", "其他" });
            cmbFilterCategory.SelectedIndex = 0;
        }
        private void InitializeChartType()
        {
            cmbChartType.Items.Add("分類圓餅圖");
            cmbChartType.Items.Add("每日支出長條圖");
            cmbChartType.SelectedIndex = 0;
        }
        private void InitializeHistoryTable()
        {
            dgvRecords.Columns.Clear();
            dgvRecords.Rows.Clear();

            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.ReadOnly = true;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRecords.Columns.Add("colDate", "日期");
            dgvRecords.Columns.Add("colCategory", "類別");
            dgvRecords.Columns.Add("colAmount", "金額");
            dgvRecords.Columns.Add("colNote", "備註");
            dgvRecords.Columns["colAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public Form1()
        {
            InitializeComponent();
            InitializeHistoryTable();
            InitializeChartType();
            LoadBudgetFromFile();
            chartExpenses.MouseClick += chartExpenses_MouseClick;
        }

        private void 說明ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvRecords.Rows.Clear();

            string selectedCategory = cmbFilterCategory.SelectedItem.ToString();
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            var filtered = expenseList
                .Where(item =>
                    (selectedCategory == "全部" || item.Category == selectedCategory) &&
                    item.Date.Date >= startDate && item.Date.Date <= endDate)
                .ToList();

            foreach (var item in filtered)
            {
                dgvRecords.Rows.Add(item.Date.ToString("yyyy/MM/dd"), item.Category, item.Amount, item.Note);
            }

            if (filtered.Count == 0)
            {
                MessageBox.Show("沒有找到符合條件的資料");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeBudgetTable(); 
            InitializeCategoryList();
            dtpDate.Value = DateTime.Today;


           
        }
        private void LoadBudgetFromFile()
        {
            if (File.Exists("budget.json"))
            {
                string json = File.ReadAllText("budget.json");
                var budgets = JsonSerializer.Deserialize<List<BudgetItem>>(json);

                InitializeBudgetTable(); 
                dgvBudgets.Rows.Clear();

                foreach (var item in budgets)
                {
                    dgvBudgets.Rows.Add(item.Category, item.Amount);
                }

                budgetList = budgets; 
            }
        }

        private void btnSaveBudget_Click(object sender, EventArgs e)
        {
            var budgets = new List<BudgetItem>();

            foreach (DataGridViewRow row in dgvBudgets.Rows)
            {
                if (row.Cells["colCategory"].Value != null && row.Cells["colBudget"].Value != null)
                {
                    budgets.Add(new BudgetItem
                    {
                        Category = row.Cells["colCategory"].Value.ToString(),
                        Amount = Convert.ToDecimal(row.Cells["colBudget"].Value)
                    });
                }
            }

            string json = JsonSerializer.Serialize(budgets, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("budget.json", json);
            MessageBox.Show("預算已儲存！");
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇支出類別！");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("請輸入有效的金額！");
                return;
            }

            Expense newExpense = new Expense
            {
                Date = dtpDate.Value,
                Category = cmbCategory.SelectedItem.ToString(),
                Amount = amount,
                Note = txtNote.Text
            };

            expenseList.Add(newExpense);
            MessageBox.Show("已新增一筆記帳資料！");

            // 清空輸入欄位
            txtAmount.Text = "";
            txtNote.Text = "";
            cmbCategory.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today;
        }

        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            budgetList = new List<BudgetItem>();

            foreach (DataGridViewRow row in dgvBudgets.Rows)
            {
                if (row.Cells["colCategory"].Value != null && row.Cells["colBudget"].Value != null)
                {
                    budgetList.Add(new BudgetItem
                    {
                        Category = row.Cells["colCategory"].Value.ToString(),
                        Amount = Convert.ToDecimal(row.Cells["colBudget"].Value)
                    });
                }
            }
            chartExpenses.Series.Clear();
            chartExpenses.ChartAreas.Clear();
            chartExpenses.Titles.Clear();

            chartExpenses.ChartAreas.Add("MainArea");

            string selectedType = cmbChartType.SelectedItem.ToString();

            if (selectedType == "分類圓餅圖")
            {
                var byCategory = expenseList
                    .GroupBy(record => record.Category)
                    .Select(group => new
                    {
                        Category = group.Key,
                        Total = group.Sum(item => item.Amount)
                    });

                Series pieSeries = new Series("支出分類");
                pieSeries.ChartType = SeriesChartType.Pie;

                pieSeries.Label = "#PERCENT";         
                pieSeries.LegendText = "#VALX";       

                foreach (var item in byCategory)
                {
                    int pointIndex = pieSeries.Points.AddXY(item.Category, item.Total);

                    
                    var budget = budgetList.FirstOrDefault(b => b.Category == item.Category);
                    if (budget != null && item.Total > budget.Amount)
                    {
                        

                        
                        pieSeries.Points[pointIndex].LabelForeColor = Color.White;
                        pieSeries.Points[pointIndex].ToolTip = $"超出預算 {item.Total - budget.Amount} 元";
                    }
                    else
                    {
                        
                        pieSeries.Points[pointIndex].ToolTip = $"支出：{item.Total} 元";
                    }
                }

                chartExpenses.Series.Add(pieSeries);
                chartExpenses.Titles.Add("各分類支出比例");
            }
            else if (selectedType == "每日支出長條圖")
            {
                var byDate = expenseList
                    .GroupBy(record => record.Date.Date)
                    .OrderBy(group => group.Key)
                    .Select(group => new
                    {
                        Date = group.Key,
                        Total = group.Sum(item => item.Amount)
                    });

                Series barSeries = new Series("每日支出");
                barSeries.ChartType = SeriesChartType.Column;

                foreach (var item in byDate)
                {
                    barSeries.Points.AddXY(item.Date.ToString("MM/dd"), item.Total);
                }

                chartExpenses.Series.Add(barSeries);
                chartExpenses.Titles.Add("每日支出變化");
            }

        }

        private void chartExpenses_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = chartExpenses.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint && result.Series != null)
            {
                int pointIndex = result.PointIndex;
                var point = result.Series.Points[pointIndex];

                
                string chartTitle = chartExpenses.Titles.Count > 0 ? chartExpenses.Titles[0].Text : "";

                if (chartTitle.Contains("分類"))  
                {
                    string category = point.AxisLabel;

                    var details = expenseList
                        .Where(item => item.Category == category)
                        .OrderBy(item => item.Date)
                        .Select(item => $"{item.Date:MM/dd} - {item.Amount} 元 - {item.Note}");

                    string message = details.Any()
                        ? string.Join("\n", details)
                        : "此分類沒有明細資料。";

                    MessageBox.Show(message, $"「{category}」支出明細");
                }
                else if (chartTitle.Contains("每日"))  
                {
                    string dateLabel = point.AxisLabel;  
                    if (DateTime.TryParse(dateLabel, out DateTime targetDate))
                    {
                        var details = expenseList
                            .Where(item => item.Date.Date == targetDate.Date)
                            .OrderBy(item => item.Category)
                            .Select(item => $"{item.Category} - {item.Amount} 元 - {item.Note}");

                        string message = details.Any()
                            ? string.Join("\n", details)
                            : "該日沒有支出資料。";

                        MessageBox.Show(message, $"「{targetDate:MM/dd}」支出明細");
                    }
                }
            }
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON 檔案|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(dialog.FileName);
                expenseList = JsonSerializer.Deserialize<List<Expense>>(json);
                MessageBox.Show("記帳資料已載入！");
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON 檔案|*.json";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json = JsonSerializer.Serialize(expenseList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(dialog.FileName, json);
                MessageBox.Show("記帳資料已儲存！");
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON 檔案|*.json";
            dialog.Title = "匯入記帳資料";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(dialog.FileName);
                    var imported = JsonSerializer.Deserialize<List<Expense>>(json);

                    if (imported != null)
                    {
                        expenseList = imported;
                        MessageBox.Show("匯入成功，資料已載入！");

                        dgvRecords.Rows.Clear();
                        foreach (var item in expenseList)
                        {
                            dgvRecords.Rows.Add(item.Date.ToString("yyyy/MM/dd"), item.Category, item.Amount, item.Note);
                        }
                    }
                    else
                    {
                        MessageBox.Show("匯入失敗，資料格式不正確。");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("匯入過程發生錯誤：" + ex.Message);
                }
            }
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV 檔案|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var lines = new List<string> { "日期,類別,金額,備註" };
                lines.AddRange(expenseList.Select(item =>
                    $"{item.Date:yyyy/MM/dd},{item.Category},{item.Amount},{item.Note}"));

                File.WriteAllLines(dialog.FileName, lines);
                MessageBox.Show("支出紀錄已匯出為 CSV");
            }
        }

        private void mnuUsage_Click(object sender, EventArgs e)
        {
            string helpText =
@"《記帳分析系統》操作說明：

1️ 【記帳輸入】
- 輸入日期、類別、金額與備註後，點選「新增記帳」。

2️ 【支出紀錄】
- 可依分類與日期範圍查詢支出明細。

3️ 【圖表分析】
- 選擇圖表類型（分類圓餅圖、每日長條圖）後按下「產生圖表」。
- 點圖表可查看該分類或日期的支出明細。

4️ 【預算設定】
- 直接編輯預算表格的金額，完成後按下「儲存預算」。

5️ 【檔案功能】
- 使用『檔案→儲存』可保存資料（JSON），日後可再從『匯入』讀取。";

            MessageBox.Show(helpText, "操作說明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class BudgetItem
    {
        public string Category { get; set; }
        public decimal Amount { get; set; }
    }
    public class Expense
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
    }

}

