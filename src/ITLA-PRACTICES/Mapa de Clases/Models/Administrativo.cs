using System;
using System.Collections.Generic;

namespace Mapa_de_Clases.Models;

public partial class Administrativo
{
    public int Id { get; set; }

    public int EmpleadoId { get; set; }

    public string? Departamento { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;
}
