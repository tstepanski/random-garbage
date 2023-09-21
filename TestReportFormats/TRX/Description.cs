using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("Description")]
public sealed class Description
{
	[XmlText] public string Value { get; set; } = string.Empty;
}