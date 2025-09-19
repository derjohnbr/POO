using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Heranca
{
    internal abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome;
        public string Telefone;

        public abstract string GetDocumento();

        public void Imprimir()
        {
            Console.WriteLine($"LISTA DE PESSOAS\n\nNome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}\n");
        }

        public override string ToString()
        {
            return $"<ToString>: Nome: {this.Nome} Documento: {this.GetDocumento()} Telefone: {this.Telefone}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj == null /*|| this.GetType() != obj.GetType()*/)
                return false;

            //Cast=> Conversão de Objeto
            //((Pessoa)obj)=> Converte obj que é do tipo objeto para tipo Pessoa
            return this.Id == ((Pessoa)obj).Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
