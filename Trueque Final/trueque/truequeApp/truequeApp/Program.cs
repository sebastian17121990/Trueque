using truequeApp;

Console.WriteLine("Bienvenido al sistema de trueques");

int opc = -1;

List<Usuario> usuarios = new List<Usuario>();
do
{
    Console.WriteLine("Menú");
    Console.WriteLine("1) Ingresar Usuario");
    Console.WriteLine("2) Ingresar Articulo");
    Console.WriteLine("3) Realizar trueque");
    Console.WriteLine("4) Mostrar articulos");
    Console.WriteLine("5) Salir");
    opc = Convert.ToInt32(Console.ReadLine());

    switch (opc)
    {
        case 1:
            Console.WriteLine("Ingrese un R.U.T.:");
            string rut = Console.ReadLine();
            Console.WriteLine("Ingrese un nombre:");
            string nombre = Console.ReadLine();
            Usuario usuario = new Usuario(rut, nombre);
            usuarios.Add(usuario);
            Console.WriteLine("Usuario creado!!!");


            break;
        case 2:
            Console.WriteLine("Seleccione un usuario:");
            
            for (int i = 0; i< usuarios.Count; i++)
            {
                Usuario obj = usuarios[i];
                Console.WriteLine((i + 1) + ") " + obj.getNombre() + " " + obj.getRut() + ".");
            }

            int opc2 = -1;
            
            do
            {
                opc2 = Convert.ToInt32(Console.ReadLine());
                if (opc2 < 1 || opc2 > usuarios.Count)
                {
                    Console.WriteLine("Ese usuario no existe en la lista. Intente otra vez!!!");
                }

            } while (opc2 < 1 || opc2 > usuarios.Count);
            Usuario obj2 = usuarios[(opc2 - 1)];




             Console.WriteLine("Ingrese el codigo del producto:");
             int codigo = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ingrese el nombre del producto:");
             nombre = Console.ReadLine();
             Articulo articulo = new Articulo(codigo, nombre);
             obj2.articulos.Add(articulo);
             Console.WriteLine("Artículo agregado!!!");
            break;
        case 3:
            Console.WriteLine("Seleccione un usuario:");

            for (int i = 0; i < usuarios.Count; i++)
            {
                Usuario obj = usuarios[i];
                Console.WriteLine((i + 1) + ") " + obj.getNombre() + " " + obj.getRut() + ".");
            }

            int opc_usuario1 = -1;

            do
            {
                opc_usuario1 = Convert.ToInt32(Console.ReadLine());
                if (opc_usuario1 < 1 || opc_usuario1 > usuarios.Count)
                {
                    Console.WriteLine("Ese usuario no existe en la lista. Intente otra vez!!!");
                }

            } while (opc_usuario1 < 1 || opc_usuario1 > usuarios.Count);
            
            
            Usuario usuario1 = usuarios[(opc_usuario1 - 1)];

            Console.WriteLine("Seleccione un articulo:");

            for (int i = 0; i < usuario1.articulos.Count; i++)
            {
                Articulo obj = usuario1.articulos[i];
                Console.WriteLine((i + 1) + ") " + obj.getCodigo() + " " + obj.getNombre() + ".");
            }

            int opc_articulo1 = -1;

            do
            {
                opc_articulo1 = Convert.ToInt32(Console.ReadLine());
                if (opc_articulo1 < 1 || opc_articulo1 > usuario1.articulos.Count)
                {
                    Console.WriteLine("Ese artículo no existe en la lista. Intente otra vez!!!");
                }

            } while (opc_articulo1 < 1 || opc_articulo1 > usuario1.articulos.Count);
            Articulo articulo1 = usuario1.articulos[(opc_articulo1 - 1)];


            Console.WriteLine("Seleccione un usuario:");

            for (int i = 0; i < usuarios.Count; i++)
            {
                if((opc_usuario1 - 1) != i)
                {
                    Usuario obj = usuarios[i];
                    Console.WriteLine((i + 1) + ") " + obj.getNombre() + " " + obj.getRut() + ".");
                }                
            }

            int opc_usuario2 = -1;

            do
            {
                opc_usuario2 = Convert.ToInt32(Console.ReadLine());
                if (opc_usuario2 < 1 || opc_usuario2 > usuarios.Count)
                {
                    Console.WriteLine("Ese usuario no existe en la lista. Intente otra vez!!!");
                }

            } while (opc_usuario2 < 1 || opc_usuario2 > usuarios.Count);


            Usuario usuario2 = usuarios[(opc_usuario2 - 1)];

            Console.WriteLine("Seleccione un articulo:");

            for (int i = 0; i < usuario2.articulos.Count; i++)
            {
                Articulo obj = usuario2.articulos[i];
                Console.WriteLine((i + 1) + ") " + obj.getCodigo() + " " + obj.getNombre() + ".");
            }

            int opc_articulo2 = -1;

            do
            {
                opc_articulo2 = Convert.ToInt32(Console.ReadLine());
                if (opc_articulo2 < 1 || opc_articulo2 > usuario2.articulos.Count)
                {
                    Console.WriteLine("Ese artículo no existe en la lista. Intente otra vez!!!");
                }

            } while (opc_articulo2 < 1 || opc_articulo2 > usuario2.articulos.Count);
            Articulo articulo2 = usuario2.articulos[(opc_articulo2 - 1)];


            usuario1.articulos[opc_articulo1 - 1] = articulo2;
            usuario2.articulos[opc_articulo2 - 1] = articulo1;

            Console.WriteLine("Se ha llevado a cabo el trueque!!!");






            break;
        case 4:
            Console.WriteLine("Seleccione un usuario:");

            for (int i = 0; i < usuarios.Count; i++)
            {
                Usuario obj = usuarios[i];
                Console.WriteLine((i + 1) + ") " + obj.getNombre() + " " + obj.getRut() + ".");
            }

            int select = -1;

            do
            {
                select = Convert.ToInt32(Console.ReadLine());
                if (select < 1 || select > usuarios.Count)
                {
                    Console.WriteLine("Ese usuario no existe en la lista. Intente otra vez!!!");
                }

            } while (select < 1 || select > usuarios.Count);
            Usuario usuario_ = usuarios[(select - 1)];

            Console.WriteLine("Los articulos son:");

            for (int i = 0; i < usuario_.articulos.Count; i++)
            {
                Articulo obj = usuario_.articulos[i];
                Console.WriteLine((i + 1) + ") " + obj.getCodigo() + " " + obj.getNombre() + ".");
            }

            break;
        case 5:
            Console.WriteLine("Hasta pronto");
            break;
        default:
            Console.WriteLine("Esa opcion no existe.");
            break;
    }

} while (opc != 5);



