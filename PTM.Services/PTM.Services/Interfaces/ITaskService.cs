using PTM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Services.Interfaces
{
    public interface ITaskService
    {
        Task<TasksModel> Get(int id);
        Task<IEnumerable<TasksModel>> Search(int id, string keyword);
        Task<TasksModel> Save(TasksModel task);
        Task<bool> Delete(int id);
    }
}
