﻿using System;
using System.IO;
using Samples.Models;
using SQLite.Net;
using SQLite.Net.Interop;


namespace Samples
{

    public class SampleDbConnection : SQLiteConnection
    {

        public SampleDbConnection(ISQLitePlatform platform, string databasePath) : base(platform, Path.Combine(databasePath, "ble.db"))
        {
            this.CreateTable<BleRecord>();
        }


        public TableQuery<BleRecord> BleRecords => this.Table<BleRecord>();
    }
}