using ClosedXML.Excel;
using ConsoleApp1;
using FluentAssertions;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var bytes = GenerateExcel.Run();
            MemoryStream memoryStream = new MemoryStream(bytes);
            XLWorkbook wb = new XLWorkbook(memoryStream);
            wb.Should().NotBeNull();
            wb.Worksheets.Should().HaveCount(1);
        }
    }
}