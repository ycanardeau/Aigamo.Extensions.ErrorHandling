using Ardalis.Result;

namespace Aigamo.Extensions.ErrorHandling.ArdalisResult.Extensions;

public static partial class ResultExtensions
{
	public static Task<Result<T>> AsTask<T>(this Result<T> source) => Task.FromResult(source);
}
