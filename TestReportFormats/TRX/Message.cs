using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("Message")]
public sealed class Message
{
	[XmlText] public string Value { get; set; } = string.Empty;
}