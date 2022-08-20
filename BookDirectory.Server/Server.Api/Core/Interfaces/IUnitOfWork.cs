namespace Server.Api.Core.Interfaces;

public interface IUnitOfWork{
    Task CompleteAsync();
}
