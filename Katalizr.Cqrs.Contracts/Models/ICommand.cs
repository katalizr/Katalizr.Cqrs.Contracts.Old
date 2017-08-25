namespace Katalizr.Cqrs.Contracts.Models
{
  /// <summary>
  ///
  /// </summary>
  public interface ICommand : IRequest
  {
  }

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TResponse"></typeparam>
  public interface ICommand<out TResponse> : IRequest<TResponse>
  {
  }
}
