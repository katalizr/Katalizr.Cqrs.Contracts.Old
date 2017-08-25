using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Dispatchers
{
  /// <summary>
  ///
  /// </summary>
  public interface IDispatcher
  {
    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    /// <typeparam name="TRequest"></typeparam>
    void Dispatch<TRequest>(TRequest request) where TRequest : IRequest;

    /// <summary>
    ///
    /// </summary>
    /// <param name="request"></param>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    /// <returns></returns>
    TResponse Dispatch<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>;
  }
}
