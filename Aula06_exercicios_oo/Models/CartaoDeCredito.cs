using System;

namespace Aula06_exercicios_oo.Models
{
    public class CartaoDeCredito
    {

        public CartaoDeCredito(int id, int numero, DateTime dataValidade, Cliente cliente)
        {
            this.id = id;
            this.numero = numero;
            this.dataValidade = dataValidade;
            this.cliente = cliente;

        }
        public int id { get; private set; }
        public int numero { get; private set; }
        public DateTime dataValidade { get; private set; }
        public Cliente cliente { get; set; }


    }
}