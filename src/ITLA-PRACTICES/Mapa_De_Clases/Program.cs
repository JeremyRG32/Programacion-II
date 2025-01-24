// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Xml.Linq;
public class Miembro_De_La_Comunidad
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Rol { get; set; }

    public Miembro_De_La_Comunidad(string name, string lastname, int id, string rol)
    {
        Rol = rol;
        ID = id;
        Name = name;
        LastName = lastname;
    }
    public virtual void ShowData()
    {
        Console.WriteLine($"ID: {ID}, Nombre: {Name}, Apellido: {LastName} Rol: {Rol}");
    }
}

public class Empleado : Miembro_De_La_Comunidad
{
    public string Position { get; set; }
    public Empleado(string name, string lastname, int id, string position, string rol) : base(name, lastname, id, rol)
    {
        ID = id;
        Position = position;
        Name = name;
        LastName = lastname;
        Rol = rol;
    }
    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine($"Puesto: {Position}");
    }
}
public class Estudiante : Miembro_De_La_Comunidad
{
    public string Career { get; set; }
    public Estudiante(string name, string lastname, int id, string career, string rol) : base(name, lastname, id, rol)
    {
        Name = name;
        LastName = lastname;
        ID = id;
        Career = career;
        Rol = rol;
    }
    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine($"Carrera: {Career}");
    }
}
public class ExAlumno : Miembro_De_La_Comunidad
{
    public DateOnly GraduationDate { get; set; }
    public ExAlumno(string name, string lastname, int id, DateOnly graduationdate, string rol ) : base(name, lastname, id, rol)
    {
        Name = name;
        LastName = lastname;
        ID = id;
        GraduationDate = graduationdate;
        Rol = rol;
    }
    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine($"Año de Graduación: {GraduationDate}");
    }
}
public class Docente : Empleado
{
    public string Subject { get; set; }
    public Docente(string name, string lastname, int id, string subject, string position, string rol) : base(name, lastname, id, position, rol)
    {
        Name = name;
        LastName = lastname;
        ID = id;
        Subject = subject;
        Position = position;
        Rol = rol;
    }
    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine($"Materia: {Subject}");
    }
}
public class Administrativo : Empleado
{
    public string Department { get; set; }
    public Administrativo(string name, string lastname, int id, string department, string position, string rol) : base(name, lastname, id, position, rol)
    {
        Name = name;
        LastName = lastname;
        ID = id;
        Position = position;
        Department = department;
        Rol = rol;
    }
    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine($"Departamento: {Department}");
    }
}
public class Administrador : Docente
{
    public Administrador(string name, string lastname, int id, string position, string subject, string rol) : base(name, lastname, id, subject, position, rol)
    {
        Name = name;
        LastName = lastname;
        ID = id;
        Position = position;
        Subject = subject;
        Rol = rol;
    }
    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine($"Rol: Administrador");
    }
}
public partial class Maestro : Docente
{
    public Maestro(string name, string lastname, int id, string position, string subject, string rol) : base(name, lastname, id, subject, position, rol)
    {
        Name = name;
        LastName = lastname;
        ID = id;
        Position = position;
        Subject = subject;
        Rol = rol;
    }
    public override void ShowData()
    {
        base.ShowData();
    }
}
class Program
{
    static List<Miembro_De_La_Comunidad> members = new List<Miembro_De_La_Comunidad>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("-----Sistema de Gestión de Comunidad----");
            Console.WriteLine("1. Agregar miembro");
            Console.WriteLine("2. Mostrar todos los miembros");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddMember(members);
                    break;
                case "2":
                    ShowAllMembers(members);
                    break;
                case "3":
                    Console.WriteLine("Cerrando la app...");
                    return;
                default:
                    Console.WriteLine("Opcion no valida\n");
                    break;
            }
            static void AddMember(List<Miembro_De_La_Comunidad> members)
            {
                Console.WriteLine("Agregar Miembro");
                Console.WriteLine("1. Estudiante");
                Console.WriteLine("2. Empleado");
                Console.WriteLine("3. ExAlumno");
                Console.WriteLine("4. Docente");
                Console.WriteLine("5. Administrativo");
                Console.WriteLine("6. Administrador");
                Console.WriteLine("7. Maestro");
                Console.Write("Seleccione el tipo de miembro: ");
                string type = Console.ReadLine();

                Console.Write("Ingrese el ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el Nombre: ");
                string name = Console.ReadLine();
                Console.Write("Ingrese el Apellido: ");
                string lastname = Console.ReadLine();
                string rol;

                switch (type)
                {

                    case "1":
                        rol = "Estudiante";
                        Console.Write("Ingrese la Carrera: ");
                        string career = Console.ReadLine();
                        members.Add(new Estudiante(name, lastname, id, career, rol));
                        break;
                    case "2":
                        rol = "Empleado";
                        Console.Write("Ingrese el Puesto: ");
                        string position = Console.ReadLine();
                        members.Add(new Empleado(name, lastname, id, position, rol));
                        break;
                    case "3":
                        rol = "ExAlumno";
                        Console.Write("Ingrese el Año de Graduación (yyyy-MM-dd): ");
                        DateOnly graduationDate = DateOnly.Parse(Console.ReadLine());
                        members.Add(new ExAlumno(name, lastname, id, graduationDate, rol));
                        break;
                    case "4":
                        rol = "Docente";
                        Console.Write("Ingrese la Materia: ");
                        string subject = Console.ReadLine();
                        Console.Write("Ingrese el Puesto: ");
                        string docentePosition = Console.ReadLine();
                        members.Add(new Docente(name, lastname, id, subject, docentePosition, rol));
                        break;
                    case "5":
                        rol = "Administrativo";
                        Console.Write("Ingrese el Departamento: ");
                        string department = Console.ReadLine();
                        Console.Write("Ingrese el Puesto: ");
                        string adminPosition = Console.ReadLine();
                        members.Add(new Administrativo(name, lastname, id, department, adminPosition, rol));
                        break;
                    case "6":
                        rol = "Administrador";
                        Console.Write("Ingrese el Puesto: ");
                        string adminRole = Console.ReadLine();
                        Console.Write("Ingrese la Materia: ");
                        string adminSubject = Console.ReadLine();
                        members.Add(new Administrador(name, lastname, id, adminRole, adminSubject, rol));
                        break;
                    case "7":
                        rol = "Maestro";
                        Console.Write("Ingrese el Puesto: ");
                        string maestroPosition = Console.ReadLine();
                        Console.Write("Ingrese la Materia: ");
                        string maestroSubject = Console.ReadLine();
                        members.Add(new Maestro(name, lastname, id, maestroPosition, maestroSubject, rol));
                        break;
                    default:
                        Console.WriteLine("Tipo no válido.");
                        break;
                }
            }
            static void ShowAllMembers(List<Miembro_De_La_Comunidad> members)
            {
                Console.WriteLine("\n--- Lista de Miembros ---");
                foreach (var member in members)
                {
                    member.ShowData();
                    Console.WriteLine("---------------------------------");
                }
            }
        }
    }
}
    