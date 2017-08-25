using Katalizr.Cqrs.Contracts.Handlers.Commons;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commands
{
  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TCommand"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  public interface IAsynchronousCancellableCommandHandler<TCommand, TResponse> : IAsynchronousCancellableRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
  {
  }

  /// <summary>
  ///
  /// </summary>
  /// <typeparam name="TCommand"></typeparam>
  public interface IAsynchronousCancellableCommandHandler<TCommand> : IAsynchronousCancellableRequestHandler<TCommand> where TCommand : ICommand
  {
  }
}
