using System;
using System.Collections.Generic;

namespace Mapa_de_Clases.Models;

public partial class Maestro
{
    public int Id { get; set; }

    public int DocenteId { get; set; }

    public string? Asignatura { get; set; }

    public virtual Docente Docente { get; set; } = null!;
}
