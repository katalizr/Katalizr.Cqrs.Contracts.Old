using Katalizr.Cqrs.Contracts.Handlers.Commons;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Queries
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TQuery"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface IAsynchronousQueryHandler<TQuery, TResponse> : IAsynchronousRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
  {
  }
}
