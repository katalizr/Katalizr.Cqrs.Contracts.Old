using System;
using System.Threading;
using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Models;
using Katalizr.Cqrs.Contracts.Exceptions;

namespace Katalizr.Cqrs.Contracts.Dispatchers
{
  /// <summary>
  /// Represents an asynchronous dispatcher.
  /// </summary>
  public interface IAsynchronousDispatcher
  {
    /// <summary>
    /// Dispatches a request to the appropriate handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <typeparam name="TRequest">The type of the request. Must inherits from <see cref="IRequest"/>.</typeparam>
    /// <returns>A task that represents the asynchronous dispatch operation.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="NoHandlerFoundException">No handler has been found for the request.</exception>
    /// <exception cref="MultipleHandlerFoundException">Too many handler has been found for the request.</exception>
    Task Dispatch<TRequest>(TRequest request) where TRequest : IRequest;

    /// <summary>
    /// Dispatches a request to the appropriate handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <typeparam name="TRequest">The type of the request. Must inherits from <see cref="IRequest{T}"/>.</typeparam>
    /// <typeparam name="TResponse"></typeparam>
    /// <returns>A task that represents the asynchronous dispatch operation.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="NoHandlerFoundException">No handler has been found for the request.</exception>
    /// <exception cref="MultipleHandlerFoundException">Too many handler has been found for the request.</exception>
    Task<TResponse> Dispatch<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>;

    /// <summary>
    /// Dispatches a request to the appropriate handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <param name="cancellationToken">The CancellationToken that will be assigned to the new continuation task.</param>
    /// <typeparam name="TRequest">The type of the request. Must inherits from <see cref="IRequest"/>.</typeparam>
    /// <returns>A task that represents the asynchronous dispatch operation.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="NoHandlerFoundException">No handler has been found for the request.</exception>
    /// <exception cref="MultipleHandlerFoundException">Too many handler has been found for the request.</exception>
    /// <exception cref="OperationCanceledException">The token has had cancellation requested.</exception>
    Task Dispatch<TRequest>(TRequest request, CancellationToken cancellationToken) where TRequest : IRequest;

    /// <summary>
    /// Dispatches a request to the appropriate handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <param name="cancellationToken">The CancellationToken that will be assigned to the new continuation task.</param>
    /// <typeparam name="TRequest">The type of the request. Must inherits from <see cref="IRequest{T}"/>.</typeparam>
    /// <typeparam name="TResponse">The type of the response. Must inherits</typeparam>
    /// <returns>A task that represents the asynchronous dispatch operation.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="NoHandlerFoundException">No handler has been found for the request.</exception>
    /// <exception cref="MultipleHandlerFoundException">Too many handler has been found for the request.</exception>
    /// <exception cref="OperationCanceledException">The token has had cancellation requested.</exception>
    Task<TResponse> Dispatch<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken) where TRequest : IRequest<TResponse>;
  }
}
