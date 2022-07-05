using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvReaderDecompressorForLiran.Model;

namespace CsvReaderDecompressorForLiran.Services
{
    public class UnitFactory
    {
        private readonly IDecompressorService _decompressorService;

        public UnitFactory(IDecompressorService decompressorService)
        {
            _decompressorService = decompressorService;
        }

        public Unit Create(string unitStrRow)
        {
            // Nested data goes here


            var dataSplited = unitStrRow.Split(',');
            // arr[] {item1 item}

            // unitParam1 = arr[0]
            // foreach (var VARIABLE in COLLECTION)
            // {
            //     // unitParam4.DictionaryName.Add(key, value);
            //     for (int i = 0; i < UPPER; i++)
            //     {
            //         
            //     }
            // }
            // unitParam2 = arr[1]
            // unitParam3 = __decompressorService(arr[2])
            return new Unit();
        }
    }
}
