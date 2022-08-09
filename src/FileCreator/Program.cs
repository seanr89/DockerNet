
public class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        string path = Directory.GetCurrentDirectory();
        //string target = @"c:\temp";
        Console.WriteLine("The current directory is {0}", path);

        string data = "This is a new piece of text!";
        // Write the string array to a new file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter("WriteLines.txt"))
        {
            outputFile.WriteLine(data);
        }

        Console.WriteLine("XXXXXXXXXXXXXXXXXX");

        //TODO read file back out
        try
        {
            // Open the text file using a stream reader.
            using (var sr = new StreamReader("mynewfile.txt"))
            {
                // Read the stream as a string, and write the string to the console.
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        Thread.Sleep(5000);
        Console.WriteLine("Complete");
    }
}
