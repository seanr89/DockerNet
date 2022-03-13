
namespace FileBenched;

public class CSVRecord
{
    public int TRANSACTION_ID { get; set; }
    public string MCC { get; set; }
    public static CSVRecord fromCSV(string line, char delimiter)
    {
        var rec = new CSVRecord();
        var splitList = line.Split(delimiter);

        rec.TRANSACTION_ID = Convert.ToInt16(splitList[0]);
        rec.MCC = splitList[1];
        return rec;
    }
}