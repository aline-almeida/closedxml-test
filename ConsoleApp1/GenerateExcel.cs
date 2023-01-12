using ClosedXML.Excel;

namespace ConsoleApp1
{
    public static class GenerateExcel
    {
        public static byte[] Run()
        {
            using XLWorkbook workbook = new XLWorkbook();
            workbook.Worksheets.Add("Sample")
                .Cell(1, 1).SetValue("Hello World");
            using var ms = new MemoryStream();
            workbook.SaveAs(ms);
            return ms.ToArray();
        }
    }
}