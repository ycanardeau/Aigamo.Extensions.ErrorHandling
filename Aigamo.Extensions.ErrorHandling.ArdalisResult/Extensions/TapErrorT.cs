namespace Aigamo.Extensions.ErrorHandling.ArdalisResult.Extensions;

public static partial class ResultExtensions
{
	public static Result<T> TapError<T>(this Result<T> source, Action/* TODO: <> */ error)
	{
		if (source.IsNotSuccess())
		{
			error();
		}
		return source;
	}

	public static async Task<Result<T>> TapError<T>(this Task<Result<T>> source, Action/* TODO: <> */ error)
	{
		var result = await source.ConfigureAwait(false);
		if (result.IsNotSuccess())
		{
			error();
		}
		return result;
	}

	public static async Task<Result<T>> TapError<T>(this Result<T> source, Func<Task>/* TODO: <> */ error)
	{
		if (source.IsNotSuccess())
		{
			await error().ConfigureAwait(false);
		}
		return source;
	}

	public static async Task<Result<T>> TapError<T>(this Task<Result<T>> source, Func<Task>/* TODO: <> */ error)
	{
		var result = await source.ConfigureAwait(false);
		if (result.IsNotSuccess())
		{
			await error().ConfigureAwait(false);
		}
		return result;
	}
}
