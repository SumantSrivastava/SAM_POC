using samapp.Entities;

namespace samapp.Repositories
{
    /// <summary>
    /// Sample DynamoDB Table book CRUD
    /// </summary>
    public interface IPersonRepository
    {
        /// <summary>
        /// Include new book to the DynamoDB Table
        /// </summary>
        /// <param name="book">book to include</param>
        /// <returns>success/failure</returns>
        Task<bool> CreateAsync(Person book);
        
        /// <summary>
        /// Remove existing book from DynamoDB Table
        /// </summary>
        /// <param name="book">book to remove</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Person book);

        /// <summary>
        /// List book from DynamoDb Table with items limit (default=10)
        /// </summary>
        /// <param name="limit">limit (default=10)</param>
        /// <returns>Collection of books</returns>
        Task<IList<Person>> GetPersonsAsync(int limit = 10);

        /// <summary>
        /// Get book by PK
        /// </summary>
        /// <param name="id">book`s PK</param>
        /// <returns>Book object</returns>
        Task<Person?> GetByIdAsync(Guid id);
        
        /// <summary>
        /// Update book content
        /// </summary>
        /// <param name="book">book to be updated</param>
        /// <returns></returns>
        Task<bool> UpdateAsync(Person book);
    }
}