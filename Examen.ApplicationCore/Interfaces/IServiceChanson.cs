using Examen.ApplicationCore.Domain;
using Examen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceChanson : IService<Chanson>
    {
        void GetMusicalStyle(StyleMusical st);
        IEnumerable<string> GetSongsTitles(Artiste a);
    }
}
