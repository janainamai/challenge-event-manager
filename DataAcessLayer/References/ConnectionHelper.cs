using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.References
{
    public class ConnectionHelper
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Janaina\Usuario\Documents\testeteste.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}
