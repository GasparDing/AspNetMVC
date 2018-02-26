# AspNetMVC
Getting Started with ASP.NET MVC 5

MVC 代表 model-view-controller，這個架構是為了讓開發具有更好的程式結構、可測試、容易維護。

模型 Models: 使用驗證邏輯為該數據執行業務邏輯的類別。 檢視 Views: 應用程序用於動態生成HTML響應的模板文件。 控制 Controllers: 處理傳入瀏覽器請求的類別，透過檢索模型的數據，然後指定返回瀏覽器響應的檢視模板。

ASP.NET MVC 包含了許多不同含有許多aciton 的controller，預設的routing 規則如以下：/[Controller]/[ActionName]/[Parameters]，我們也可以在App_Start/RouteConfig.cs 這個檔案改變他的routing 規則。
