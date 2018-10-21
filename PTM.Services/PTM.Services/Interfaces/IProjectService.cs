using PTM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Services.Interfaces
{
    public interface IProjectService
    {
        Task<ProjectsModel> Get(int id);
        Task<IEnumerable<ProjectsModel>> Search(int id, string keyword);
        Task<ClientsModel> Save(ProjectsModel project);
        Task<bool> Delete(int id);
    }
}
