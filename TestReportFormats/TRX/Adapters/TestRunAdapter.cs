using System.Collections.Immutable;

namespace YamTestReporter.Reports.TRX.Adapters;

public sealed class TestRunAdapter
{
	private readonly TestRun _testRun;

	private readonly IDictionary<(string codeBase, string AdapterTypeName, string ClassName, string Name), TestAdapter>
		_testAdapters;

	public TestRunAdapter(TestRun testRun)
	{
		_testRun = testRun;

		_testAdapters =
			new Dictionary<(string codeBase, string AdapterTypeName, string ClassName, string Name), TestAdapter>();

		var testRestsByExecutionId = testRun
			.Results
			.GroupBy(result => result.ExecutionId)
			.ToImmutableSortedDictionary(results => results.Key, results => results.ToImmutableArray());

		foreach (var test in _testRun.TestDefinitions)
		{
			var (codeBase, adapterTypeName, className, name) = test.TestMethod;
			var testResults = testRestsByExecutionId[test.Execution.Id];

			if (_testAdapters.TryGetValue((codeBase, adapterTypeName, className, name), out var testAdapter))
			{
				testAdapter.AddUnitTest(test, testResults);
			}
			else
			{
				testAdapter = new TestAdapter(test, testResults);

				_testAdapters[(codeBase, adapterTypeName, className, name)] = testAdapter;
			}
		}
	}
}