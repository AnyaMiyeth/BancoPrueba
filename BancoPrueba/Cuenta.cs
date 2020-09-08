using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoPrueba
{
    public class Cuenta
    {

        public decimal Saldo { get; set; }

        private List<Movimiento> movimientos;

       

        public Cuenta()
        {
            Saldo = 0;
            movimientos = new List<Movimiento>();
        }



        public string Retirar(decimal valor)
        {
            if (Saldo>=valor)
            {
                Saldo -= valor;
                Movimiento movimiento= new Movimiento();
                movimiento.Fecha = DateTime.Now;
                movimiento.Tipo = "Retiro";
                movimiento.Saldo = Saldo;
                movimiento.Valor = valor;
                movimientos.Add(movimiento);
                return $"Se Retiran{valor} su nuevo saldo es {Saldo}";
            }

            return $"No es posible realizar el retiro, saldo insuficinete";
        }


        public string Consignar(decimal valor)
        {
            Saldo += valor;
            Movimiento movimiento = new Movimiento();
            movimiento.Fecha = DateTime.Now;
            movimiento.Tipo = "Consignar";
            movimiento.Saldo = Saldo;
            movimiento.Valor = valor;
            movimientos.Add(movimiento);
            return $"Se Consigna {valor} su nuevo saldo es {Saldo}";
        }

        public string ConsultarSaldo()
        {
            return $"El saldo de la Cuenta es:{Saldo}";
        }

        public string Consultarextracto() 
        {
            string resumenMovimeinto=string.Empty;
            
            foreach (var item in movimientos)
            {
                resumenMovimeinto += $"Fecha {item.Fecha} Tipo {item.Tipo} valor {item.Valor} Saldo {item.Saldo} ";
            }
            return resumenMovimeinto;


        }

        
	
    }
}