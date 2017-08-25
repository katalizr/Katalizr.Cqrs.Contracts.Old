using System;
using Katalizr.Cqrs.Contracts.Handlers.Commons;
using Katalizr.Cqrs.Contracts.Models;

namespace Katalizr.Cqrs.Contracts.Handlers.Commands
{
  /// <summary>
  /// Represents an asynchronous command handler, that handle <see cref="ICommand{TResponse}"/>. Inherits from <see cref="IAsynchronousRequestHandler{TRequest,TResponse}"/>.
  /// </summary>
  /// <typeparam name="TCommand">The type of the command, inherits from <see cref="ICommand{TResponse}"/>.</typeparam>
  /// <typeparam name="TResponse">The type of the response.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="IAsynchronousRequestHandler{TRequest,TResponse}"/>
  public interface IAsynchronousCommandHandler<in TCommand, TResponse> : IAsynchronousRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
  {
  }

  /// <summary>
  /// Represents an asynchronous command handler, that handle <see cref="ICommand"/>. Inherits from <see cref="IAsynchronousRequestHandler{TRequest}"/>.
  /// </summary>
  /// <typeparam name="TCommand">The type of the command, inherits from <see cref="ICommand"/>.</typeparam>
  /// <exception cref="ArgumentNullException">The command is null.</exception>
  /// <inheritdoc cref="IAsynchronousRequestHandler{TRequest}"/>
  public interface IAsynchronousCommandHandler<in TCommand> : IAsynchronousRequestHandler<TCommand> where TCommand : ICommand
  {
  }
}
