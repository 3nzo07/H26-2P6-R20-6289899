using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Models
{

    public class Ordinateur
    {
        // TODO 1  : Compléter la classe Ordinateur 
        // TODO 1A : Compléter la validation de la date de vente de l'ordinateur en levant
        // une exception de type ArgumentOutOfRangeException si la date
        // est dans le futur.

        // TODO 1B : Compléter la validation en levant une exception de type
        // InvalidOperationException si l'ordinateur dépasse le nombre maximal de Watt permis.
        // C'est-à-dire lorsque le total de Watt des composantes dépasse MAX_WATT.

        // TODO 1C : Compléter la validation du nom de l'ordinateur en levant
        // une exception de type ArgumentException si le nom est null ou vide.       

        // TODO 1D : Compléter la validation en levant une exception de type
        // ArgumentNullException si la composante est null.

        // TODO 1E : Ajouter une propriété CapaciteAtteint
        // qui indique si l'ordinateur a atteint le nombre maximal de composantes.

        // TODO 1F : Ajouter une propriété JoursGarantieRestants
        // qui retourne le nombre de jours restants à la garantie après la date de l'achat.



        public const int MAX_WATT = 800;
        public const int JOURS_GARANTIE = 730; // 2 ans de garantie en jours

        private string m_nomOrdinateur;
        private DateTime m_dateAssemblage;

        public DateTime DateVente
        {
            get { return m_dateAssemblage; }
            set
            {
                m_dateAssemblage = value;
                DateTime now = DateTime.Now;
                if (DateVente > now)
                {
                    throw new ArgumentOutOfRangeException("La date de vente ne peut pas être dans le futur.");
                }
            }

        }

        public string NomOrdinateur
        {
            get { return m_nomOrdinateur; }
            set
            {
                m_nomOrdinateur = value.Trim();
                if(string.IsNullOrEmpty(NomOrdinateur))
                {
                    throw new ArgumentException("Le nom de l'ordinateur ne peut pas être vide.");
                }
            }
        }

        public List<Composante> ListeComposantes
        {
            get { return new List<Composante>(); }
            private set
            {
                if(ListeComposantes == null)
                {
                    throw new ArgumentException("La composante ne peut pas être nulle!");
                }
            }
        }


        public TimeSpan JoursGarantieRestants
        {
            get
            {
                DateTime FinGarantie = DateVente.AddDays(JOURS_GARANTIE);
                return FinGarantie - DateTime.Now;
            }
            
        }

        public int CapaciteAtteint
        {
            get { return CapaciteAtteint; }
            private set
            {
                int wattadd;
                foreach(Composante c in ListeComposantes)
                {
                     
                }
                if (value > MAX_WATT)
                {
                    throw new InvalidOperationException("Impossible d'ajouter une composante : l'ordinateur a atteint sa capacité maximale!");
                }
            }
        }



        public Ordinateur(string pNomOrdinateur,
                               DateTime pDateAssemblage)
        {           
            NomOrdinateur = pNomOrdinateur;
            DateVente = pDateAssemblage;
            ListeComposantes = new List<Composante>();
        }

        public void AjouterComposante(Composante pComposante)
        {
            ListeComposantes.Add(pComposante);
        }
      

    }
}
