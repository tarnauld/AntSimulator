﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AntSimulator
{
    [XmlInclude(typeof(BoutDeTerrain))]
    public abstract class ZoneAbstraite
    {
        [XmlElement("coordonneesZone")]
        public Coordonnees coordonnes { get; set; }
        [XmlElement("nomZone")]
        public string nom { get; set; }
        [XmlElement("listeObjetsZone")]
        public List<ObjetAbstrait> ObjetsList { get; set; }
        [XmlElement("listeAccesZone")]
        public List<AccesAbstrait> AccesAbstraitList { get; set; }
        [XmlElement("listePersonnagesZone")]
        public List<PersonnageAbstrait> PersonnagesList { get; set; }
        
        public ZoneAbstraite(string unNom)
        {
            nom = unNom;
            coordonnes = new Coordonnees();
        }
        public ZoneAbstraite(string unNom,Coordonnees coordonnees)
        {
            nom = unNom;
            this.coordonnes =  coordonnees;
        }
        public ZoneAbstraite()
        {
            nom = "nom par defaut";
           coordonnes = new Coordonnees();
        }
       
        public void AjouteAcces(AccesAbstrait acces)
        {
            AccesAbstraitList.Add(acces);
        }
        public void AjouteObjet(ObjetAbstrait objet)
        {
            ObjetsList.Add(objet);
        }
        public void AjoutePersonnage(PersonnageAbstrait unPersonnage)
        {
            PersonnagesList.Add(unPersonnage);
        }
        public void RetirePersonnage(PersonnageAbstrait unPersonnage)
        {
            if (!PersonnagesList.Contains(unPersonnage))
            {
                Console.WriteLine("Ce Personnage n'existe pas dans la liste");
            }
            PersonnagesList.Remove(unPersonnage);
        }

    }
}