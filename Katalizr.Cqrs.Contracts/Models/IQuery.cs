namespace Katalizr.Cqrs.Contracts.Models
{

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TResponse"></typeparam>
  public interface IQuery<out TResponse> : IRequest<TResponse>
  {
  }
}
