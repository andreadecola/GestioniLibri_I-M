﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestiti_Libri.Utilities
{
    internal class Config
    {
        private static Config? istanza;
        private string? connectionString;

        public static Config getIstanza()
        {
            if (istanza == null)
                istanza = new Config();

            return istanza;
        }

        private Config()
        {

        }
        public string? GetConnectionString()
        {
            if (connectionString == null)
            {
                ConfigurationBuilder builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appSettings.json", optional: false, reloadOnChange: false);

                connectionString = configuration.GetConnectionString("ServerLocale");
            }

            return connectionString;
        }
    }
}
