using System;
using System.Net.Http.Headers;
using CsvReaderDecompressorForLiran.Services;

namespace CsvReaderDecompressorForLiran
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Use container -> LightInject for example

            Console.WriteLine("Hello World!");

            var csvPath = args[0];

            var csvReader = new CsvService();
            /*
             * FIRST_NAME       LAST_NAME     AGE     
             *  Liran           Abadi           37.5
             *  Liran           Abadi           37.5
             *  Liran           Abadi           37.5
             *  Liran           Abadi           37.5
             */


            var csvAsText = csvReader.ReadCsv(csvPath);
            /*
             *FIRST_NAME       LAST_NAME     AGE \n Liran           Abadi           37.5 \n Liran           Abadi           37.5
             *
             */
            var listOfCsvRows = csvReader.ParseCsvData(csvAsText);

            /*
             * List<string> -> 0. FIRST_NAME       LAST_NAME     AGE
             *                 1. Liran           Abadi           37.5
             */

            IDecompressorService decompressorService = new DecompressorService();

            var unitFactory = new UnitFactory(decompressorService);
            foreach (var textRow in listOfCsvRows)
            {
                // Build Unit
                var unit = unitFactory.Create(textRow);
            }


        }
    }
}
