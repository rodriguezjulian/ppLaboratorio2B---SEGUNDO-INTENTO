﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    [Serializable]
    public class fechaException : Exception
    {
        public fechaException() { }


        public fechaException(string message)
            : base(message)
        {     
        }
    }

}
