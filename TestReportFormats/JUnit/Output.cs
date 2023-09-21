using System.Xml.Serialization;

namespace YamTestReporter.Reports.JUnit;

public sealed class Output
{
	[XmlText] public string Value { get; set; } = string.Empty;
}