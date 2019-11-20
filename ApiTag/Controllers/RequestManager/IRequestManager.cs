using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTag
{
    interface IRequestManager
    {
        string getLinesByRadius(string x, string y, int radius);
    }
}
