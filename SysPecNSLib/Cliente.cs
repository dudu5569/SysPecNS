using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; } 
        public string? Telefone { get; set;}
        public string? Email { get; set; }
        public DateTime? Data_nasc { get; set; }
        public DateTime? Data_cad { get; set; } = DateTime.Now;
        public bool Ativo { get; set; }

        public Cliente()
        {
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? data_nasc, DateTime? data_cad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone,
            string? email, DateTime? data_nasc, DateTime? data_cad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Data_nasc = data_nasc;
            Data_cad = data_cad;
            Ativo = ativo;
        }

        public void Adicionar_Cliente()
        {
            var command = Banco.Abrir();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cliente_insert";
            command.Parameters.AddWithValue("spnome", Nome);
            command.Parameters.AddWithValue("spcpf", Cpf);
            command.Parameters.AddWithValue("sptelefone", Telefone);
            command.Parameters.AddWithValue("spemail", Email);
            command.Parameters.AddWithValue("spdatanasc", Data_nasc);
            var dr = command.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }


        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var command = Banco.Abrir();
            command.CommandType = CommandType.Text;
            command.CommandText = $"select * from clientes where id = {id}";
            var dr = command.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                    );
            }
            return cliente;
        }

        public static List<Cliente> ObterLista(string? nome = "")
        {
            List<Cliente> lista = new();
            var command = Banco.Abrir();
            command.CommandType = CommandType.Text;
            if (nome == "")
            {
                command.CommandText = "select * from clientes order by nome limit 10";
            }
            else
            {
                command.CommandText = $"select * from usuarios where nome like '%{nome}%' order by nome";
            }
            var dr = command.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                        )
                    );
            }
            return lista;
        }


        public void atualizar()
        {
            var command = Banco.Abrir();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_cliente_update";

            command.Parameters.AddWithValue("spid", Id);
            command.Parameters.AddWithValue("spnome", Nome);
            command.Parameters.AddWithValue("sptelefone", Telefone);
            command.Parameters.AddWithValue("spdatanasc", Data_nasc);
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public static void Arquivar(int id)
        {
            var command = Banco.Abrir();
            command.CommandType = CommandType.Text;
            command.CommandText = $"update usuarios set ativo = 0 where id = {id}";
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public static void Restaurar(int id)
        {
            var command = Banco.Abrir();
            command.CommandType = CommandType.Text;
            command.CommandText = $"update usuarios set ativo = 1 where id = {id}";
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        
        


    }
}
