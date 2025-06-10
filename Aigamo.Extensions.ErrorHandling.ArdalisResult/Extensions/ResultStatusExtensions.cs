using Ardalis.Result;

namespace Aigamo.Extensions.ErrorHandling.ArdalisResult.Extensions;

internal static class ResultStatusExtensions
{
	public static U MatchNonSuccessStatus<U>(
		this ResultStatus status,
		Func<U> onNotFound,
		Func<U> onUnauthorized,
		Func<U> onForbidden,
		Func<U> onInvalid,
		Func<U> onError,
		Func<U> onConflict,
		Func<U> onCriticalError,
		Func<U> onUnavailable,
		Func<U> onNoContent
	)
	{
		return status switch
		{
			ResultStatus.NotFound => onNotFound(),
			ResultStatus.Unauthorized => onUnauthorized(),
			ResultStatus.Forbidden => onForbidden(),
			ResultStatus.Invalid => onInvalid(),
			ResultStatus.Error => onError(),
			ResultStatus.Conflict => onConflict(),
			ResultStatus.CriticalError => onCriticalError(),
			ResultStatus.Unavailable => onUnavailable(),
			ResultStatus.NoContent => onNoContent(),
			_ => throw new NotSupportedException($"Result {status} conversion is not supported."),
		};
	}
}
