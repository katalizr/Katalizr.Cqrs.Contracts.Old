using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commons
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface IAsynchronousRequestHandler<TRequest, TResponse> : IBaseRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
  {
    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<TResponse> Handle(TRequest request);
  }

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  public interface IAsynchronousRequestHandler<TRequest> : IBaseRequestHandler<TRequest> where TRequest : IRequest
  {
    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task Handle(TRequest request);
  }
}
