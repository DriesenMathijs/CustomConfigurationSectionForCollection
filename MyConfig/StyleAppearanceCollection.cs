using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfig
{
    [ConfigurationCollection(typeof(Style))]
    public class StyleAppearanceCollection : ConfigurationElementCollection
    {
        internal const string PropertyName = "Style";

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        protected override string ElementName
        {
            get
            {
                return PropertyName;
            }
        }

        protected override bool IsElementName(string elementName)
        {
            return elementName.Equals(PropertyName, StringComparison.InvariantCultureIgnoreCase);
        }


        public override bool IsReadOnly()
        {
            return false;
        }


        protected override ConfigurationElement CreateNewElement()
        {
            return new Style();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Style)(element)).DisplayName;
        }

        public Style this[int idx]
        {
            get
            {
                return (Style)BaseGet(idx);
            }
        }
    }
}
