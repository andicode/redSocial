using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Entidades;

namespace Controladoras
{
    public class CUsuario
    {
        tablaUsuario dataUsuarios = tablaUsuario.Instance();


        public void AltaUsuario(String nom, String email, String ape, DateTime fecha, String pai, Char sex, String pass, String fot, Boolean esta)
        {
            Usuario auxUsu = new Usuario(nom, email, ape, fecha, pai, sex, pass, fot, esta);
            dataUsuarios.Agregar(auxUsu);
        }

        public Int64 Existe(String mail, String pass)
        {
            return 1;//dataUsuarios.Existe(mail, pass);
        }
    }
}
