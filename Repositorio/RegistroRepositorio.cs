using System;
using System.IO;
using AppEstacionamento.Models;

namespace AppEstacionamento.Repositorio
{
    public class RegistroRepositorio
    {
        private const string PATH = "DataBase/Pedido.csv";
        public bool  Inserir(Registro registro )
        {

            try{

            if(!File.Exists("DataBase/Registro.csv"))
            {
                File.Create("DataBase/Registro.csv").Close();
            }

            var reegistro = $"{registro.cliente.NomeCondutor};{registro.Carro.Placa};{registro.Carro.ModeloDoCarro};{registro.Carro.MarcaDoCarro}\n";

            File.AppendAllText("DataBase/Registro.csv", reegistro);
            } catch(Exception e)
            {
                System.Console.WriteLine("Chegou no catch");
                System.Console.WriteLine(e.StackTrace);
            }

            return true;
        }
    }
}