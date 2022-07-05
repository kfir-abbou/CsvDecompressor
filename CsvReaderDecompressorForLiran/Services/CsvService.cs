using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReaderDecompressorForLiran
{
    public class CsvService : ICsvService
    {
        public string ReadCsv(string filePath)
        {
            // Read file return file data as string 
            return string.Empty;
        }

        public List<string> ParseCsvData(string csvText)
        {
            // gets csv data as text - return deserialized data
            // Option 2 -> return string -> data arranged differently (in a custom way)

            return new List<string>();
        }
    }

    public interface ICsvService // TODO: Move to different file
    {
    }
}
