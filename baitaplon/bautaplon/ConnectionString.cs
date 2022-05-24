using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien
{
    internal class ConnectionString
    {
        public static string getConnectionString() {
            //Data Source=DESKTOP-1RDTQLK;Initial Catalog=test;Integrated Security=True;Pooling=False
            string connString = @"Data Source=DESKTOP-1RDTQLK;Initial Catalog=Quanlythuvien;Integrated Security=True";
            return connString;
            }
    }
}
