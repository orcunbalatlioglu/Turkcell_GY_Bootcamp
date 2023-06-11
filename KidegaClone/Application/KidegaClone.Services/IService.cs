namespace KidegaClone.Services
{
    public interface IService<TCreate, TDisplay, TUpdate>
    where TCreate : class
    where TDisplay : class
    where TUpdate : class
    {
        void Create(TCreate request);
        Task CreateAsync(TCreate request);
        int CreateAndReturnId(TCreate request);
        Task<int> CreateAndReturnIdAsync(TCreate request);
        void Delete(int id);
        Task DeleteAsync(int id);
        void Update(TUpdate request);
        Task UpdateAsync(TUpdate request);
        bool IsExist(int id);
        Task<bool> IsExistsAsync(int id);
        TDisplay GetById(int id);
        Task<TDisplay> GetByIdAsync(int id);
        TUpdate GetForUpdate(int id);
        Task<TUpdate> GetForUpdateAsync(int id);
        IEnumerable<TDisplay> GetAll();
        Task<IEnumerable<TDisplay>> GetAllAsync();
    }

}
