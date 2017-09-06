using System;
using Katalizr.Cqrs.Contracts.Handlers.Commons;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commands
{
  /// <summary>
  /// Represents an synchronous command handler, that handle <see cref="ICommand{TResponse}"/>. Inherits from <see cref="ISynchronousRequestHandler{TRequest,TResponse}"/>.
  /// </summary>
  /// <typeparam name="TCommand">The type of the command, inherits from <see cref="ICommand{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the command.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="ISynchronousRequestHandler{TRequest,TResponse}"/>
  public interface ICommandHandler<in TCommand, out TResponse> : ISynchronousRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
  {
  }

  /// <summary>
  /// Represents an synchronous command handler, that handle <see cref="ICommand{TResponse}"/>. Inherits from <see cref="ISynchronousRequestHandler{TRequest,TResponse}"/>.
  /// </summary>
  /// <typeparam name="TCommand">The type of the command, inherits from <see cref="ICommand{TResponse}"/>.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="ISynchronousRequestHandler{TRequest}"/>
  public interface ICommandHandler<in TCommand> : ISynchronousRequestHandler<TCommand> where TCommand : ICommand
  {
  }
}
