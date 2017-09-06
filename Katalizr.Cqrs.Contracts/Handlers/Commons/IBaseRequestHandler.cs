using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commons
{
  /// <summary>
  /// Represents the base request handler, that handle <see cref="IRequest"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest"/>.</typeparam>
  public interface IBaseRequestHandler<in TRequest> where TRequest : IRequest
  {
  }

  /// <summary>
  /// Represents the base request handler, that handle <see cref="IRequest{TResponse}"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the response.</typeparam>
  public interface IBaseRequestHandler<in TRequest, out TResponse> where TRequest : IRequest<TResponse>
  {
  }
}
