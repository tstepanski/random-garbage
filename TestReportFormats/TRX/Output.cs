using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("Output")]
public sealed class Output
{
	[XmlElement] public ErrorInformation ErrorInformation { get; set; } = new();

	[XmlElement] public StandardOut StandardOut { get; set; } = new();
}