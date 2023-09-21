using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("StdOut")]
public sealed class StandardOut
{
	[XmlText] public string Value { get; set; } = string.Empty;
}