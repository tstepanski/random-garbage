using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("UnitTest")]
public sealed class UnitTest
{
	[XmlAttribute("name")] public string Name { get; set; } = string.Empty;

	[XmlAttribute("storage")] public string Storage { get; set; } = string.Empty;

	[XmlAttribute("id")] public Guid Id { get; set; }

	[XmlElement] public Execution Execution { get; set; } = new();

	[XmlElement] public TestMethod TestMethod { get; set; } = new();

	[XmlElement] public Description Description { get; set; } = new();

	[XmlElement("Owner")] public Owner[] Owners { get; set; } = Array.Empty<Owner>();

	[XmlArray("TestCategory", IsNullable = true)]
	public TestCategoryItem[] TestCategory { get; set; } = Array.Empty<TestCategoryItem>();
}