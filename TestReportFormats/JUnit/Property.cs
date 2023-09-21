using System.Xml.Serialization;

namespace YamTestReporter.Reports.JUnit;

[XmlType("property")]
public sealed class Property
{
	[XmlAttribute("name")] public string Name { get; set; } = string.Empty;

	[XmlAttribute("value")] public string Value { get; set; } = string.Empty;
}