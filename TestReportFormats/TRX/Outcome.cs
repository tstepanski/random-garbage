using System.Xml.Serialization;

namespace YamTestReporter.Reports.TRX;

public enum Outcome : byte
{
	[XmlEnum("Failed")] Failed,
	[XmlEnum("Inconclusive")] Inconclusive,
	[XmlEnum("Passed")] Passed,
	[XmlEnum("InProgress")] InProgress,
	[XmlEnum("Error")] Error,
	[XmlEnum("Timeout")] Timeout,
	[XmlEnum("Aborted")] Aborted,
	[XmlEnum("Unknown")] Unknown,
	[XmlEnum("NotRunnable")] NotRunnable
}