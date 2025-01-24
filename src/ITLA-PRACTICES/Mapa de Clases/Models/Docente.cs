using System;
using System.Collections.Generic;

namespace Mapa_de_Clases.Models;

public partial class Docente
{
    public int Id { get; set; }

    public int EmpleadoId { get; set; }

    public string? Especialidad { get; set; }

    public virtual ICollection<Administrador> Administradors { get; set; } = new List<Administrador>();

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual ICollection<Maestro> Maestros { get; set; } = new List<Maestro>();
}
