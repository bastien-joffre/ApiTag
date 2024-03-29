﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTag
{
    interface IRequestManager
    {
        string getStationsByRadius(string x, string y, int radius);

        List<T> deserializeJson<T>(string json);
    }
}
