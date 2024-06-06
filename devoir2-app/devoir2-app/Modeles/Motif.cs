using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devoir2_app.Modeles
{
    /// <summary>
    /// 
    /// </summary>
    class Motif
    {
        public int idMotif { get; set; }
        public string libelle { get; set; }

        public Motif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }
    }
}
