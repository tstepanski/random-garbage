namespace YamTestReporter.Reports.TRX.Adapters;

public sealed class Fact : AbstractUnitTestExecutionAdapter
{
	public Fact(UnitTest unitTest, IEnumerable<UnitTestResult> results) : base(unitTest, results)
	{
	}
}