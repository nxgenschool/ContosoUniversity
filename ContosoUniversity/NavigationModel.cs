using System.Xml.Serialization;
using System.Collections.Generic;

namespace ContosoUniversity
{
    [XmlRoot("Navigation")]
    public class NavigationModel
    {
        [XmlElement("MenuItem")]
        public List<MenuItem> MenuItems { get; set; }
    }

    public class MenuItem
    {
        public string Text { get; set; }
        public string Url { get; set; }

        [XmlElement("SubMenu")]
        public List<MenuItem> SubMenu { get; set; }
    }
}



