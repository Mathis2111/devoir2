﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devoir2_app.Modeles
{
    class Personnel
    {
        public int idPersonnel { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public int idService { get; set; }

        public Personnel(int idPersonnel, string nom, string prenom, string tel, string mail, int idService)
        {
            this.idPersonnel = idPersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idService = idService;
        }
    }
}
