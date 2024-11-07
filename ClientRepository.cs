using ProjetFilRouge.Entities;

namespace ProjetFilRouge.Repositories
{
    public class ClientRepository
    {
        private List<Client> clients = new List<Client>();

        public void AddClient(Client client) => clients.Add(client);

        public List<Client> GetAllClients() => clients;

        public Client FindClientByPhone(string phone) => clients.FirstOrDefault(c => c.Telephone == phone);
    }

    public class DetteRepository
    {
        private List<Dette> dettes = new List<Dette>();

        public void AddDette(Dette dette) => dettes.Add(dette);

        public List<Dette> GetAllDettes() => dettes;

        public List<Dette> GetDettesByClient(Client client) => dettes.Where(d => d.Client == client).ToList();
    }
}
