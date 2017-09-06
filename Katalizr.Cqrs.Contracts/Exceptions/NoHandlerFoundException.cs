using System;
using Katalizr.Cqrs.Contracts.Handlers.Commands;
using Katalizr.Cqrs.Contracts.Models;
namespace Katalizr.Cqrs.Contracts.Exceptions
{
  /// <inheritdoc />
  /// <summary>
  /// Represents an error that is thrown when no handlers are found for a specific request <see cref="T:Katalizr.Cqrs.Contracts.Models.IRequest" />. Inherits from <see cref="T:System.Exception" />.
  /// </summary>
  public class NoHandlerFoundException : Exception
  {
  }
}
