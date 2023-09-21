using System.Xml.Serialization;

namespace YamTestReporter.Reports.JUnit;

[XmlType("testsuite")]
public sealed class TestSuite
{
	[XmlAttribute("name")] public string Name { get; set; } = string.Empty;

	[XmlAttribute("tests")] public int Tests { get; set; }

	[XmlAttribute("skipped")] public int Skipped { get; set; }

	[XmlAttribute("failures")] public int Failures { get; set; }

	[XmlAttribute("errors")] public int Errors { get; set; }

	[XmlAttribute("time")] public double TimeSeconds { get; set; }

	[XmlAttribute("hostname")] public string HostName { get; set; } = string.Empty;

	[XmlAttribute("id")] public string Id { get; set; } = string.Empty;

	[XmlAttribute("package")] public string Package { get; set; } = string.Empty;

	[XmlArray("properties")] public Property[] Properties { get; set; } = Array.Empty<Property>();

	[XmlElement("testcase")] public TestCase[] TestCases { get; set; } = Array.Empty<TestCase>();

	[XmlElement("system-out")] public Output StandardOut { get; set; } = new();

	[XmlElement("system-err")] public Output StandardError { get; set; } = new();

	[XmlIgnore]
	public TimeSpan Time
	{
		get => TimeSpan.FromSeconds(TimeSeconds);
		set => TimeSeconds = value.TotalSeconds;
	}
}