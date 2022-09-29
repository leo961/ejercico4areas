using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculador_AreaWS
{
    public class CalcularArea
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }

        public double pi = 3.1416;
        public decimal numero3 { get; set; }

        public decimal Area_Cuadrado(decimal lado)
        {


            return lado*lado ;
        }


        public decimal Area_triangulo(decimal base1,  decimal altura)
        {
        
            numero1= base1;
            numero2= altura;
            numero3 = (base1 * altura) / 2;

            return numero3 ;
        }

        public decimal Area_circulo(decimal radio)
        {

            numero1 = radio;

            
            numero3 = ((decimal)pi) * (radio*radio);

            return numero3;
        }

    }
}