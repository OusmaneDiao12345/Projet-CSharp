
   using System;
using System.Collections.Generic;
using System.Linq;

    namespace ProjetFilRouge.Entities
{
    
public class Utilisateur
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public bool IsActive { get; set; }

    public Utilisateur(string email, string login, string password, string role)
    {
        Email = email;
        Login = login;
        Password = password;
        Role = role;
        IsActive = true; // Par défaut, l'utilisateur est actif
    }
}

}

