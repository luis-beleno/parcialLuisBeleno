using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            String operacion = null;

            List<Usuario> ListaUsuario = new List<Usuario>();
            List<Blogs> ListaBlogs = new List<Blogs>();


            do
            {
                Console.WriteLine("Blogs");
                Console.WriteLine("---------------------------");
                Console.WriteLine("A. Crear Usuarios");
                Console.WriteLine("B. Listar Usuarios");
                Console.WriteLine("C. Crear Blogs del Usuario");
                Console.WriteLine("D. Listar Blogs del Usuario");
                Console.WriteLine("S. Salir");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Que accion quiere realizar \n[A] [B] [C] [D] [S]");
                operacion = Console.ReadLine();
                //Console.Read();
                Console.Clear();

                switch (operacion.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Codigo de Usuario: ");
                        String codigo = Console.ReadLine();
                        Console.WriteLine("Nombre de Usuario: ");
                        String usuario = Console.ReadLine();

                        ListaUsuario.Add(new Usuario(codigo, usuario));
                        System.Console.Read();
                        System.Console.Clear();
                        break;
                    case "B":
                        for(int i=0; i<ListaUsuario.Count(); i++)
                        {
                            Console.WriteLine("Codigo: {0}, Usuario {1}",ListaUsuario[i].Codigos,ListaUsuario[i].Usuarios);
                        }
                        System.Console.Read();
                        System.Console.Clear();
                        break;
                    case "C":
                        Console.WriteLine("Codigo del Usuario");
                        codigo = Console.ReadLine();
                        foreach(comCodigo in ListaU])
                        {
                            if (codigo == ListaUsuario[i].Codigos)
                            {
                                Console.WriteLine("Codigo del Blog");
                                String blogId = Console.ReadLine();
                                Console.WriteLine("Nombre del Blog");
                                String blogName = Console.ReadLine();
                            }
                            else { Console.WriteLine("No se puede crear un blog de un usuario que no existe"); }
                        }
                        break;
                    case "D":
                        break;
                    case "S":
                        break;
                }
            } while (operacion.ToUpper() != "S");
        }
    }
}
