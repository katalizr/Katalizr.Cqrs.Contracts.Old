using System;
using Katalizr.Cqrs.Contracts.Handlers.Commons;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Queries
{
  /// <summary>
  /// Represents an synchronous query handler, that handle <see cref="IQuery{TResponse}"/>. Inherits from <see cref="ISynchronousRequestHandler{TRequest,TResponse}"/>.
  /// </summary>
  /// <typeparam name="TQuery">The type of the query, inherits from <see cref="IQuery{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the query.</typeparam>
  /// <exception cref="ArgumentNullException">The query is null.</exception>
  /// <inheritdoc cref="ISynchronousRequestHandler{TRequest,TResponse}"/>
  public interface IQueryHandler<in TQuery, out TResponse> : ISynchronousRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
  {
  }
}
