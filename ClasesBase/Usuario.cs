using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_Id;

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        private string usu_UserName;

        public string Usu_UserName
        {
            get { return usu_UserName; }
            set { usu_UserName = value; }
        }
        private string usu_Password;

        public string Usu_Password
        {
            get { return usu_Password; }
            set { usu_Password = value; }
        }
        private string usu_ApellidoNombre;

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }
        private int rol_Codigo;

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }
        public Usuario(string username, string password, int rol)
        {
            usu_UserName = username;
            usu_Password = password;
            rol_Codigo = rol;
        }

    }
}
