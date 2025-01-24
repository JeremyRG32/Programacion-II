using System;
using System.Collections.Generic;

namespace Mapa_de_Clases.Models;

public partial class Estudiante
{
    public int Id { get; set; }

    public string? Carrera { get; set; }

    public int MiembroId { get; set; }

    public virtual MiembroDeLaComunidad Miembro { get; set; } = null!;
}
