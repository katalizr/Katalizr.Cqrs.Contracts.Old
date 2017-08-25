namespace Katalizr.Cqrs.Contracts.Models
{
  /// <summary>
  /// Represents a request
  /// </summary>
  public interface IRequest
  {
  }

  /// <inheritdoc />
  /// <summary>
  /// Represents a request with an expected response.
  /// </summary>
  /// <typeparam name="TResponse"></typeparam>
  public interface IRequest<out TResponse> : IRequest
  {
  }
}
