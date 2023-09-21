using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("ErrorInfo")]
public sealed class ErrorInformation
{
	[XmlElement] public Message Message { get; set; } = new();

	[XmlElement] public StackTrace StackTrace { get; set; } = new();
}