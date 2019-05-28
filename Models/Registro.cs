using System;

namespace AppEstacionamento.Models
{
    public class Registro
    {
        public ulong Id {get ; set ;}
        public CarroModel Carro {get; set;}
        public Cliente cliente {get; set;}
        public DateTime DataEntrada {get; set;}
    }
}