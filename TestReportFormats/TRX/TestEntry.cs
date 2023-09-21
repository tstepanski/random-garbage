using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("TestEntry")]
public sealed class TestEntry
{
	[XmlAttribute("testId")] public Guid TestId { get; set; }

	[XmlAttribute("executionId")] public Guid ExecutionId { get; set; }

	[XmlAttribute("testListId")] public Guid TestListId { get; set; }
}