using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rattrapage
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        //----Classe Livre----
        public class Livre {
            private string titre;
            private string auteur;
            private string editeur;
            public Livre() { }
            public Livre(string titre, string auteur, string editeur)
            {
                this.titre = titre;
                this.auteur = auteur;
                this.editeur = editeur;
            }
            public void setTitre(string titrelv)
            {
                titre = titrelv;
            }
            public void getTitre(string titrelv)
            {
                titre = titrelv;
            }
            public void setauteur(string auteurlv)
            {
                auteur = auteurlv;
            }
            public void getauteur(string auteurlv)
            {
                auteur = auteurlv;
            }
            public void setediteur(string editeurlv)
            {
                editeur = editeurlv;
            }
            public void getediteur(string editeurlv)
            {
                editeur = editeurlv;
            }
            void enregistrer()
            {
            }
            void sortir()
            {
            }
            void modifier()
            {
            }
            void existeAutre()
            {
                if (titre == '')
                    Console.WriteLine("le livre existe");
                else
                    Console.WriteLine("le livre n existe pas");
            }
            void estDisponible()
            {
                if (titre == '')
                    Console.WriteLine("le livre est diponible");
                else
                    Console.WriteLine("le livre n est pas disponible");
            }
            void demander_responsable()
            {
            }
            void remplacer()
            {
            }
            void mettre_disposition()
            {
            }
            void demander_usagers()
            {
            }

        }
        //----Classe Etat Livre----
        public class Etat_livre : Livre
        {
            private Boolean disponible;
            private Boolean Emprunte;
            private Boolean delabre;
            public Etat_livre()
            {
            }
            void archivé()
            {
                if (delabre == true)
                {
                    Console.WriteLine("l emprunteur sera tenu responsable");
                }
            }
        }
        //----Classe Emprunteur----
        public class Emprunteur
        {
            private string nom;
            private string prenom;
            private string adresse;
            private DateTime dateinscription;
            public Emprunteur()
            {
            }
            public Emprunteur(string nom, string prenom, string adresse, DateTime dateinscription)
            {
                this.nom = nom;
                this.prenom = prenom;
                this.adresse = adresse;
                this.dateinscription = dateinscription;
            }
            public void setnom(string nomemp)
            {
                nom = nomemp;
            }
            public void getnom(string nomemp)
            {
                nom = nomemp;
            }
            public void setprenom(string prenomemp)
            {
                prenom = prenomemp;
            }
            public void getprenom(string prenomemp)
            {
                prenom = prenomemp;
            }
            public void setadresse(string adressemp)
            {
                adresse = adressemp;
            }
            public void getadress(string adressemp)
            {
                adresse = adressemp;
            }
            public void setdateinsc(DateTime dateins)
            {
                dateinscription = dateins;
            }
            public void getdateinsc(DateTime dateins)
            {
                dateinscription = dateins;
            }
        }
        //----Classe Emprunt----
        public class emprunt
        {
            private int numero;
            private string date_emprunt;
            private int date_retour;
            private int duree;
            public emprunt()
            {
            }
            public emprunt(int numero, string date_emprunt, int date_retour, int duree)
            {
                this.numero = numero;
                this.date_emprunt = date_emprunt;
                this.date_retour = date_retour;
                this.duree = duree;
            }
            public void setnumero(int num)
            {
                num = numero;
            }
            public void getnumero(int num)
            {
                num = numero;
            }
            public void setdate_em(string date_em)
            {
                date_emprunt = date_em;
            }
            public void getdate_em(string date_em)
            {
                date_emprunt = date_em;
            }
            public void setdate_re(int date_re)
            {
                date_retour = date_re;
            }
            public void getdate_re(int date_re)
            {
                date_retour = date_re;
            }
            void verifierdateretour()
            {
                if (date_retour > 3)
                {
                    Console.WriteLine(" sous peine de sanctions");
                }
            }
            void prolongerduree(int duree)
            {
            }
            void faireemprunt()
            {

            }
            void finaliserEmprunt() { }
        }
        //----Classe Emprunt----
        public class duree : emprunt
        {
            string dateDepasse;
            string retour;
        }
        //----Classe Reservation----
        public class Reservation :Emprunteur
        {
            string date_reservation;
            public void fairereserv()
            {

            }
            public void datereserv()
            {

            }
        }
    }
}
