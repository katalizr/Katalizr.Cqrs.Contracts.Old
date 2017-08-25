using System.Threading.Tasks;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Dispatchers
{
  /// <summary>
  ///
  /// </summary>
  public interface IAsynchronousDispatcher
  {
    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    /// <typeparam name="TRequest"></typeparam>
    /// <returns></returns>
    Task Dispatch<TRequest>(TRequest request) where TRequest : IRequest;

    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    /// <returns></returns>
    Task<TResponse> Dispatch<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>;
  }
}
