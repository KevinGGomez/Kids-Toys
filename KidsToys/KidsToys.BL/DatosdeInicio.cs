using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsToys.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = "Kevin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario1 = new Usuario();

            nuevoUsuario1.Nombre = "Abigail";
            nuevoUsuario1.Contrasena = Encriptar.CodificarContrasena("456");


            var nuevoUsuario2 = new Usuario();

            nuevoUsuario2.Nombre = "Daniel";
            nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("789");

            contexto.Usuarios.Add(nuevoUsuario);
            contexto.Usuarios.Add(nuevoUsuario1);
            contexto.Usuarios.Add(nuevoUsuario2);

            base.Seed(contexto);
        }
    }
}
