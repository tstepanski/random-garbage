using System.Xml.Serialization;

namespace YamTestReporter.Reports.JUnit;

public sealed class Report
{
	[XmlAttribute("message")] public string Message { get; set; } = string.Empty;

	[XmlAttribute("type")] public string Type { get; set; } = string.Empty;
}