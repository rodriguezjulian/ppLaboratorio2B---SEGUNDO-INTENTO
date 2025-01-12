﻿using Enumerado;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    [FirestoreData]
    public class Empleado : Usuario
    {
        private int _idEmpleado;
        private Puestos _puesto;
        public Empleado() { }
        public Empleado(string nombre, string contraseña) : base(nombre, contraseña) { }
        public Empleado(string nombre, string contraseña, string mail, bool estado, Puestos puesto) :
            base(nombre, contraseña, mail, estado)
        {
            // this.IdEmpleado = idEmpleado;
            this.Puesto = puesto;
        }
        [FirestoreProperty]
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        [FirestoreProperty]
        public Puestos Puesto { get => _puesto; set => _puesto = value; }
      
        public static bool operator ==(Empleado uno, Usuario dos)
        {
            bool retorno = false;
            if ((uno.Nombre == dos.Nombre) && (uno.Contraseña == dos.Contraseña))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Empleado uno, Usuario dos)
        {
            return !(uno == dos);
        }
        public bool Equals(Empleado uno, Usuario dos)
        {
            bool retorno = false;
            if ((uno.Nombre == dos.Nombre) && (uno.Contraseña == dos.Contraseña))
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
