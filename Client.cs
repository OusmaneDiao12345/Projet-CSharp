using System;
using System.Collections.Generic;
using System.Linq;
using ProjetFilRouge.Entities;

namespace ProjetFilRouge.Entities
{public class Client
{
    public int Id { get; set; }
    public string Surname { get; set; }
    public string Telephone { get; set; }
    public string Adresse { get; set; }

    public Utilisateur Utilisateur { get; set; }

    public Client(string surname, string telephone, string adresse)
    {
        Surname = surname;
        Telephone = telephone;
        Adresse = adresse;
    }

    public bool HasAccount()
    {
        return Utilisateur != null;
    }
}

}

