using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Fornecedor
    {
        public int Id { get; set; }

        public string? Razao_Social { get; set; }

        public string? Fantasia { get; set; }

        public string? Cnpj { get; set; }

        public string? Contato { get; set; }

        public string? Telefone { get; set; }

        public string? Email { get; set; }


        public Fornecedor(){}

        public Fornecedor(int id, string? razao_social, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            id = Id;
            razao_social = Razao_Social;
            fantasia = Fantasia;
                


        }
    }
}
