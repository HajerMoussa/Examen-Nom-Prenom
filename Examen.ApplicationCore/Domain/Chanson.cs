using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum StyleMusical
    {
        Classique,Pop,Rap,Rock
    }
    public class Chanson
    {

        public int ChansonId { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateSortie { get; set; }

        public int Duree { get; set; }

        public StyleMusical StyleMusical { get; set; }
       [MinLength(3), MaxLength(12)]
        public string Titre { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "le nombre doit être positif")]
        public int VuesYoutube { get; set; }

        public virtual Artiste Artiste { get; set; }

        [ForeignKey("Artiste")]
        public int ArtisteFk { get; set; }
    }
}
