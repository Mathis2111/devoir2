using System;
using System.Windows.Forms;
using devoir2_app.Controlleurs;
using devoir2_app.dal;
using devoir2_app.Modeles;
using devoir2_app.Vues;

namespace devoir2_app.Controllers
{
    public class LoginController
    {
        private VueLogin vueLogin;
        private PersonnelController personnelController;

        public LoginController()
        {
            vueLogin = new VueLogin(this);
            personnelController = new PersonnelController();
            Application.Run(vueLogin);
        }

        public void ValiderLogin(string nomUtilisateur, string motDePasse)
        {
            // Validation des identifiants ici (à compléter selon vos besoins)
            // Par exemple, on suppose que la validation est réussie.

            personnelController.Show();

            //PersonnelAccess personnelAccess = new PersonnelAccess();

            // Appelez la méthode GetLesPersonnels() sur l'objet créé
            /*foreach (Personnel personnel in personnelAccess.GetLesPersonnels())
            {
                Console.WriteLine(personnel);
            }*/

            vueLogin.Hide();
        }
    }
}
