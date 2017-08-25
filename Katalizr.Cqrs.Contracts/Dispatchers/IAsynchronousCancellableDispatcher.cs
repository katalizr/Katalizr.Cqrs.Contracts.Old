using System.Threading;
using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Dispatchers
{
  /// <summary>
  /// Represents an asynchronous cancellable dispatcher
  /// </summary>
  public interface IAsynchronousCancellableDispatcher
  {
    /// <summary>
    /// Dispatches a request to the appropriate handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <param name="cancellationToken">The CancellationToken that will be assigned to the new continuation task.</param>
    /// <typeparam name="TRequest"></typeparam>
    /// <returns></returns>
    Task Dispatch<TRequest>(TRequest request, CancellationToken cancellationToken) where TRequest : IRequest;

    /// <summary>
    /// Dispatches a request to the appropriate handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <param name="cancellationToken">The CancellationToken that will be assigned to the new continuation task.</param>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    /// <returns></returns>
    Task<TResponse> Dispatch<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken) where TRequest : IRequest<TResponse>;
  }
}
