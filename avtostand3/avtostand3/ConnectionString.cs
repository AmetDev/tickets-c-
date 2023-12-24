using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtostand3
{
    internal class ConnectionString
    {
        public static string ConnStr
        {
            get {
                return ConfigurationManager.ConnectionStrings["avtostand3.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}
