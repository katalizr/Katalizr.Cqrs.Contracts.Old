using System.Threading;
using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commons
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface IAsynchronousCancellableRequestHandler<TRequest, TResponse> : IBaseRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
  {
    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
  }

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  public interface IAsynchronousCancellableRequestHandler<TRequest> : IBaseRequestHandler<TRequest> where TRequest : IRequest
  {
    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task Handle(TRequest request, CancellationToken cancellationToken);
  }
}
