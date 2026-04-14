namespace Models
{
    public class Composante
    {
        /// <summary>
        /// Obtenir et modifier le nom de la composante
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Obtenir et modifier la puissance de la composante en watt
        /// </summary>
        public int Watt { get; set; }

        /// <summary>
        /// Obtenir et modifier le type de la composante
        /// </summary>
        public TypeComposante Type { get; private set; }

        /// <summary>
        /// Initialise une nouvelle composante.
        /// </summary>
        /// <param name="pNom">Nom de la composante</param>
        /// <param name="pWatt">Puissance de la composante en watt</param>
        /// <param name="pType">Type de la composante</param>
        public Composante(string pNom, int pWatt, TypeComposante pType)
        {          
            Nom = pNom;
            Watt = pWatt;
            Type = pType;
        }
       
    }
}
