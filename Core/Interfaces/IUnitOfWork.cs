namespace Core.Interfaces
{
    public interface IUnitOfWork<T> where T : class
    {
        //this unit of work will work with all repo in this proj so we should specify which repo we will use
        IGenericRepository<T> Entity { get; }
        void Save(); 
    }
}