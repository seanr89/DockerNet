using System.Globalization;
using appbencher.Model;
using CsvHelper;
namespace appbencher;

public class CSVFileIngest
{
    public void readFile()
    {
        using (var reader = new StreamReader("path\\to\\file.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<CSVRecord>();
        }
    }
}
