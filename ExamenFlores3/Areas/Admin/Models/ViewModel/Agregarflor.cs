using ExamenFlores3.Models.Entities;
using Microsoft.Extensions.FileProviders;

namespace ExamenFlores3.Areas.Admin.Models.ViewModel
{
    public class Agregarflor
    {


        public Datos Datos { get; set; } = null!;
        public IFileInfo? foto { get; set; }

    }
}
