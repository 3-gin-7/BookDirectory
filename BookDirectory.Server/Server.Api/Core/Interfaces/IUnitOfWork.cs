namespace Server.Api.Core.Interfaces;

public interface IUnitOfWork{
    public IBookRepository Books { get; }

    Task CompleteAsync();
}
