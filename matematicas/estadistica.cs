﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematicas
{
    class estadistica
    {
        public double  suma = 0;

        public double media(string[] serie)
            {
            foreach (string valor in serie)
                suma += int.Parse(valor);
            }
        return suma / serie.length;
    }
    public double tipica(string[] serie)
    {
        double media_aritmetica = media(serie),
            suma = 0,
            estandar = 0;
        foreach (string valor in serie)
        {
            suma += Math.Pow(double.parse(valor) - media_aritmetica, 2);
        }
        return suma / serie.length;
    }
    public double tipica(string[]serie)
        {
        return Math.Sqrt(estandar(serie));
    }
}
