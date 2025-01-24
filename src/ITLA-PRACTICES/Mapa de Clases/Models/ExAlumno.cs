using System;
using System.Collections.Generic;

namespace Mapa_de_Clases.Models;

public partial class ExAlumno
{
    public int Id { get; set; }

    public int MiembroId { get; set; }

    public DateOnly? FechaGraduacion { get; set; }

    public virtual MiembroDeLaComunidad Miembro { get; set; } = null!;
}
