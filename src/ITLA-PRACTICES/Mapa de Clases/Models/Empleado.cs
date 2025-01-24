using System;
using System.Collections.Generic;

namespace Mapa_de_Clases.Models;

public partial class Empleado : MiembroDeLaComunidad
{
    public int Id { get; set; }

    public string? Puesto { get; set; }

    public int MiembroId { get; set; }

    public virtual ICollection<Administrativo> Administrativos { get; set; } = new List<Administrativo>();

    public virtual ICollection<Docente> Docentes { get; set; } = new List<Docente>();

    public virtual MiembroDeLaComunidad Miembro { get; set; } = null!;

    public Empleado()
    {
        
    }
}
