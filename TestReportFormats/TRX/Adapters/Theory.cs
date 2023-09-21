namespace YamTestReporter.Reports.TRX.Adapters;

public sealed class Theory : AbstractUnitTestExecutionAdapter
{
	public Theory(UnitTest unitTest, string data, IEnumerable<UnitTestResult> results) : base(unitTest, results)
	{
		Data = data;
	}

	public string Data { get; }
}