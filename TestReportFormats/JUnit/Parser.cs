using System.Xml.Serialization;
using YamTestReporter.Reports.Generic;

namespace YamTestReporter.Reports.JUnit;

public sealed class Parser : IParser<TestSuites>
{
	private readonly XmlSerializer _serializer = new(typeof(TestSuites));

	public TestSuites Parse(Stream stream)
	{
		return _serializer.Deserialize(stream) as TestSuites ??
		       throw new InvalidOperationException("Failed to deserialize report");
	}
}