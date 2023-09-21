using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("TestSettings")]
public sealed class TestSettings
{
	[XmlAttribute("name")] public string Name { get; set; } = string.Empty;

	[XmlAttribute("id")] public Guid Id { get; set; }

	[XmlElement] public Deployment Deployment { get; set; } = new();
}