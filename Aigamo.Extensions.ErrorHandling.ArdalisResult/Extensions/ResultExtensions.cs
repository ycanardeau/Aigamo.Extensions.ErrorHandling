using Ardalis.Result;

namespace Aigamo.Extensions.ErrorHandling.ArdalisResult.Extensions;

public static partial class ResultExtensions
{
	// TODO: Convert to a property.
	private static bool IsNotSuccess<T>(this Result<T> source)
	{
		return !source.IsSuccess;
	}

	private static Result<TDestination> HandleNonSuccessStatus<TSource, TDestination>(this Result<TSource> result)
	{
		return result.Status.MatchNonSuccessStatus(
			onNotFound: () => result.Errors.Any()
				? Result<TDestination>.NotFound([.. result.Errors])
				: Result<TDestination>.NotFound(),
			onUnauthorized: () => result.Errors.Any()
				? Result<TDestination>.Unauthorized([.. result.Errors])
				: Result<TDestination>.Unauthorized(),
			onForbidden: () => result.Errors.Any()
				? Result<TDestination>.Forbidden([.. result.Errors])
				: Result<TDestination>.Forbidden(),
			onInvalid: () => Result<TDestination>.Invalid(result.ValidationErrors),
			onError: () => Result<TDestination>.Error(new ErrorList([.. result.Errors], result.CorrelationId)),
			onConflict: () => result.Errors.Any()
				? Result<TDestination>.Conflict([.. result.Errors])
				: Result<TDestination>.Conflict(),
			onCriticalError: () => Result<TDestination>.CriticalError([.. result.Errors]),
			onUnavailable: () => Result<TDestination>.Unavailable([.. result.Errors]),
			onNoContent: () => Result<TDestination>.NoContent()
		);
	}

	private static Result<TDestination> HandleNonSuccessStatus<TDestination>(this Result result)
	{
		return result.Status.MatchNonSuccessStatus(
			onNotFound: () => result.Errors.Any()
				? Result<TDestination>.NotFound([.. result.Errors])
				: Result<TDestination>.NotFound(),
			onUnauthorized: () => result.Errors.Any()
				? Result<TDestination>.Unauthorized([.. result.Errors])
				: Result<TDestination>.Unauthorized(),
			onForbidden: () => result.Errors.Any()
				? Result<TDestination>.Forbidden([.. result.Errors])
				: Result<TDestination>.Forbidden(),
			onInvalid: () => Result<TDestination>.Invalid(result.ValidationErrors),
			onError: () => Result<TDestination>.Error(new ErrorList([.. result.Errors], result.CorrelationId)),
			onConflict: () => result.Errors.Any()
				? Result<TDestination>.Conflict([.. result.Errors])
				: Result<TDestination>.Conflict(),
			onCriticalError: () => Result<TDestination>.CriticalError([.. result.Errors]),
			onUnavailable: () => Result<TDestination>.Unavailable([.. result.Errors]),
			onNoContent: () => Result<TDestination>.NoContent()
		);
	}

	private static Result HandleNonSuccessStatus<TSource>(this Result<TSource> result)
	{
		return result.Status.MatchNonSuccessStatus(
			onNotFound: () => result.Errors.Any()
				? Result.NotFound([.. result.Errors])
				: Result.NotFound(),
			onUnauthorized: () => result.Errors.Any()
				? Result.Unauthorized([.. result.Errors])
				: Result.Unauthorized(),
			onForbidden: () => result.Errors.Any()
				? Result.Forbidden([.. result.Errors])
				: Result.Forbidden(),
			onInvalid: () => Result.Invalid(result.ValidationErrors),
			onError: () => Result.Error(new ErrorList([.. result.Errors], result.CorrelationId)),
			onConflict: () => result.Errors.Any()
				? Result.Conflict([.. result.Errors])
				: Result.Conflict(),
			onCriticalError: () => Result.CriticalError([.. result.Errors]),
			onUnavailable: () => Result.Unavailable([.. result.Errors]),
			onNoContent: () => Result.NoContent()
		);
	}
}
