namespace Aigamo.Extensions.ErrorHandling.ArdalisResult.Extensions;

public static partial class ResultExtensions
{
	public static Result Tap(this Result source, Action ok)
	{
		if (source.IsSuccess)
		{
			ok();
		}
		return source;
	}

	public static async Task<Result> Tap(this Task<Result> source, Action ok)
	{
		var result = await source.ConfigureAwait(false);
		if (result.IsSuccess)
		{
			ok();
		}
		return result;
	}

	public static async Task<Result> Tap(this Result source, Func<Task> ok)
	{
		if (source.IsSuccess)
		{
			await ok().ConfigureAwait(false);
		}
		return source;
	}

	public static async Task<Result> Tap(this Task<Result> source, Func<Task> ok)
	{
		var result = await source.ConfigureAwait(false);
		if (result.IsSuccess)
		{
			await ok().ConfigureAwait(false);
		}
		return result;
	}
}
