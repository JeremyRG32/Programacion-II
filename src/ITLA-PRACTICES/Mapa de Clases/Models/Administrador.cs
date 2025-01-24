using System;
using System.Collections.Generic;

namespace Mapa_de_Clases.Models;

public partial class Administrador
{
    public int Id { get; set; }

    public int DocenteId { get; set; }

    public string? NivelJerarquico { get; set; }

    public virtual Docente Docente { get; set; } = null!;


}
