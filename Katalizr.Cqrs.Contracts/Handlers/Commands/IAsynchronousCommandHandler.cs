using Katalizr.Cqrs.Contracts.Handlers.Commons;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commands
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TCommand"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface IAsynchronousCommandHandler<TCommand, TResponse> : IAsynchronousRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
  {
  }

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TCommand"></typeparam>
  public interface IAsynchronousCommandHandler<TCommand> : IAsynchronousRequestHandler<TCommand> where TCommand : ICommand
  {
  }
}
