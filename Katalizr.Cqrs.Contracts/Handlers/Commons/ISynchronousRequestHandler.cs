using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commons
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  public interface ISynchronousRequestHandler<TRequest>: IBaseRequestHandler<TRequest> where TRequest : IRequest
  {
    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    void Handle(TRequest request);
  }

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface ISynchronousRequestHandler<TRequest, TResponse>: IBaseRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
  {
    /// <summary>
    ///
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    TResponse Handle(TRequest query);
  }
}
