using Flunt.Notifications;
using Flunt.Validations;
using GiApiClientes.core.Models;

namespace GiApiClientes.core.ViewModels
{
    public class CreateClienteViewModels : Notifiable<Notification>
    {


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


        public Cliente MapTo()
        {

            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNull(Nome, "Informe o  nome do cliente")
                .IsGreaterThan(Nome, 1, "O nome deve conter mais de 1 caracter"));


        return new Cliente(Nome, CPF, TelefoneFixo, Celular, Email, tipoCliente, Bairro, Cep, Cidade, Complemento, Complemento2, End, NumeroImovel, Uf);
        
        
        }

    }
}
