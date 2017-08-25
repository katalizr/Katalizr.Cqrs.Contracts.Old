using System;
using System.Threading;
using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commons
{
  /// <summary>
  /// Represents an asynchronous request handler, that handle <see cref="IRequest{TResponse}"/>. Inherits from <see cref="IBaseRequestHandler{TRequest,TResponse}"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the response.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="IBaseRequestHandler{TRequest,TResponse}"/>
  public interface IAsynchronousRequestHandler<in TRequest, TResponse> : IBaseRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
  {
    /// <summary>
    /// Handles the request with the appropriate handler and return the associated result.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <returns>Returns a task representing the result of the processing of the request.</returns>
    Task<TResponse> Handle(TRequest request);

    /// <summary>
    /// Handles the request with the appropriate handler and return the associated result.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the work. See <see cref="CancellationToken"/></param>
    /// <returns>Returns a task representing the result of the processing of the request.</returns>
    /// <exception cref="OperationCanceledException">The token has had cancellation requested.</exception>
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
  }

  /// <summary>
  /// Represents an asynchronous request handler, that handle <see cref="IRequest"/>. Inherits from <see cref="IBaseRequestHandler{TRequest}"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest"/>.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="IBaseRequestHandler{TRequest}"/>
  public interface IAsynchronousRequestHandler<in TRequest> : IBaseRequestHandler<TRequest> where TRequest : IRequest
  {
    /// <summary>
    /// Handles the request with the appropriate handler.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <returns>Returns a task representing the result of the processing of the request.</returns>
    Task Handle(TRequest request);

    /// <summary>
    /// Handles the request with the appropriate handler.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the work. See <see cref="CancellationToken"/></param>
    /// <returns>Returns a task representing the result of the processing of the request.</returns>
    /// <exception cref="OperationCanceledException">The token has had cancellation requested.</exception>
    Task Handle(TRequest request, CancellationToken cancellationToken);
  }
}
