using System.ComponentModel.DataAnnotations;

namespace GiApiClientes.core.Models
{
    public record Cliente
    {
        public Cliente(string nome, string cPF, string telefoneFixo, string celular, string email,string tipoCliente, string bairro, string cep, string cidade, string complemento, string complemento2, string end, int numeroImovel, string uf)
        {
            Codigo = Guid.NewGuid();
            Nome = nome;
            CPF = cPF;
            Email = email;
            TelefoneFixo = telefoneFixo;
            Celular = celular;
            this.tipoCliente = tipoCliente;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Complemento = complemento;
            Complemento2 = complemento2;
            End = end;
            NumeroImovel = numeroImovel;
            Uf = uf;
        }

        [Key]
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string tipoCliente { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Complemento { get; set; }

        public string Complemento2 { get; set; }

        public string End { get; set; }

        public int NumeroImovel { get; set; }
        public string Uf { get; set; }


    }
}
