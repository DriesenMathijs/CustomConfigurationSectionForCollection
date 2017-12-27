using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
{
    public class ConfigSettings
    {
        public StyleSection StyleAppearanceConfiguration
        {
            get
            {
                return (StyleSection)ConfigurationManager.GetSection("styleSection");
            }
        }

        public StyleAppearanceCollection StyleApperances
        {
            get
            {
                return this.StyleAppearanceConfiguration.StyleElement;
            }
        }

        public IEnumerable<Style> StyleElements
        {
            get
            {
                foreach (Style selement in this.StyleApperances)
                {
                    if (selement != null)
                        yield return selement;
                }
            }
        }
    }
}
