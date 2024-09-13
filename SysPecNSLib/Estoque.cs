using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {

        public Produto produtoId { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? Data_Ultimo_Movimento { get; set; }

        public Estoque() { }

        public Estoque(Produto produtoId, int? quantidade, DateTime? data_Ultimo_Movimento)
        {
            this.produtoId = produtoId;
            Quantidade = quantidade;
            Data_Ultimo_Movimento = data_Ultimo_Movimento;
        }


        public static Estoque ObterPorId(int Id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"Select * from estoques where id = {Id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                    Produto.ObterPorId(dr.GetInt32(0)),
                    dr.GetInt32(1),
                    dr.GetDateTime(2)
                    );
            }
            return estoque;

        }


        public static List<Estoque> ObterLista (string? nome = "")
        {
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "Select * from estoques order by quantidade";
            }
            else
            {
                cmd.CommandText = "Select * from estoques order by produto_id";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        Produto.ObterPorId(dr.GetInt32(0)),
                        dr.GetInt32(1),
                        dr.GetDateTime(2)
                        ));
            }

            return lista;
        }


    }
}
