using System;

namespace EjProgramacion2_POO_4
{
    class Program
    {
        /*
        Se quiere crear una clase Cuenta la cual se caracteriza por tener asociado
        un número de cuenta y un saldo disponible. Además, se puede consultar
        el saldo disponible en cualquier momento, recibir abonos y pagar recibos.
        Crear además una clase Persona, que se caracteriza por un DNI y un array
        de cuentas bancarias. La Persona puede tener asociada hasta 3 cuentas
        bancarias, y debe tener un método que permite añadir cuentas (hasta 3
        que es el máximo). También debe contener un método que devuelva si la
        persona es morosa, i.e., si tienen alguna cuenta con saldo negativo.
        Crear una clase PruebaCuentas que instancie un objeto Persona con un
        dni cualquiera, así como dos objetos cuenta, una sin saldo inicial y otra
        con 700 euros. La persona recibe la nómina mensual, por lo que ingresa
        1100 euros en la primera cuenta, pero tiene que pagar el alquiler de 750
        euros con la segunda. Imprimir por pantalla el si la persona es morosa.
        Posteriormente hacer una transferencia de una cuenta a otra y comprobar
        mostrándolo por pantalla que cambia el estado de la persona.
        */
        static void Main(string[] args)
        {
            Persona unaPersona = new Persona("012345678A");
            unaPersona.crearCuenta(123, 0);
            Console.WriteLine("Primer cuenta {0}", unaPersona.Cuentas[0].numCuenta);

            unaPersona.crearCuenta(555, 1);
            Console.WriteLine("Segunda cuenta {0}", unaPersona.Cuentas[1].numCuenta);

            unaPersona.Cuentas[1].saldo = 700;
            unaPersona.Cuentas[0].recibirAbono(1100);
            unaPersona.Cuentas[1].pago(750);

            Console.WriteLine("Es Morosa {0}", unaPersona.esMorosa());

            // Transferencia
            unaPersona.Cuentas[0].pago(100);
            unaPersona.Cuentas[1].recibirAbono(100);

            Console.WriteLine("Es Morosa {0}", unaPersona.esMorosa());

        }

    }

    public class Cuenta
    {
        private int vCuenta;
        

        public int numCuenta
        {
            get { return vCuenta; }
            set
            {
                if (value < 0)
                    vCuenta = 0;
                else
                    vCuenta = value;
            }
        }

        public double saldo { get; set; }

        

        public void mostrarSaldo()
        {
            Console.WriteLine("El saldo de la cuenta es: {0}", saldo);
        }

        public void recibirAbono(double pImporte)
        {
            saldo = saldo + pImporte;
        }
        public void pago(double pImporte)
        {
            saldo = saldo - pImporte;
        }
    }

    class Persona
    {

        private Cuenta[] vCuentas = new Cuenta[3];
        public string DNI { get; set; }
        public Cuenta[] Cuentas
        {
            get { return vCuentas; }
            set { vCuentas = value; }

        }

        public Persona(string pDNI)
        {
            DNI = pDNI;
        }

        public void crearCuenta(int pCuenta, int pIndiceCuenta)
        {
            if (Cuentas[pIndiceCuenta] == null)
            {
                if (pIndiceCuenta >= 0 && pIndiceCuenta <= 2)
                {
                    Cuentas[pIndiceCuenta] = new Cuenta();
                    Cuentas[pIndiceCuenta].numCuenta = pCuenta;
                }
                else
                    Console.WriteLine("No pueden haber más de 3 cuentas por persona");
            }
            else
                Console.WriteLine("Ya existe una cuenta en ese subíndice");
        }

        public bool esMorosa()
        {
            bool vMoroso = false;
            foreach(Cuenta c in Cuentas)
            {
                if ( c != null)
                {
                    if (c.saldo < 0)
                        vMoroso = true;
                    else
                        vMoroso = false;
                }
            }
            return vMoroso;
        }
    }
}
