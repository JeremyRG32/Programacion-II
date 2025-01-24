using Mapa_de_Clases.Models;
bool running = true;
while(running)
{
    int selec;
    do
    {
        Console.WriteLine("Escriba el numero de la opcion que desea utilizar \n 1.Agregar 2.Ver Datos 3.Eliminar 4.Cerrar");
        selec = Convert.ToInt32(Console.ReadLine());
    }
    while (selec > 4 || selec < 1);

    switch (selec)
    {
        case 1:
            int add;
            Console.WriteLine("Que desea agregar \n 1.Miembro de la comunidad 2.Empleado 3.Estudiante 4.Exalumno 5.Docente 6.Administrativo 7.Maestro ");
            add = Convert.ToInt32(Console.ReadLine());
            switch (add)
            {
                case 1:
                    string name, lastname;
                    int memberid;
                    Console.WriteLine("Ingrese el ID");
                    memberid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre");
                    name = Console.ReadLine();
                    Console.WriteLine("Ingrese el apellido");
                    lastname = Console.ReadLine();
                    MiembroDeLaComunidad member = new MiembroDeLaComunidad();
                    member.Add(name, lastname, memberid);
                    break;
                case 2:
                    int employeeid;
                    string puesto;
                    Console.WriteLine("Ingrese el ID");
                    employeeid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el puesto");
                    puesto = Console.ReadLine();
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                default:
                    Console.WriteLine("Ingreso una opcion inexistente");
                    break;
            }
            break;
        case 2:
            MiembroDeLaComunidad miembro = new MiembroDeLaComunidad();
            List<MiembroDeLaComunidad> memberlist = new List<MiembroDeLaComunidad>();
            memberlist = miembro.showdata();
            foreach (var m in memberlist)
            {
                Console.WriteLine($"ID: {m.Id}, Nombre: {m.Nombre}, Apellido: {m.Apellido}");
            }
            break;

        case 3:

        case 4:
            Console.WriteLine("Saliendo del programa");
            running = false;
            break;
        default:
            Console.WriteLine("No ha seleccionado una opcion existente");
            break;
    }
}
