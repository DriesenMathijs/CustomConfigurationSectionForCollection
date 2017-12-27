using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigSettings test = new ConfigSettings();
            var t = test.StyleAppearanceConfiguration;

            foreach (var item in t.StyleElement)
            {
                Console.WriteLine($"Category: {((Style)item).StyleCategory} - DisplayName: {((Style)item).DisplayName} - ValueName: {((Style)item).ValueName}");
            }
            Console.ReadLine();
        }
    }
}
