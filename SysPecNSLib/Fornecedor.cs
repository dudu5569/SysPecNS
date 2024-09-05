using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
            cnpj = Cnpj;
            contato = Contato;
            telefone = Telefone;
            email = Email;
        }

        public Fornecedor(string? razao_social, string? fantasia, string? cnpj, string? contato, string? telefone, string? email)
        {
            razao_social = Razao_Social;
            fantasia = Fantasia;
            cnpj = Cnpj;
            contato = Contato;
            telefone = Telefone;
            email = Email;
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_insert";
            cmd.Parameters.AddWithValue("sprazao_social", Razao_Social);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }


        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sprazao_social", Razao_Social);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", Cnpj);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
        }

        public static Fornecedor ObterPorId(int id)
        {
            Fornecedor fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from fornecedores where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor = new(
                   dr.GetInt32(0),
                   dr.GetString(1),
                   dr.GetString(2),
                   dr.GetString(3),
                   dr.GetString(4),
                   dr.GetString(5),
                   dr.GetString(6)
               );
            }
            return fornecedor;
        }

        public static List<Fornecedor> ObterLista()
        {
            List<Fornecedor> fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from fornecedores order by razao_social";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    ));
            }
            return fornecedor;
        }
    }
}
