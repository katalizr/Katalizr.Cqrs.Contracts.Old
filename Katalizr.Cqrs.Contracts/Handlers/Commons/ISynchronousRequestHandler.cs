using System;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commons
{

  /// <summary>
  /// Represents an synchronous request handler, that handle <see cref="IRequest"/>. Inherits from <see cref="IBaseRequestHandler{TRequest}"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest"/>.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="IBaseRequestHandler{TRequest}"/>
  public interface ISynchronousRequestHandler<in TRequest>: IBaseRequestHandler<TRequest> where TRequest : IRequest
  {
    /// <summary>
    /// Handles the request with the appropriate handler.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    void Handle(TRequest request);
  }


  /// <summary>
  /// Represents an synchronous request handler, that handle <see cref="IRequest{TResponse}"/>. Inherits from <see cref="IBaseRequestHandler{TRequest,TResponse}"/>.
  /// </summary>
  /// <typeparam name="TRequest">The type of the request, inherits from <see cref="IRequest{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the request, inherits from <see cref="IRequest{TResponse}"/>.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="IBaseRequestHandler{TRequest,TResponse}"/>
  public interface ISynchronousRequestHandler<in TRequest, out TResponse>: IBaseRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
  {
    /// <summary>
    /// Handles the request with the appropriate handler and return the associated result.
    /// </summary>
    /// <param name="request">The request to handle.</param>
    /// <returns>Returns the result of the processing of the request.</returns>
    TResponse Handle(TRequest request);
  }
}
