using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("RunInfo")]
public sealed class RunInfo
{
	[XmlAttribute("ComputerName")] public string ComputerName { get; set; } = string.Empty;

	[XmlAttribute("outcome")] public string Outcome { get; set; } = string.Empty;

	[XmlAttribute("timestamp")] public DateTime TimeStamp { get; set; }

	[XmlElement] public Text Text { get; set; } = new();
}