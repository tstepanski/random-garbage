using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("StackTrace")]
public sealed class StackTrace
{
	[XmlText] public string Value { get; set; } = string.Empty;
}