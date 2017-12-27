using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
{
    public class StyleSection : ConfigurationSection
    {
        [ConfigurationProperty("Styles")]
        public StyleAppearanceCollection StyleElement
        {
            get { return ((StyleAppearanceCollection)(base["Styles"])); }
            set { base["Styles"] = value; }
        }
    }
}
