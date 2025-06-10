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
		return result.Status switch
		{
			ResultStatus.NotFound => result.Errors.Any()
				? Result<TDestination>.NotFound([.. result.Errors])
				: Result<TDestination>.NotFound(),
			ResultStatus.Unauthorized => result.Errors.Any()
				? Result<TDestination>.Unauthorized([.. result.Errors])
				: Result<TDestination>.Unauthorized(),
			ResultStatus.Forbidden => result.Errors.Any()
				? Result<TDestination>.Forbidden([.. result.Errors])
				: Result<TDestination>.Forbidden(),
			ResultStatus.Invalid => Result<TDestination>.Invalid(result.ValidationErrors),
			ResultStatus.Error => Result<TDestination>.Error(new ErrorList([.. result.Errors], result.CorrelationId)),
			ResultStatus.Conflict => result.Errors.Any()
				? Result<TDestination>.Conflict([.. result.Errors])
				: Result<TDestination>.Conflict(),
			ResultStatus.CriticalError => Result<TDestination>.CriticalError([.. result.Errors]),
			ResultStatus.Unavailable => Result<TDestination>.Unavailable([.. result.Errors]),
			ResultStatus.NoContent => Result<TDestination>.NoContent(),
			_ => throw new NotSupportedException(
				$"Result {result.Status} conversion is not supported."
			),
		};
	}

	private static Result<TDestination> HandleNonSuccessStatus<TDestination>(this Result result)
	{
		return result.Status switch
		{
			ResultStatus.NotFound => result.Errors.Any()
				? Result<TDestination>.NotFound([.. result.Errors])
				: Result<TDestination>.NotFound(),
			ResultStatus.Unauthorized => result.Errors.Any()
				? Result<TDestination>.Unauthorized([.. result.Errors])
				: Result<TDestination>.Unauthorized(),
			ResultStatus.Forbidden => result.Errors.Any()
				? Result<TDestination>.Forbidden([.. result.Errors])
				: Result<TDestination>.Forbidden(),
			ResultStatus.Invalid => Result<TDestination>.Invalid(result.ValidationErrors),
			ResultStatus.Error => Result<TDestination>.Error(new ErrorList([.. result.Errors], result.CorrelationId)),
			ResultStatus.Conflict => result.Errors.Any()
				? Result<TDestination>.Conflict([.. result.Errors])
				: Result<TDestination>.Conflict(),
			ResultStatus.CriticalError => Result<TDestination>.CriticalError([.. result.Errors]),
			ResultStatus.Unavailable => Result<TDestination>.Unavailable([.. result.Errors]),
			ResultStatus.NoContent => Result<TDestination>.NoContent(),
			_ => throw new NotSupportedException(
				$"Result {result.Status} conversion is not supported."
			),
		};
	}

	private static Result HandleNonSuccessStatus<TSource>(this Result<TSource> result)
	{
		return result.Status switch
		{
			ResultStatus.NotFound => result.Errors.Any()
				? Result.NotFound([.. result.Errors])
				: Result.NotFound(),
			ResultStatus.Unauthorized => result.Errors.Any()
				? Result.Unauthorized([.. result.Errors])
				: Result.Unauthorized(),
			ResultStatus.Forbidden => result.Errors.Any()
				? Result.Forbidden([.. result.Errors])
				: Result.Forbidden(),
			ResultStatus.Invalid => Result.Invalid(result.ValidationErrors),
			ResultStatus.Error => Result.Error(new ErrorList([.. result.Errors], result.CorrelationId)),
			ResultStatus.Conflict => result.Errors.Any()
				? Result.Conflict([.. result.Errors])
				: Result.Conflict(),
			ResultStatus.CriticalError => Result.CriticalError([.. result.Errors]),
			ResultStatus.Unavailable => Result.Unavailable([.. result.Errors]),
			ResultStatus.NoContent => Result.NoContent(),
			_ => throw new NotSupportedException(
				$"Result {result.Status} conversion is not supported."
			),
		};
	}
}
