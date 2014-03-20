using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOMP_Client
{
    public static class INI
    {
        static string configFile = "config.ini";

        public static void Config(params string[] keyValues){

            if (keyValues.Length % 2 != 0)
                throw new ArgumentException("Must be even number of arguments as [key, value, key, value]");

            var configLines = File.ReadAllLines(configFile);
            var config = configLines.ToDictionary(l => l.Split('=')[0], l => l.Split('=')[1], StringComparer.OrdinalIgnoreCase);

            for (var i = 0; i < keyValues.Length; i += 2)
            {
                config[keyValues[i]] = keyValues[i + 1];
            }
            File.WriteAllLines(configFile, from p in config select p.Key.ToLower() + "=" + p.Value.ToLower());
        }

        public static string Value(string key)
        {
            return File.ReadAllLines(configFile).Single(s => s.Split('=')[0].ToLower() == key).Split('=')[1].ToLower();
        }
    }
}
