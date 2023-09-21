using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("ResultSummary")]
public sealed class ResultSummary
{
	[XmlAttribute("outcome")] public Outcome Outcome { get; set; }

	[XmlElement] public Counters Counters { get; set; } = new();

	[XmlElement] public Output Output { get; set; } = new();

	[XmlArray("RunInfos")] public RunInfo[] RunsInformation { get; set; } = Array.Empty<RunInfo>();
}