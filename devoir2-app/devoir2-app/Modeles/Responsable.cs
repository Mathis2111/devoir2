using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devoir2_app.Modeles
{
    class Responsable
    {
        public string login { get; set; }
        public string pwd { get; set; }

        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
