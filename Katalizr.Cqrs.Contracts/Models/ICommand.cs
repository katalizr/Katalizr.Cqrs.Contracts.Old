namespace Katalizr.Cqrs.Contracts.Models
{
  /// <inheritdoc />
  /// <summary>
  /// Represents a command
  /// </summary>
  public interface ICommand : IRequest
  {
  }

  /// <inheritdoc />
  /// <summary>
  /// Represents a command with an expected response.
  /// </summary>
  /// <typeparam name="TResponse"></typeparam>
  public interface ICommand<out TResponse> : IRequest<TResponse>
  {
  }
}
