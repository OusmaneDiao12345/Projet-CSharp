using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetFilRouge.Entities
{
 public class Article
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public int QuantiteStock { get; set; }
    public decimal Prix { get; set; }

    public Article(string nom, int quantiteStock, decimal prix)
    {
        Nom = nom;
        QuantiteStock = quantiteStock;
        Prix = prix;
    }
}

}