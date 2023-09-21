using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlRoot("TestRun", Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable = false)]
public sealed class TestRun
{
	[XmlAttribute("id")] public Guid Id { get; set; }

	[XmlAttribute("name")] public string Name { get; set; } = string.Empty;

	[XmlAttribute("runUser")] public string RunUser { get; set; } = string.Empty;

	[XmlElement] public Times Times { get; set; } = new();

	[XmlArray("Results")] public UnitTestResult[] Results { get; set; } = Array.Empty<UnitTestResult>();

	[XmlArray("TestDefinitions")] public UnitTest[] TestDefinitions { get; set; } = Array.Empty<UnitTest>();

	[XmlArray("TestEntries")] public TestEntry[] TestEntries { get; set; } = Array.Empty<TestEntry>();

	[XmlArray("TestLists")] public TestList[] TestLists { get; set; } = Array.Empty<TestList>();

	[XmlElement] public ResultSummary ResultSummary { get; set; } = new();
}