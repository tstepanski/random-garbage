using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("TestMethod")]
public sealed class TestMethod
{
	[XmlAttribute("codeBase")] public string CodeBase { get; set; } = string.Empty;

	[XmlAttribute("adapterTypeName")] public string AdapterTypeName { get; set; } = string.Empty;

	[XmlAttribute("className")] public string ClassName { get; set; } = string.Empty;

	[XmlAttribute("name")] public string Name { get; set; } = string.Empty;

	public void Deconstruct(out string codeBase, out string adapterTypeName, out string className, out string name)
	{
		codeBase = CodeBase;
		adapterTypeName = AdapterTypeName;
		className = ClassName;
		name = Name;
	}
}