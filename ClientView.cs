using ProjetFilRouge.Entities;

namespace ProjetFilRouge.Views
{
    public class ClientView
    {
        public void DisplayClientList(List<Client> clients)
        {
            foreach (var client in clients)
            {
                Console.WriteLine($"Name: {client.Surname}, Phone: {client.Telephone}, Address: {client.Adresse}");
            }
        }

        public void DisplayClient(Client client)
        {
            if (client != null)
                Console.WriteLine($"Name: {client.Surname}, Phone: {client.Telephone}, Address: {client.Adresse}");
            else
                Console.WriteLine("Client not found.");
        }
    }

    public class DetteView
    {
        public void DisplayDettes(List<Dette> dettes)
        {
            foreach (var dette in dettes)
            {
                Console.WriteLine($"Client: {dette.Client.Surname}, Date: {dette.Date}, Amount Due: {dette.GetCumulMontantsDus()}");
            }
        }
    }
}
