using System;
using System.Threading.Tasks;

namespace tasks.services
{
    public interface IStorageService
    {
        Task<(bool IsSuccess, Exception exception)> InsertTaskAsync(Entities.Task task);

    }
}