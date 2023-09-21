using System.Collections;
using System.Collections.Immutable;

namespace YamTestReporter.Reports.TRX.Adapters;

public abstract class AbstractUnitTestExecutionAdapter : IEnumerable<UnitTestResult>
{
	private readonly IImmutableList<UnitTestResult> _results;

	protected AbstractUnitTestExecutionAdapter(UnitTest unitTest, IEnumerable<UnitTestResult> results)
	{
		_results = results.ToImmutableArray();
		
		UnitTest = unitTest;
	}

	public UnitTest UnitTest { get; }

	public IEnumerator<UnitTestResult> GetEnumerator()
	{
		return _results.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}