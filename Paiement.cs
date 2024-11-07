using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetFilRouge.Entities
{
 public class Paiement
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Montant { get; set; }
        public Dette Dette { get; internal set; }

        public Paiement(DateTime date, decimal montant)
    {
        Date = date;
        Montant = montant;
    }
}


}