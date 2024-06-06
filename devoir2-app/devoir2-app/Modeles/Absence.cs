using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devoir2_app.Modeles
{

    class Absence
    {
        public int idPersonnel { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public int idMotif { get; set; }

        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, int idMotif)
        {
            this.idPersonnel = idPersonnel;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.idMotif = idMotif;
        }
    }
}
