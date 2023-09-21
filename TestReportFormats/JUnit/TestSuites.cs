using System.Xml.Serialization;

namespace YamTestReporter.Reports.JUnit;

[XmlRoot("testsuites")]
public sealed class TestSuites
{
	[XmlElement("testsuite")] public TestSuite[] Suites { get; set; } = Array.Empty<TestSuite>();
}