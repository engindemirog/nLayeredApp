namespace Core.DataAccess.Repositories;

public interface IQuery<T>
{
    IQueryable<T> Query();
}