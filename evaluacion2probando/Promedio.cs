using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion2probando
{
    public class Promedio
    {
        Double notafinal, prop;


        public string Nombre { get; set; }
        public int Ncuenta { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }


        //public int Calcularpromedio()
        //{
        //    notafinal = Nota1 + Nota2 + Nota3 + Nota4;
        //    prop = notafinal / 4;

        //    return;
        //}
        public Promedio(){}
        // constructores
        public Promedio(string _nombre, int _ncuenta, int _nota1, int _nota2, int _nota3, int _nota4)
        {
            Nombre = _nombre;
            Ncuenta = _ncuenta;
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;

        }
        public Promedio(string _nombre, int _ncuenta)
        {
            Nombre = _nombre;
            Ncuenta = _ncuenta;

        }



        public int SumaNumero(int Nota1, int Nota2, int Nota3, int Nota4)
        {
           
            int resultado = (Nota1 + Nota2 + Nota3 + Nota4)/4;
          

            return resultado;
        }
         

        

    }
}
