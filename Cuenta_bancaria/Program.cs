using System;

namespace Cuenta_bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("   | Cuenta Bancaria |  ");
            Console.WriteLine("-------------------------");

            cuenta_bancaria Banco = new cuenta_bancaria ();
            Console.WriteLine("  N° Cuenta : ");
            Banco.Numero_cuenta = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(" Nombre : ");
            Banco.Nombre_cliente = Console.ReadLine();
            Console.WriteLine(" Saldo Actual : ");
            Banco.Saldo_actual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Interes Anual");
            Banco.Interes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("********** Los Datos Registrados son*************");
            Console.WriteLine(" Numero de cuenta : "+Banco.Numero_cuenta);
            Console.WriteLine(" Nombre del propietario de la cuenta : "+Banco.Nombre_cliente);
            Console.WriteLine(" Saldo actual de la cuenta : "+Banco.Saldo_actual);
            Console.WriteLine(" Interes Anual : "+Banco.Interes + "%\n");
            Banco.Cliente("Lizbeth");
            Console.WriteLine("-----------------------------------------------------");
            // constructor con parametros 

            cuenta_bancaria banca1 = new cuenta_bancaria(2205045196 , " Estefania ", 630, 4.2);
            Console.WriteLine("Numero de cuenta: "+banca1.Numero_cuenta);
            Console.WriteLine("Nombre del propietario: " + banca1.Nombre_cliente);
            Console.WriteLine(" Saldo actual: " + banca1.Saldo_actual);
            Console.WriteLine(" Interes Anual : " + banca1.Interes + "%\n");
          banca1.Cliente(" Brenda ");
            Console.ReadKey();
        }
    }
}
