using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using renatodavis.app.domain.entities;

namespace renatodavis.app.infra.Contexto
{
    public static class DbInicializer
    {
        public static void Inicialize(AppContexto contexto)
        {
            if (contexto.Clientes.Any())
            {
                return;
            }
            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Renato Davis"
                },
                new Cliente
                {
                    Nome ="Simone"
                }
            };
            contexto.AddRange(clientes);
            var GrupoProdutos = new GrupoProduto[]
            {
                new GrupoProduto
                {
                    GrupoProdutoId = 1,
                    Nome = "Grupo 01"
                }
            };
            contexto.AddRange(GrupoProdutos);
            var produtos = new Produto[]
            {
                new Produto
                {
                     Descricao = "Produto 01",
                     GrupoProdutoId = 1,
                     Cliente = clientes[1]
                },
                new Produto
                {
                    Descricao = "Produto 02",
                    Cliente = clientes[0]
                }

            };
            contexto.AddRange(produtos);


        }
    }
}
