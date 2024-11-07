using System;
using System.Collections.Generic;
using ProjetFilRouge.Entities;
using ProjetFilRouge.Repositories;
using ProjetFilRouge.Services;
using ProjetFilRouge.Views;

class Program
{
    static void Main()
    {
        // Initialize repositories
        ClientRepository clientRepo = new ClientRepository();
        DetteRepository detteRepo = new DetteRepository();
        UtilisateurRepository utilisateurRepo = new UtilisateurRepository();
        ArticleRepository articleRepo = new ArticleRepository();

        // Initialize services
        ClientService clientService = new ClientService(clientRepo);
        DetteService detteService = new DetteService(detteRepo, clientRepo);
        UtilisateurService utilisateurService = new UtilisateurService(utilisateurRepo);
        ArticleService articleService = new ArticleService(articleRepo);

        // Initialize views
        ClientView clientView = new ClientView();
        DetteView detteView = new DetteView();
        UtilisateurView utilisateurView = new UtilisateurView();
        ArticleView articleView = new ArticleView();

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Créer Client");
            Console.WriteLine("2. Lister Clients");
            Console.WriteLine("3. Rechercher Client par Téléphone");
            Console.WriteLine("4. Ajouter Dette à Client");
            Console.WriteLine("5. Lister les Dettes");
            Console.WriteLine("6. Créer Utilisateur");
            Console.WriteLine("7. Lister Utilisateurs");
            Console.WriteLine("8. Ajouter Article");
            Console.WriteLine("9. Lister Articles");
            Console.WriteLine("10. Quitter");
            Console.Write("Choisissez une option : ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter Nom: ");
                    string? name = Console.ReadLine() ?? string.Empty;
                    Console.Write("Entrer Telephone: ");
                    string? phone = Console.ReadLine() ?? string.Empty;
                    Console.Write("Entrer l'address: ");
                    string? address = Console.ReadLine() ?? string.Empty;
                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(address))
            {
                clientService.CreateClient(name, phone, address);
            }   
                        else
                        {
                             Console.WriteLine("Veuillez remplir tous les champs requis.");
                        }
                    break;

                case "2":
                    clientView.DisplayClientList(clientService.ListClients());
                    break;

                case "3":
                    Console.Write("Entrez le Téléphone : ");
                    phone = Console.ReadLine();
                    var client = clientService.SearchClientByPhone(phone);
                    if (client != null)
                        clientView.DisplayClient(client);
                    else
                        Console.WriteLine("Client introuvable.");
                    break;

                case "4":
                    Console.Write("Entrez le Téléphone du client : ");
                    phone = Console.ReadLine();
                    Console.Write("Entrez la Date (YYYY-MM-DD) : ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                    {
                        Console.Write("Entrez le Montant : ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                        {
                            var articles = new List<Article> { new Article("ExampleArticle", 1, 10.0M) };  // Exemple de liste d'articles
                            detteService.AddDette(phone, date, amount, articles);
                        }
                        else
                        {
                            Console.WriteLine("Montant invalide. Veuillez recommencer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Date invalide. Veuillez recommencer.");
                    }
                    break;

                case "5":
                    detteView.DisplayDettes(detteService.ListDettes());
                    break;

                case "6":
                    Console.Write("Entrez l'Email : ");
                    string email = Console.ReadLine();
                    Console.Write("Entrez le Login : ");
                    string login = Console.ReadLine();
                    Console.Write("Entrez le Mot de Passe : ");
                    string password = Console.ReadLine();
                    Console.Write("Entrez le Rôle : ");
                    string role = Console.ReadLine();
                    utilisateurService.CreateUtilisateur(email, login, password, role);
                    break;

                case "7":
                    utilisateurView.DisplayUtilisateurs(utilisateurService.ListUtilisateurs());
                    break;

                case "8":
                    Console.Write("Entrez le Nom de l'Article : ");
                    name = Console.ReadLine();
                    Console.Write("Entrez la Quantité en Stock : ");
                    if (int.TryParse(Console.ReadLine(), out int quantity))
                    {
                        Console.Write("Entrez le Prix : ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal price))
                        {
                            articleService.AddArticle(name, quantity, price);
                        }
                        else
                        {
                            Console.WriteLine("Prix invalide. Veuillez recommencer.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Quantité invalide. Veuillez recommencer.");
                    }
                    break;

                case "9":
                    articleView.DisplayArticles(articleService.ListArticles());
                    break;

                case "10":
                    Console.WriteLine("Merci d'avoir utilisé l'application. À bientôt !");
                    return;

                default:
                    Console.WriteLine("Option invalide. Veuillez recommencer.");
                    break;
            }
        }
    }
}
