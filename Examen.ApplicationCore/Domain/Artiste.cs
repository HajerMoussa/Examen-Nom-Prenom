using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Artiste
    {
        public int ArtisteId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Contact { get; set; }
        public string Nationalite { get; set; }
        public string FullName { get { return Nom + " " + Prenom; } }
        public virtual ICollection<Chanson> Chansons { get; set; }
        public virtual ICollection<Concert> Concerts { get; set; }
    }
}
