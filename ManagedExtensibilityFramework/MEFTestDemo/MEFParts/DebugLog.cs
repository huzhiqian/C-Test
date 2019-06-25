﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;



    [Export(typeof(ILogger))]
    [ExportMetadata("Guid","{D8CD4E3B-0427-47B6-B467-5C146F3C721F}")]
    public class DebugLog : ILogger
    {
    //public string Guid => throw new NotImplementedException();

    public void WriteLog(string logInfo)
        {
            Console.WriteLine($"Debug log:{logInfo}");
        }
    }

