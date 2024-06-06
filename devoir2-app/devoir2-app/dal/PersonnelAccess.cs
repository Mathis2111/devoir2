using devoir2_app.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devoir2_app.dal
{
    class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }


        /// <summary>
        /// Récupère et retourne les développeurs
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "SELECT * From Personnel;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        //Log.Debug("DeveloppeurAccess.GetLesDeveloppeurs nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            /*Log.Debug("DeveloppeurAccess.GetLesDeveloppeurs Profil : id={0} nom={1}", record[5], record[6]);
                            Log.Debug("DeveloppeurAccess.GetLesDeveloppeurs Developpeur : id={0} nom={1} prenom={2} tel={3} mail={4} ", record[0], record[1], record[2], record[3], record[4]);*/
                          
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                                (string)record[3], (string)record[4], (int)record[5]);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //Log.Error("DeveloppeurAccess.GetLesDeveloppeurs catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }
    }
}
