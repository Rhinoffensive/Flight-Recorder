﻿using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace FlightRecorder.Client.Logics
{
    public class ExportLogic
    {
        public async Task ExportAsync(string fileName, IEnumerable<AircraftPosition> records)
        {
            using var writer = new StreamWriter(fileName);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            await csv.WriteRecordsAsync(records);
        }

        public async Task ExportTimeStampAsync(string fileName,List<RecordVideoClass> timeStamps)
        {
            using var writer = new StreamWriter(fileName);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            //csv.WriteRecords(timeStamps);
            await csv.WriteRecordsAsync(timeStamps);


            
        }
    }
}
