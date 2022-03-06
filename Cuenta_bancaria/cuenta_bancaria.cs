using System;
using System.Collections.Generic;
using System.Text;

namespace Cuenta_bancaria
{
    public class cuenta_bancaria
    {
        public long Numero_cuenta { set; get; }
        public string Nombre_cliente { set; get; }
        public long Saldo_actual { set; get; }
        public double Interes { set; get; }

        public cuenta_bancaria()
        {
        }

        public cuenta_bancaria(long numero_cuenta, string nombre_cliente, long saldo_actual, double interes)
        {
            Numero_cuenta = numero_cuenta;
            Nombre_cliente = nombre_cliente;
            Saldo_actual = saldo_actual;
            Interes = interes;
        }

        public void Cliente(string nombre_cliente)
        {
             if (Nombre_cliente.Equals(nombre_cliente))
            {
                Console.WriteLine("El nombre del cliente es igual al nombre registrado ");
            }
            else
            {
                Console.WriteLine("El nombre del cliente no es igual al nombre del cliente registrado ");
            }
        }

       
    }

       




}
