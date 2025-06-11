using Ardalis.Result;

namespace Aigamo.Extensions.ErrorHandling.ArdalisResult.Extensions;

public static partial class ResultExtensions
{
	public static Result<T> Tap<T>(this Result<T> source, Action<T> ok)
	{
		if (source.IsSuccess)
		{
			ok(source.Value);
		}
		return source;
	}

	public static async Task<Result<T>> Tap<T>(this Task<Result<T>> source, Action<T> ok)
	{
		var result = await source.ConfigureAwait(false);
		if (result.IsSuccess)
		{
			ok(result.Value);
		}
		return result;
	}

	public static async Task<Result<T>> Tap<T>(this Result<T> source, Func<T, Task> ok)
	{
		if (source.IsSuccess)
		{
			await ok(source.Value).ConfigureAwait(false);
		}
		return source;
	}

	public static async Task<Result<T>> Tap<T>(this Task<Result<T>> source, Func<T, Task> ok)
	{
		var result = await source.ConfigureAwait(false);
		if (result.IsSuccess)
		{
			await ok(result.Value).ConfigureAwait(false);
		}
		return result;
	}
}
