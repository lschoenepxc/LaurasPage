namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadDb<T, U>(string sql, U parameters, string connectionString);
        Task SaveDb<T>(string sql, T parameters, string connectionString);
    }
}