Excel 操作测试

添加引用中，找到Com,搜索excel，添加 Midcrosoft Excel 16.0 Object Library.

     using Excel = Microsoft.Office.Interop.Excel;
    
     Excel.Application xlApp;
      Excel.Workbook xlWorkBook;
      Excel.Worksheet xlWorkSheet;
      object misValue = System.Reflection.Missing.Value;
      xlApp = new Excel.Application();
      xlWorkBook = xlApp.Workbooks.Add(misValue);
      xlWorkSheet = xlWorkBook.Sheets["Sheet1"];
      xlWorkSheet.Cells[1, 1] = "http://csharp.net-informations.com";
      xlWorkSheet.Cells[2, 1] = "Adding picture in Excel File";
      xlWorkBook.SaveAs("csharp.net-informations.xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
      xlApp.Quit();



异常，用户电脑没有安装对映版本 的 OFFICE 时
Exception Info: System.Runtime.InteropServices.COMException (0x80040154): Retrieving the COM class factory for component with CLSID {00024500-0000-0000-C000-000000000046} failed due to the following error: 80040154 没有注册类 (0x80040154）



也可以添加nuget  Microsoft.Office.Interop.Excel 类





