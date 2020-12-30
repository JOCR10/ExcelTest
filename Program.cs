using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace ExcelTest
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<WideAddress> records = null;
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\MOCK_DATA.csv");
            List<NarrowAddress> narrowAddresses = new List<NarrowAddress>();
            ProcessAddresses processAddress = null;
            using (var reader = new StreamReader(path))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Read();
                    csv.ReadHeader();
                    while (csv.Read())
                    {
                        var record = csv.GetRecord<WideAddress>();
                        processAddress = new ProcessAddresses(record);
                        narrowAddresses.AddRange(processAddress.getNarrowAddresses());
                    }
                }
            }
            string pathWrtr = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\MOCK_DATA_OUTPUT.csv");
            using (var writer = new StreamWriter(pathWrtr))
            using (var csvWrtr = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWrtr.WriteHeader<NarrowAddress>();
                csvWrtr.NextRecord();
                foreach (var address in narrowAddresses)
                {
                    csvWrtr.WriteRecord(address);
                    csvWrtr.NextRecord();
                }
            }
            Environment.Exit(0);
        }
    }
}
