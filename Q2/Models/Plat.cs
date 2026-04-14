namespace Models
{
   
    public class Plat
    {
        public string Nom { get; private set; }
        public string SectionMenu { get; private set; }

        public List<Ingredient> Ingredients { get; set; }

        public Plat(string pNom, string pSectionMenu)
        {
            Nom = pNom;
            SectionMenu = pSectionMenu;
            Ingredients = new List<Ingredient>();
        }       
        public override string ToString()
        {
            return $"{Nom} : {SectionMenu}";
        }
    }

    
}
