# Custom Configuration section with a collection

A simple example of how to create a configuration section in your app.config or web.config with a collection of custom elements

This example uses a collection of styles

Don't forget to reference System.Configuration to your project

## Program.cs
In this class we simply call our ConfigSettings (which is a helper class) to fetch all elements in our configuration & display them on the console

## ConfigSettings.cs
This class is responsible to get the custom section.
It also contains a property to return the collection of custom elements.

## Style.cs
This class is our custom element contract, so in here we define the properties of our element.
This is done by inheriting from the ConfigurationElement (which uses the System.Configuration)
By the use of the [ConfigurationProperty()] we define our property as an element attribute
```csharp
public class Style : ConfigurationElement
    {
        [ConfigurationProperty("displayname", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string DisplayName
        {
            get { return (string)base["displayname"]; }
            set { base["displayname"] = value; }
        }
        
        ...
    }
```

## StyleAppearanceCollection.cs
This class is responsible to create a collection of our custom elements. This is done by inheriting from ConfigurationElementcollection & using the [ConfigurationCollection()] annotation.

```csharp
[ConfigurationCollection(typeof(Style))]
public class StyleAppearanceCollection : ConfigurationElementCollection
    {
        ...
    }
```

## StyleSection.cs
This class inherits from ConfigurationSection and will return the content of your custom section (this class is also referenced in your App/web.config)
```csharp
public class StyleSection : ConfigurationSection
    {
        [ConfigurationProperty("Styles")]
        public StyleAppearanceCollection StyleElement
        {
            get { return ((StyleAppearanceCollection)(base["Styles"])); }
            set { base["Styles"] = value; }
        }
    }
```

## App.config / Web.config
In your configuration file you will define your custom section with a type (this type is the class of your ConfigurationSection).

The type consists of '<Namespace.ClassName>, <AssemblyName>'

```xml
  <configSections>
    <section name="styleSection" type="MyConfig.StyleSection, MyConfig"/>
  </configSections>
```


Then you define your custom section, with your collection-tag (StyleSection.cs's property). And last but not least you define your elements which will be in your collection (Style.cs)

```xml
  <styleSection>
    <Styles>
      <Style stylecategory="Headings"
             displayname="H1"
             valuename="Heading 1" />
      <Style stylecategory="Headings"
             displayname="H2"
             valuename="Heading 2"/>
      <Style stylecategory="Body"
             displayname="H5"
             valuename="Heading 5"/>
    </Styles>
  </styleSection>
  ```
