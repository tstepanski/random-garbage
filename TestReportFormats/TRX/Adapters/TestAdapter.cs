using System.Collections;
using System.Text.RegularExpressions;

namespace YamTestReporter.Reports.TRX.Adapters;

public sealed partial class TestAdapter : IEnumerable<AbstractUnitTestExecutionAdapter>
{
	private static readonly Regex TheoremRegex = TheoremRegexFactory();

	private readonly IList<AbstractUnitTestExecutionAdapter> _testExecutionAdapters;

	public TestAdapter(UnitTest unitTest, IEnumerable<UnitTestResult> results)
	{
		(CodeBase, AdapterTypeName, ClassName, Name) = unitTest.TestMethod;

		_testExecutionAdapters = new List<AbstractUnitTestExecutionAdapter>();

		AddUnitTest(unitTest, results);
	}

	public string CodeBase { get; }

	public string AdapterTypeName { get; }

	public string ClassName { get; }

	public string Name { get; }

	public void AddUnitTest(UnitTest unitTest, IEnumerable<UnitTestResult> results)
	{
		var match = TheoremRegex.Match(unitTest.Name);
		AbstractUnitTestExecutionAdapter adapter;

		if (match.Success)
		{
			adapter = new Theory(unitTest, match.Groups[1].Value, results);
		}
		else
		{
			adapter = new Fact(unitTest, results);
		}

		_testExecutionAdapters.Add(adapter);
	}

	public IEnumerator<AbstractUnitTestExecutionAdapter> GetEnumerator()
	{
		return _testExecutionAdapters.GetEnumerator();
	}

	public override int GetHashCode()
	{
		var codeBaseHashCode = CodeBase.GetHashCode(StringComparison.Ordinal);
		var adapterTypeNameHashCode = AdapterTypeName.GetHashCode(StringComparison.Ordinal);
		var classNameHashCode = ClassName.GetHashCode(StringComparison.Ordinal);
		var nameHashCode = Name.GetHashCode(StringComparison.Ordinal);

		return HashCode.Combine(codeBaseHashCode, adapterTypeNameHashCode, classNameHashCode, nameHashCode);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

    [GeneratedRegex("\\\\((.+)\\\\)", RegexOptions.Compiled)]
    private static partial Regex TheoremRegexFactory();
}