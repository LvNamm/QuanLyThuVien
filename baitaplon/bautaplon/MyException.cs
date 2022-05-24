using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien
{
    internal class MyException:Exception
    {
        public MyException(string s) : base(s) { }
    }
}
