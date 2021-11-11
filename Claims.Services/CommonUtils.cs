using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Claims.Services
{
    public static class CommonUtils
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static string SecondaryDbConnectionString => ConfigurationManager.ConnectionStrings["SecondaryDbConnection"].ConnectionString;

        public static string ApplicationUrl => ConfigurationManager.AppSettings["RootUrl"];

    }
}