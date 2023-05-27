using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.Interfaces;
using Examen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceArtiste : Service<Artiste>, IServiceArtiste
    {
        public ServiceArtiste(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double PlusHautCachet(Festival f)
        {
            return f.Concerts.Where(c => c.DateConcert.Year == DateTime.Now.Year).Max(c => c.Cachet);

        }
    }
}
