namespace Aigamo.Extensions.ErrorHandling.ArdalisResult.Extensions;

public static partial class ResultExtensions
{
	#region <T0, T1>

	public static Result<(T0, T1)> Combine<T0, T1>(
		this Result<T0> source,
		Func<T0, Result<T1>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<T0, (T0, T1)>();
		}

		var v0 = source.Value;
		var destResult = dest(v0);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T1, (T0, T1)>();
		}
		return Result.Success((v0, destResult.Value));
	}

	public static async Task<Result<(T0, T1)>> Combine<T0, T1>(
		this Task<Result<T0>> source,
		Func<T0, Result<T1>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1)>> Combine<T0, T1>(
		this Result<T0> source,
		Func<T0, Task<Result<T1>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<T0, (T0, T1)>();
		}

		var v0 = source.Value;
		var destResult = await dest(v0).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T1, (T0, T1)>();
		}
		return Result.Success((v0, destResult.Value));
	}

	public static async Task<Result<(T0, T1)>> Combine<T0, T1>(
		this Task<Result<T0>> source,
		Func<T0, Task<Result<T1>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2>

	public static Result<(T0, T1, T2)> Combine<T0, T1, T2>(
		this Result<(T0, T1)> source,
		Func<(T0, T1), Result<T2>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1), (T0, T1, T2)>();
		}

		var (v0, v1) = source.Value;
		var destResult = dest((v0, v1));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T2, (T0, T1, T2)>();
		}
		return Result.Success((v0, v1, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2)>> Combine<T0, T1, T2>(
		this Task<Result<(T0, T1)>> source,
		Func<(T0, T1), Result<T2>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2)>> Combine<T0, T1, T2>(
		this Result<(T0, T1)> source,
		Func<(T0, T1), Task<Result<T2>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1), (T0, T1, T2)>();
		}

		var (v0, v1) = source.Value;
		var destResult = await dest((v0, v1)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T2, (T0, T1, T2)>();
		}
		return Result.Success((v0, v1, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2)>> Combine<T0, T1, T2>(
		this Task<Result<(T0, T1)>> source,
		Func<(T0, T1), Task<Result<T2>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3>

	public static Result<(T0, T1, T2, T3)> Combine<T0, T1, T2, T3>(
		this Result<(T0, T1, T2)> source,
		Func<(T0, T1, T2), Result<T3>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2), (T0, T1, T2, T3)>();
		}

		var (v0, v1, v2) = source.Value;
		var destResult = dest((v0, v1, v2));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T3, (T0, T1, T2, T3)>();
		}
		return Result.Success((v0, v1, v2, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3)>> Combine<T0, T1, T2, T3>(
		this Task<Result<(T0, T1, T2)>> source,
		Func<(T0, T1, T2), Result<T3>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3)>> Combine<T0, T1, T2, T3>(
		this Result<(T0, T1, T2)> source,
		Func<(T0, T1, T2), Task<Result<T3>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2), (T0, T1, T2, T3)>();
		}

		var (v0, v1, v2) = source.Value;
		var destResult = await dest((v0, v1, v2)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T3, (T0, T1, T2, T3)>();
		}
		return Result.Success((v0, v1, v2, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3)>> Combine<T0, T1, T2, T3>(
		this Task<Result<(T0, T1, T2)>> source,
		Func<(T0, T1, T2), Task<Result<T3>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4>

	public static Result<(T0, T1, T2, T3, T4)> Combine<T0, T1, T2, T3, T4>(
		this Result<(T0, T1, T2, T3)> source,
		Func<(T0, T1, T2, T3), Result<T4>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3), (T0, T1, T2, T3, T4)>();
		}

		var (v0, v1, v2, v3) = source.Value;
		var destResult = dest((v0, v1, v2, v3));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T4, (T0, T1, T2, T3, T4)>();
		}
		return Result.Success((v0, v1, v2, v3, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4)>> Combine<T0, T1, T2, T3, T4>(
		this Task<Result<(T0, T1, T2, T3)>> source,
		Func<(T0, T1, T2, T3), Result<T4>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4)>> Combine<T0, T1, T2, T3, T4>(
		this Result<(T0, T1, T2, T3)> source,
		Func<(T0, T1, T2, T3), Task<Result<T4>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3), (T0, T1, T2, T3, T4)>();
		}

		var (v0, v1, v2, v3) = source.Value;
		var destResult = await dest((v0, v1, v2, v3)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T4, (T0, T1, T2, T3, T4)>();
		}
		return Result.Success((v0, v1, v2, v3, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4)>> Combine<T0, T1, T2, T3, T4>(
		this Task<Result<(T0, T1, T2, T3)>> source,
		Func<(T0, T1, T2, T3), Task<Result<T4>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5>

	public static Result<(T0, T1, T2, T3, T4, T5)> Combine<T0, T1, T2, T3, T4, T5>(
		this Result<(T0, T1, T2, T3, T4)> source,
		Func<(T0, T1, T2, T3, T4), Result<T5>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4), (T0, T1, T2, T3, T4, T5)>();
		}

		var (v0, v1, v2, v3, v4) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T5, (T0, T1, T2, T3, T4, T5)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5)>> Combine<T0, T1, T2, T3, T4, T5>(
		this Task<Result<(T0, T1, T2, T3, T4)>> source,
		Func<(T0, T1, T2, T3, T4), Result<T5>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5)>> Combine<T0, T1, T2, T3, T4, T5>(
		this Result<(T0, T1, T2, T3, T4)> source,
		Func<(T0, T1, T2, T3, T4), Task<Result<T5>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4), (T0, T1, T2, T3, T4, T5)>();
		}

		var (v0, v1, v2, v3, v4) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T5, (T0, T1, T2, T3, T4, T5)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5)>> Combine<T0, T1, T2, T3, T4, T5>(
		this Task<Result<(T0, T1, T2, T3, T4)>> source,
		Func<(T0, T1, T2, T3, T4), Task<Result<T5>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6>

	public static Result<(T0, T1, T2, T3, T4, T5, T6)> Combine<T0, T1, T2, T3, T4, T5, T6>(
		this Result<(T0, T1, T2, T3, T4, T5)> source,
		Func<(T0, T1, T2, T3, T4, T5), Result<T6>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5), (T0, T1, T2, T3, T4, T5, T6)>();
		}

		var (v0, v1, v2, v3, v4, v5) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T6, (T0, T1, T2, T3, T4, T5, T6)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6)>> Combine<T0, T1, T2, T3, T4, T5, T6>(
		this Task<Result<(T0, T1, T2, T3, T4, T5)>> source,
		Func<(T0, T1, T2, T3, T4, T5), Result<T6>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6)>> Combine<T0, T1, T2, T3, T4, T5, T6>(
		this Result<(T0, T1, T2, T3, T4, T5)> source,
		Func<(T0, T1, T2, T3, T4, T5), Task<Result<T6>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5), (T0, T1, T2, T3, T4, T5, T6)>();
		}

		var (v0, v1, v2, v3, v4, v5) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T6, (T0, T1, T2, T3, T4, T5, T6)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6)>> Combine<T0, T1, T2, T3, T4, T5, T6>(
		this Task<Result<(T0, T1, T2, T3, T4, T5)>> source,
		Func<(T0, T1, T2, T3, T4, T5), Task<Result<T6>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7)> Combine<T0, T1, T2, T3, T4, T5, T6, T7>(
		this Result<(T0, T1, T2, T3, T4, T5, T6)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6), Result<T7>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6), (T0, T1, T2, T3, T4, T5, T6, T7)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T7, (T0, T1, T2, T3, T4, T5, T6, T7)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6), Result<T7>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7>(
		this Result<(T0, T1, T2, T3, T4, T5, T6)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6), Task<Result<T7>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6), (T0, T1, T2, T3, T4, T5, T6, T7)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T7, (T0, T1, T2, T3, T4, T5, T6, T7)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6), Task<Result<T7>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7, T8>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8)> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7), Result<T8>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7), (T0, T1, T2, T3, T4, T5, T6, T7, T8)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6, v7));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T8, (T0, T1, T2, T3, T4, T5, T6, T7, T8)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7), Result<T8>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7), Task<Result<T8>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7), (T0, T1, T2, T3, T4, T5, T6, T7, T8)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6, v7)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T8, (T0, T1, T2, T3, T4, T5, T6, T7, T8)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7), Task<Result<T8>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8), Result<T9>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6, v7, v8));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T9, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8), Result<T9>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8), Task<Result<T9>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6, v7, v8)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T9, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8), Task<Result<T9>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9), Result<T10>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T10, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9), Result<T10>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9), Task<Result<T10>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T10, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9), Task<Result<T10>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), Result<T11>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T11, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), Result<T11>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), Task<Result<T11>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T11, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), Task<Result<T11>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), Result<T12>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T12, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), Result<T12>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), Task<Result<T12>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T12, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), Task<Result<T12>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), Result<T13>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T13, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), Result<T13>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), Task<Result<T13>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T13, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), Task<Result<T13>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), Result<T14>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T14, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), Result<T14>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), Task<Result<T14>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T14, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), Task<Result<T14>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion

	#region <T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>

	public static Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), Result<T15>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14) = source.Value;
		var destResult = dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14));
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T15, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), Result<T15>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return sourceResult.Combine(dest);
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
		this Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), Task<Result<T15>>> dest
	)
	{
		if (source.IsNotSuccess())
		{
			return source.HandleNonSuccessStatus<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>();
		}

		var (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14) = source.Value;
		var destResult = await dest((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14)).ConfigureAwait(false);
		if (destResult.IsNotSuccess())
		{
			return destResult.HandleNonSuccessStatus<T15, (T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>();
		}
		return Result.Success((v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, destResult.Value));
	}

	public static async Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>> Combine<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
		this Task<Result<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>> source,
		Func<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), Task<Result<T15>>> dest
	)
	{
		var sourceResult = await source.ConfigureAwait(false);
		return await Combine(sourceResult, dest).ConfigureAwait(false);
	}

	#endregion
}
