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
---

## 2. 下載與執行方式（IMPORTANT）

> 目前採用 **ClickOnce 發佈**，Windows 對某些資料夾有額外安全限制  
> 若直接在下載資料夾執行，可能會出現「無法從這個位置啟動應用程式」訊息。

### 2.1 下載

1. 前往 **Releases 頁面**：  
    [Download – Accounting Analysis System]([https://github.com/你的帳號/你的Repo/releases/latest](https://github.com/lin01009/accounting-analysis-system/releases/download/v1.0.0/Accounting_Analysis_System_v1.0.0.zip))  
   

2. 下載壓縮檔：  
   `Accounting_Analysis_System_v1.0.0.zip`

---

### 2.2 解壓縮與放置位置

1. 將 `AccountingAnalysisSystem_Release.zip` 解壓縮。
解壓縮整個資料夾

將以下三個檔案全部搬到桌面（不可放在其他資料夾）：

`Accounting_Analysis_System.application`
`Application Files/`
`setup`

---

2.3 執行程式（ClickOnce 限制版）

在桌面雙擊 `Accounting_Analysis_System.application`
系統會啟動 ClickOnce 安裝流程，完成後即可執行。

⚠ 注意

由於 ClickOnce 的安全性限制，本應用程式 只能在桌面啟動，放在其他路徑可能會被 Windows 阻擋並顯示無法啟動的訊息。

這是 ClickOnce 的設計特性，不是程式錯誤。

---

## 3. 系統功能說明

---

### 3.1 記帳輸入

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

### 3.2 支出紀錄查詢
透過 DataGridView 顯示歷史記錄，可依「分類」與「日期區間」篩選：

```csharp
var filtered = expenseList
    .Where(item =>
        (selectedCategory == "全部" || item.Category == selectedCategory) &&
        item.Date.Date >= startDate &&
        item.Date.Date <= endDate)
    .ToList();
```

### 3.3 圖表分析（圓餅圖＋長條圖）
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

### 3.4 預算設定與超支提示
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

### 3.5 資料儲存、匯入、匯出

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

## 4. 個人學習重點
   
從「做功能」到「理解系統運作與資料設計」

使用 LINQ 建立查詢邏輯

使用 JSON 建立資料持久化

使用 Chart + HitTest 建立互動式視覺化

