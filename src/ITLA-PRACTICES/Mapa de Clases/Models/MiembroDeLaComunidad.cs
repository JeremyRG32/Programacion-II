using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;

namespace Mapa_de_Clases.Models;

public partial class MiembroDeLaComunidad
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    public virtual ICollection<ExAlumno> ExAlumnos { get; set; } = new List<ExAlumno>();

    public void Add(string name, string lastname, int id)
    {
        using (var context = new ClassMapContext())
        {
            MiembroDeLaComunidad miembro = new MiembroDeLaComunidad()
            {
                Nombre = name,
                Apellido = lastname,
                Id = id
            };
            context.Add(miembro);
            context.SaveChanges();
        }
    }
    public List<MiembroDeLaComunidad> showdata()
    {
        using (var context = new ClassMapContext())
        {
            var miembros = context.MiembroDeLaComunidads.ToList();
            return miembros;
            
        }
    }
}
