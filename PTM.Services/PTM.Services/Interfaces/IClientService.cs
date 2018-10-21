using PTM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Services.Interfaces
{
    public interface IClientService
    {
        Task<ClientsModel> Get(int id);
        Task<IEnumerable<ClientsModel>> Search(int id, string keyword);
        Task<ClientsModel> Save(ClientsModel client);
        Task<bool> Delete(int id);
    }
}
