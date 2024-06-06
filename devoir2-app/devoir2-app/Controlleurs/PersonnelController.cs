using System;
using System.Windows.Forms;
using devoir2_app.Vues;

namespace devoir2_app.Controllers
{
    public class PersonnelController
    {
        private VuePersonnel vuePersonnel;
        private VueAjouterPersonnel ajouterPersonnel;

        public PersonnelController()
        {
            vuePersonnel = new VuePersonnel();
            ajouterPersonnel = new VueAjouterPersonnel();
        }

        public void AfficherAjouterPersonnel()
        {
            vuePersonnel.Hide();
            ajouterPersonnel.Show();
        }

        public void Show()
        {
            vuePersonnel.Show();
        }

        public void Hide()
        {
            vuePersonnel.Hide();
        }
    }
}
