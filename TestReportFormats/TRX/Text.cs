using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("Text")]
public sealed class Text
{
	[XmlText] public string Value { get; set; } = string.Empty;
}