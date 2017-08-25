using Katalizr.Cqrs.Contracts.Handlers.Commons;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Queries
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TQuery"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface IAsynchronousCancellableQueryHandler<TQuery, TResponse> : IAsynchronousCancellableRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
  {
  }
}
