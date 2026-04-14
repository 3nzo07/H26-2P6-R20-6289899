namespace Models
{
    public enum TypeIngredient
    {
        Local,
        Importe
    }
    
    public class Ingredient
    {
        public string Nom { get; private set; }

        public TypeIngredient Type { get; private set; }

        public Ingredient(string pNom, int pQuantite, TypeIngredient pType)
        {
            Nom = pNom;
            Type = pType;
        }
    }

}
