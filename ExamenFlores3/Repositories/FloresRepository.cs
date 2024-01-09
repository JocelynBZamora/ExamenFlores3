using ExamenFlores3.Areas.Admin.Models;
using ExamenFlores3.Areas.Admin.Models.ViewModel;
using ExamenFlores3.Models.Entities;

namespace ExamenFlores3.Repositories
{
    public class FloresRepository : Repository<Datos>
    {
        FloresContext context;
        public FloresRepository(FloresContext context):base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }
  
    }
}
