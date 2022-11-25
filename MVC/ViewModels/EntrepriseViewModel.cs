﻿namespace MVC.ViewModels
{
    public class EntrepriseViewModel
    {
        public int Id { get; set; }

        public string Nom { get; set; } = String.Empty;
        public EntrepriseViewModel(int id, string nom)
        {
            Id = id;
            Nom = nom;  

        }
    }
}
