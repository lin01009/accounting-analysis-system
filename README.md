# 記帳分析系統 (Accounting Analysis System)

使用 C# / Windows Forms 開發的個人記帳分析系統，從「資料輸入 → 查詢 → 圖表分析 → 預算管理 → 檔案儲存與匯出」都由我一人設計與實作。  
專案重點不在介面視覺，而是在 **資料結構設計、系統流程與可維護性**。

---

## 1. 專案簡介

- 開發環境：Visual Studio .NET、C#、Windows Forms  
- 專案型態：桌面應用程式  
- 主要功能：
  - 記帳輸入（日期 / 類別 / 金額 / 備註）
  - 支出紀錄查詢（依日期區間與類別過濾）
  - 圖表分析（分類圓餅圖、每日支出長條圖）
  - 預算設定與超支提示
  - JSON 儲存 / 載入記帳資料
  - CSV 匯出支出紀錄

---

## 2. 系統功能說明

---

### 2.1 記帳輸入

表單輸入日期、支出類別、金額與備註，並使用 `Expense` 類別封裝資料：

```csharp
public class Expense
{
    public DateTime Date { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }
    public string Note { get; set; }
}
```
所有紀錄儲存在：

```csharp
List<Expense> expenseList;
```

2.2 支出紀錄查詢
透過 DataGridView 顯示歷史記錄，可依「分類」與「日期區間」篩選：

```csharp
var filtered = expenseList
    .Where(item =>
        (selectedCategory == "全部" || item.Category == selectedCategory) &&
        item.Date.Date >= startDate &&
        item.Date.Date <= endDate)
    .ToList();
```

2.3 圖表分析（圓餅圖＋長條圖）
分類圓餅圖（GroupBy → Sum）

```csharp
var byCategory = expenseList
    .GroupBy(record => record.Category)
    .Select(group => new
    {
        Category = group.Key,
        Total = group.Sum(item => item.Amount)
    });
```
每日支出長條圖（依日期聚合）


```csharp
var byDate = expenseList
    .GroupBy(record => record.Date.Date)
    .OrderBy(group => group.Key)
    .Select(group => new
    {
        Date = group.Key,
        Total = group.Sum(item => item.Amount)
    });
```

點擊圖表查看明細（HitTest）

```csharp
HitTestResult result = chartExpenses.HitTest(e.X, e.Y);
```

2.4 預算設定與超支提示
預算由 DataGridView 輸入並儲存為 JSON：
```csharp
public class BudgetItem
{
    public string Category { get; set; }
    public decimal Amount { get; set; }
}
```

超支檢查：
```csharp
if (item.Total > budget.Amount)
{
    pieSeries.Points[index].ToolTip = $"超出預算 {item.Total - budget.Amount} 元";
}
```

2.5 資料儲存、匯入、匯出

JSON 儲存資料
```csharp
string json = JsonSerializer.Serialize(expenseList, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText("data.json", json);
```
JSON 載入資料
```csharp
expenseList = JsonSerializer.Deserialize<List<Expense>>(json);
```
CSV 匯出
```csharp
var lines = new List<string> { "日期,類別,金額,備註" };
```
## 3. 如何執行

下載或 clone 本專案

使用 Visual Studio 開啟 Accounting_Analysis_System.sln

還原 NuGet 套件（若需要）

執行專案即可開始記帳

## 4. 個人學習重點
   
從「做功能」到「理解系統運作與資料設計」

使用 LINQ 建立查詢邏輯

使用 JSON 建立資料持久化

使用 Chart + HitTest 建立互動式視覺化

