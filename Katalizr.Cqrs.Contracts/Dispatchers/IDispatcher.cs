using System;
using Katalizr.Cqrs.Contracts.Models;
using Katalizr.Cqrs.Contracts.Exceptions;

namespace Katalizr.Cqrs.Contracts.Dispatchers
{
  /// <summary>
  /// Represents an synchronous dispatcher.
  /// </summary>
  public interface IDispatcher
  {
    /// <summary>
    /// Dispatches a request to the appropriate handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <typeparam name="TRequest">The type of the request. Must inherits from <see cref="IRequest"/>.</typeparam>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="NoHandlerFoundException">No handler has been found for the request.</exception>
    /// <exception cref="MultipleHandlerFoundException">Too many handler has been found for the request.</exception>
    void Dispatch<TRequest>(TRequest request) where TRequest : IRequest;

    /// <summary>
    /// Dispatches a request to the appropriate handler.
    /// </summary>
    /// <param name="request">The request to dispatch.</param>
    /// <typeparam name="TRequest">The type of the request. Must inherits from <see cref="IRequest{T}"/>.</typeparam>
    /// <typeparam name="TResponse">The type of the request.</typeparam>
    /// <returns>The response that was returned following the execution of the handler.</returns>
    /// <exception cref="ArgumentNullException">The request is null.</exception>
    /// <exception cref="NoHandlerFoundException">No handler has been found for the request.</exception>
    /// <exception cref="MultipleHandlerFoundException">Too many handler has been found for the request.</exception>
    TResponse Dispatch<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>;
  }
}
