﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    internal interface Interfaz_Padre<T>
    {
        public T BuscarInstanciaId(int i);
    }
}
