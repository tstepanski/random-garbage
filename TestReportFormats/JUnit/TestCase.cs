using System.Xml.Serialization;

namespace YamTestReporter.Reports.JUnit;

[XmlType("testcase")]
public sealed class TestCase
{
	[XmlAttribute("name")] public string Name { get; set; } = string.Empty;

	[XmlAttribute("classname")] public string ClassName { get; set; } = string.Empty;

	[XmlAttribute("time")] public double TimeSeconds { get; set; }

	[XmlElement("failure", IsNullable = true)] public Report? Failure { get; set; }

	[XmlElement("errror", IsNullable = true)] public Report? Error { get; set; }

	[XmlElement("skipped", IsNullable = true)] public Report? Skipped { get; set; }

	[XmlIgnore]
	public TimeSpan Time
	{
		get => TimeSpan.FromSeconds(TimeSeconds);
		set => TimeSeconds = value.TotalSeconds;
	}
}