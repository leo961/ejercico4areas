using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculador_AreaWS
{
    /// <summary>
    /// Descripción breve de CalculadorAreaWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculadorAreaWebService1 : System.Web.Services.WebService
    {

        //Leonardo Ruiz Lopez  grpo J

 
        [WebMethod]
        public decimal Cuadrado(decimal lado)
        {
            CalcularArea c = new CalcularArea();

            return c.Area_Cuadrado(lado);
        }
        [WebMethod]
        public decimal Triangulo(decimal base1, decimal altura)
        {
            CalcularArea c = new CalcularArea();
            

            return c.Area_triangulo(base1,altura );
        }

        [WebMethod]
        public decimal circulo(decimal radio)
        {
            CalcularArea c = new CalcularArea();


            return c.Area_circulo(radio);
        }
    }
}
