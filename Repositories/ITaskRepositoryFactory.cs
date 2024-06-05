using System.Linq;
using TaskMenager.Models;
using TaskMenager.Repositories;

namespace TaskMenager.Factories
{
    public interface ITaskRepositoryFactory
    {
        ITaskRepository Create();
       
    }

    public class TaskRepositoryFactory : ITaskRepositoryFactory
    {
        private readonly TaskMenagerContext _context;

        public TaskRepositoryFactory(TaskMenagerContext context)
        {
            _context = context;
        }

        public ITaskRepository Create()
        {
            return new TaskRepository(_context);
        }
        

    }
}
