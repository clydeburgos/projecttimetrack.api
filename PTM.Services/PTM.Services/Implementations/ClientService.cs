using PTM.Models;
using PTM.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Services.Implementations
{
    public class ClientService : IClientService
    {
        public async Task<ClientsModel> Get(int id) {
            return await new Task<ClientsModel>();
        }

        public async Task<List<ClientsModel>> Search(int id, string keyword) {

        }

        public async Task<ClientsModel> Save(ClientsModel client)
        {
            return await new Task<ClientsModel>();
        }

        public async Task<bool> Delete(int id)
        {
            return await new Task<ClientsModel>();
        }
    }
}
