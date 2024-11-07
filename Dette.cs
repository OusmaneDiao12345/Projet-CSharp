using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetFilRouge.Entities
{
public class Dette
{
    public int Id { get; set; }
    public Client Client { get; set; }
    public DateTime Date { get; set; }
    public decimal Montant { get; set; }
    public decimal MontantVerser { get; set; }
    public decimal MontantRestant { get; set; }
    public List<Article> Articles { get; set; }
    public List<Paiement> Paiements { get; set; }

    public Dette(Client client, DateTime date, decimal montant, List<Article> articles)
    {
        Client = client;
        Date = date;
        Montant = montant;
        MontantRestant = montant;
        Articles = articles;
        Paiements = new List<Paiement>();
    }

    public decimal GetCumulMontantsDus()
    {
        return MontantRestant;
    }
}


}