namespace YamTestReporter.Reports.Generic;

public interface IParser<out T> where T : notnull
{
	T Parse(Stream stream);
}