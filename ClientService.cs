using ProjetFilRouge.Entities;
using ProjetFilRouge.Repositories;

namespace ProjetFilRouge.Services
{
    public class ClientService
    {
        private ClientRepository clientRepo;

        public ClientService(ClientRepository repo) => clientRepo = repo;

        public void CreateClient(string surname, string phone, string address)
        {
            var client = new Client(surname, phone, address);
            clientRepo.AddClient(client);
        }

        public List<Client> ListClients() => clientRepo.GetAllClients();

        public Client SearchClientByPhone(string phone) => clientRepo.FindClientByPhone(phone);
    }

    public class DetteService
    {
        private DetteRepository detteRepo;
        private ClientRepository clientRepo;

        public DetteService(DetteRepository repo, ClientRepository clientRepo)
        {
            detteRepo = repo;
            this.clientRepo = clientRepo;
        }

        public void AddDette(string phone, DateTime date, decimal montant, List<Article> articles)
        {
            var client = clientRepo.FindClientByPhone(phone);
            if (client != null)
            {
                var dette = new Dette(client, date, montant, articles);
                detteRepo.AddDette(dette);
            }
        }

        public List<Dette> ListDettes() => detteRepo.GetAllDettes();
    }
}
