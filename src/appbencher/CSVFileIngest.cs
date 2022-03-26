using System.Globalization;
using appbencher.Model;
using CsvHelper;
namespace appbencher;

public class CSVFileIngest
{
    /// <summary>
    /// App to use the nuget based csvReader
    /// </summary>
    public void CSVReadFile()
    {
        using (var reader = new StreamReader("path\\to\\datafile.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<CSVRecord>();
        }
    }
}
