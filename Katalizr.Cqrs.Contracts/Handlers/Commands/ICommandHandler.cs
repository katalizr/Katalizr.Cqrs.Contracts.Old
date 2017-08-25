using Katalizr.Cqrs.Contracts.Handlers.Commons;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commands
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TCommand"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface ICommandHandler<TCommand, TResponse> : ISynchronousRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
  {
  }

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TCommand"></typeparam>
  public interface ICommandHandler<TCommand> : ISynchronousRequestHandler<TCommand> where TCommand : ICommand
  {
  }
}
