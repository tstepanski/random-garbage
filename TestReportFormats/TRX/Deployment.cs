using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

[XmlType("Deployment")]
public sealed class Deployment
{
	[XmlAttribute("runDeploymentRoot")] public string RunDeploymentRoot { get; set; } = string.Empty;
}