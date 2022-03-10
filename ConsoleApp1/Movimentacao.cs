using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Movimentacao
    {
        ContaCorrente Moverconta = new ContaCorrente();
        public double sacar()
        {
            Moverconta.saldo = sacar() - Moverconta.saldo;
            return Moverconta.saldo;
        }
        public double depositar()
        {
            Moverconta.saldo = depositar() + Moverconta.saldo;
            return Moverconta.saldo;
        }
    }
}
