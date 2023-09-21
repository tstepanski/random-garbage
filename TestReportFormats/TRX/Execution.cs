using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("Execution")]
public sealed class Execution
{
	[XmlAttribute("id")] public Guid Id { get; set; }
}