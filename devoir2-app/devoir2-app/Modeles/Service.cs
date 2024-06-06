using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devoir2_app.Modeles
{
    class Service
    {
        public int idService { get; set; }
        public string nom { get; set; }

        public Service(int idService, string nom)
        {
            this.idService = idService;
            this.nom = nom;
        }
    }
}
