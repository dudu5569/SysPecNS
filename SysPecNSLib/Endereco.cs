using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Endereco
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Tipo_Endereco { get; set; }


        public Endereco()
        {
            Cliente = new();
        }


        public Endereco(string? cep, string? logradouro, string? numero, string? complemento,
            string? cidade, string? bairro)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Bairro = bairro;
        }
        public Endereco(string? cep, string? numero, string? complemento,
            string? cidade, string? bairro)
        {
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Bairro = bairro;
        }

        public Endereco(string? cep, string? numero, 
            string? cidade, string? bairro)
        {
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
        }


 


        public Endereco(Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento,
             string? cidade, string? bairro)
        {
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Bairro = bairro;
        }

        public Endereco(Cliente cliente, string? cep, string? numero, string? complemento,
            string? cidade, string? bairro)
        {
            Cliente = cliente;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Bairro = bairro;
        }

        public Endereco(Cliente cliente, string? cep, string? numero,
            string? cidade, string? bairro)

        {
            Cliente = cliente;
            Cep = cep;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
        }

        public Endereco(Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uf, string? tipo_Endereco)

        {
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Tipo_Endereco = tipo_Endereco;
        }


        public void Inserir()
        {
            var command = Banco.Abrir();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_endereco_insert";
            command.Parameters.AddWithValue("spcliente_id", Cliente.Id);
            command.Parameters.AddWithValue("spcep", Cep);
            command.Parameters.AddWithValue("splogradouro", Logradouro);
            command.Parameters.AddWithValue("spnumero", Numero);
            command.Parameters.AddWithValue("spcomplemento", Complemento);
            command.Parameters.AddWithValue("spbairro", Bairro);
            command.Parameters.AddWithValue("spcidade", Cidade);
            command.Parameters.AddWithValue("spuf", Uf);
            command.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);
            var dr = command.ExecuteReader();
            while (dr.Read())Id = dr.GetInt32(0);
        }

        public static Endereco ObterPorId(int Id)
        {
            Endereco endereco = new();
            var command = Banco.Abrir();
            command.CommandType = CommandType.Text;
            command.CommandText = $"Select * from enderecos where id = {Id}";
            var dr = command.ExecuteReader();
            if (dr.Read())
            {
                endereco = new(
                    Cliente.ObterPorId(dr.GetInt32(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                    );
            }
            return endereco;
        }
    }
}
