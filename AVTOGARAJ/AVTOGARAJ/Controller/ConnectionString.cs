﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTOGARAJ.Controller
{
    internal class ConnectionString
    {
        public static string ConnStr
        {
            get 
            {
               return ConfigurationManager.ConnectionStrings["AVTOGARAJ.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}
