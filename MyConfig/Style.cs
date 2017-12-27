using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
{
    public class Style : ConfigurationElement
    {
        [ConfigurationProperty("displayname", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string DisplayName
        {
            get { return (string)base["displayname"]; }
            set { base["displayname"] = value; }
        }
        [ConfigurationProperty("valuename", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string ValueName
        {
            get { return (string)base["valuename"]; }
            set { base["valuename"] = value; }
        }
        
        [ConfigurationProperty("stylecategory", DefaultValue = "", IsKey = false, IsRequired = false)]
        public string StyleCategory
        {
            get { return (string)base["stylecategory"]; }
            set { base["stylecategory"] = value; }
        }
    }
}
