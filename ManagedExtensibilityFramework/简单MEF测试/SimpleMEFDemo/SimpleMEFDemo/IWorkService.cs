﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMEFDemo
{

    public interface IWorkService
    {

        string WorkName { get; set; }
        string GetWorkName();
        void DoWork();

    }
}
