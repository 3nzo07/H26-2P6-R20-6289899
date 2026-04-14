using Models;

namespace Q2
{
    public partial class FrmPrincipal : Form
    {
        List<Plat> Plats = new List<Plat>();

        public FrmPrincipal()
        {
            #region NE PAS MODIFIER
            InitializeComponent();
            ChargerDonnes();
            txtNbIngredientLocal.Text = NbIngredientsSelonType(Plats, TypeIngredient.Local).ToString();
            txtNbIngredientImporte.Text = NbIngredientsSelonType(Plats, TypeIngredient.Importe).ToString();
            #endregion

        }

        public void ChargerDonnes()
        {
            // TODO 1 : Dans le projet Models, observer les deux classes fournies ainsi que le type énuméré afin de pouvoir
            // répondre aux questions.


            // TODO 2 : Construire le jeu de données à partir des tableaux fournis.
            // Tous les objets créés doivent être sauvegardés dans la variable Plats.

            /*
            | Nom                   | Section Menu  | Ingrédients                       |
            |-----------------------|---------------|-----------------------------------|
            | Omelette Western      | Déjeuner      | Oeufs, Jambon                     |
            | Crêpes aux Fruits     | Déjeuner      | Bleuets, Oeufs, Lait              |
            | Saumon Grillé         | Souper        | Saumon, Riz                       |
            | Salade Caesar         | Végétarien    | Laitue, Parmesan                  |
            | Jambon Rôti           | Souper        | Jambon, Riz                       |

            | Nom               |  Type      |
            |-------------------|------------|
            | Oeufs             | Local      |
            | Jambon            | Local      |
            | Bleuets           | Local      |
            | Saumon            | Importé    |
            | Laitue            | Local      |
            | Parmesan          | Local      |
            | Lait              | Local      |
            | Riz               | Importé    |
            
             */

        }

        /// <summary>
        /// Obtenir la liste des plats d'une section de menu donnée
        /// </summary>
        /// <param name="pSectionMenu">Nom de la section de menu</param>
        /// <param name="pPlats">Liste des plats</param>
        /// <returns></returns>
        public List<Plat> FiltrerParSectionMenu(string pSectionMenu, List<Plat> pPlats)
        {
            // TODO 3 : Obtenir la liste des plats d'une section de menu donnée
            // Utiliser une boucle pour y parvenir.
            // COMPLÉTER LE CODE ICI
            List<Plat> plats = new List<Plat>();

            return plats;
        }


        /// <summary>
        /// Obtenir le nombre d'ingrédients selon le type (local/importé)
        /// </summary>
        /// <param name="pPlats"></param>
        /// <param name="pType"></param>
        public int NbIngredientsSelonType(List<Plat> pPlats, TypeIngredient pType)
        {
            // TODO 4 : Obtenir le nombre d'ingrédients selon le type (local/importé)
            // Utiliser une boucle pour y parvenir.
            // COMPLÉTER LE CODE ICI
            int nb = 0;

            return nb;
        }
        #region NE PAS MODIFIER
        private void lstPlats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlats.SelectedIndex != -1)
            {
                Plat p = (Plat)lstPlats.SelectedItem;
                RemplirListView(p.Ingredients, lsvIngredients);
            }
        }

        private void cboSectionsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSectionsMenu.SelectedIndex != -1)
            {
                List<Plat> listePlats = FiltrerParSectionMenu(cboSectionsMenu.Text, Plats);
                RemplirListBox(listePlats, lstPlats);
                lsvIngredients.Items.Clear();
            }
        }
        public void RemplirListView(List<Ingredient> pIngredients, ListView pListView)
        {
            pListView.Items.Clear();
            foreach (Ingredient i in pIngredients)
            {
                ListViewItem item = new ListViewItem(i.Nom);
                item.SubItems.Add(i.Type.ToString());
                pListView.Items.Add(item);

            }
            return;
        }
        public void RemplirListBox(List<Plat> pPlats, ListBox pListBox)
        {
            pListBox.Items.Clear();
            foreach (Plat p in pPlats)
            {
                pListBox.Items.Add(p);

            }
            return;
        }
        #endregion

    }
}
