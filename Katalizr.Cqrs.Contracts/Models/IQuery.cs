namespace Katalizr.Cqrs.Contracts.Models
{

  /// <inheritdoc />
  /// <summary>
  /// Represents a query with an expected response.
  /// </summary>
  /// <typeparam name="TResponse"></typeparam>
  public interface IQuery<out TResponse> : IRequest<TResponse>
  {
  }
}
