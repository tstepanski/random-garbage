using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("Owner")]
public sealed class Owner
{
	[XmlText] public string Value { get; set; } = string.Empty;
}