using System;
using System.Collections.Generic;
using System.Linq;
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
            }

        }

        public string NomOrdinateur
        {
            get { return m_nomOrdinateur; }
            set
            {
                m_nomOrdinateur = value.Trim();
            }
        }

        public List<Composante> ListeComposantes
        {
            get;
            private set;
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
