using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("UnitTestResult")]
public sealed class UnitTestResult
{
	[XmlAttribute("executionId")] public Guid ExecutionId { get; set; }

	[XmlAttribute("testId")] public Guid TestId { get; set; }

	[XmlAttribute("testName")] public string TestName { get; set; } = string.Empty;

	[XmlAttribute("computerName")] public string ComputerName { get; set; } = string.Empty;

	[XmlAttribute("duration")] public string DurationString { get; set; } = string.Empty;

	[XmlAttribute("startTime")] public DateTime StartTime { get; set; }

	[XmlAttribute("endTime")] public DateTime EndTime { get; set; }

	[XmlAttribute("testType")] public Guid TestType { get; set; }

	[XmlAttribute("outcome")] public Outcome Outcome { get; set; }

	[XmlAttribute("testListId")] public Guid TestListId { get; set; }

	[XmlAttribute("relativeResultsDirectory")]
	public Guid RelativeResultsDirectory { get; set; }

	[XmlElement] public Output Output { get; set; } = new();

	[XmlIgnore]
	public TimeSpan Duration
	{
		get => string.IsNullOrWhiteSpace(DurationString) ? TimeSpan.Zero : TimeSpan.Parse(DurationString);
		set => DurationString = value.ToString();
	}
}