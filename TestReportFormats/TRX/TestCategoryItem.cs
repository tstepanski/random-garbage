using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("TestCategoryItem")]
public sealed class TestCategoryItem
{
	[XmlAttribute("TestCategory")] public string TestCategory { get; set; } = string.Empty;
}