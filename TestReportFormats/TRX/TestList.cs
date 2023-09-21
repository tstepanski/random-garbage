using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("TestList")]
public sealed class TestList
{
	[XmlAttribute("id")] public Guid Id { get; set; }

	[XmlAttribute("name")] public string Name { get; set; } = string.Empty;
}