using System.Xml.Serialization;
using YamTestReporter.Reports.Generic;

namespace YamTestReporter.Reports.TRX;

public sealed class Parser : IParser<TestRun>
{
	private readonly XmlSerializer _serializer = new(typeof(TestRun));

	public TestRun Parse(Stream stream)
	{
		return _serializer.Deserialize(stream) as TestRun ??
		       throw new InvalidOperationException("Failed to deserialize report");
	}
}