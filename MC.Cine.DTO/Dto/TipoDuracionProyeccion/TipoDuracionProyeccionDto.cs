using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC.Cine.DTO.Dto.TipoDuracionProyeccion
{
    public class TipoDuracionProyeccionDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
