   /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace myApp
{
	[XmlRoot(ElementName="General")]
	public class General {
		[XmlElement(ElementName="MachineType")]
		public string MachineType { get; set; }
		[XmlElement(ElementName="Name")]
		public string Name { get; set; }
		[XmlElement(ElementName="Width")]
		public string Width { get; set; }
		[XmlElement(ElementName="Height")]
		public string Height { get; set; }
	}

	[XmlRoot(ElementName="Content")]
	public class Content {
		[XmlElement(ElementName="Data")]
		public string Data { get; set; }
		[XmlElement(ElementName="Format")]
		public string Format { get; set; }
		[XmlElement(ElementName="Separator")]
		public string Separator { get; set; }
		[XmlElement(ElementName="CountryCode")]
		public string CountryCode { get; set; }
		[XmlElement(ElementName="DayOffset")]
		public string DayOffset { get; set; }
		[XmlElement(ElementName="MonthOffset")]
		public string MonthOffset { get; set; }
		[XmlElement(ElementName="YearOffset")]
		public string YearOffset { get; set; }
		[XmlElement(ElementName="Type")]
		public string Type { get; set; }
		[XmlElement(ElementName="UpperCase")]
		public string UpperCase { get; set; }
		[XmlElement(ElementName="UseSpecialMonthNames")]
		public string UseSpecialMonthNames { get; set; }
		[XmlElement(ElementName="SpecialMonthNames")]
		public string SpecialMonthNames { get; set; }
	}

	[XmlRoot(ElementName="Font")]
	public class Font {
		[XmlElement(ElementName="Name")]
		public string Name { get; set; }
		[XmlElement(ElementName="Size")]
		public string Size { get; set; }
		[XmlElement(ElementName="Style")]
		public string Style { get; set; }
	}

	[XmlRoot(ElementName="Object")]
	public class Object {
		[XmlElement(ElementName="ObjectType")]
		public string ObjectType { get; set; }
		[XmlElement(ElementName="Name")]
		public string Name { get; set; }
		[XmlElement(ElementName="X")]
		public string X { get; set; }
		[XmlElement(ElementName="Y")]
		public string Y { get; set; }
		[XmlElement(ElementName="W")]
		public string W { get; set; }
		[XmlElement(ElementName="H")]
		public string H { get; set; }
		[XmlElement(ElementName="Rotate")]
		public string Rotate { get; set; }
		[XmlElement(ElementName="Hidden")]
		public string Hidden { get; set; }
		[XmlElement(ElementName="Content")]
		public Content Content { get; set; }
		[XmlElement(ElementName="Font")]
		public Font Font { get; set; }
	}

	[XmlRoot(ElementName="Template")]
	public class Template {
		[XmlElement(ElementName="General")]
		public General General { get; set; }
		[XmlElement(ElementName="Object")]
		public Object Object { get; set; }
	}

}
