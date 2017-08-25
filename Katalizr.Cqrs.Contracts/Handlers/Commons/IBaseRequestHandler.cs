using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commons
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  public interface IBaseRequestHandler<in TRequest> where TRequest : IRequest
  {
  }

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface IBaseRequestHandler<in TRequest, out TResponse> where TRequest : IRequest<TResponse>
  {
  }
}
