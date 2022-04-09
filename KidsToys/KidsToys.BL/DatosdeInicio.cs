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

            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            nuevoUsuario.Nombre = "Abigail";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("456");

            nuevoUsuario.Nombre = "Daniel";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("789");

            contexto.Usuarios.Add(nuevoUsuario);

            base.Seed(contexto);
        }
    }
}
