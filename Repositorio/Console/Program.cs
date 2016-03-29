﻿using NHibernate;
using Repositorio.Entidades;
using Repositorio.Infra;
using System;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            //NHibernateHelper.GeraSchema();
            ISession session = NHibernateHelper.AbreSession();
            /*
            try
            {
                Usuario u = new Usuario();
                u.Id = 7;
                u.Login = "AAA3";
                u.Senha = "1234";
                u.Nome = "testemudei";
                u.Gravar = true;
                u.Alterar = true;
                u.Deletar = true;

                u.Delete(session);

                /*
                Usuario u = new Usuario();
                u.Id = 3;
                u = u.BuscaPorId(session);

                Console.WriteLine(u.Nome);

                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    
                    Usuario u = new Usuario();
                    u.Login = "AAA2";
                    u.Senha = "1234";
                    u.Nome = "Administrador";
                    u.Gravar = true;
                    u.Alterar = true;
                    u.Deletar = true;

                    ClienteCPF c = new ClienteCPF();
                    c.Nome = "TESTE";
                    c.Endereco = "TESTE";
                    c.Bairro = "TESTE";
                    c.Cidade = "TESTE";
                    c.Telefone = "123456";
                    c.Celular = "123456";
                    c.Nome = "TESTE";
                    c.DataCadastro = DateTime.Now;
                    c.CPF = "123456";

                    OrigemDoPedido o = new OrigemDoPedido();
                    o.Descricao = "TESTE";

                    TipoDeServico ts = new TipoDeServico();
                    ts.Descricao = "TESTE";

                    TipoDePagamento tp = new TipoDePagamento();
                    tp.Descricao = "TESTE";

                    TipoDeArmazenamento ta = new TipoDeArmazenamento();
                    ta.Descricao = "TESTE";

                    Armazenamento a = new Armazenamento();
                    a.Descricao = "TESTE";
                    a.TipoDeArmazenamento = ta;


                    Pedido pe = new Pedido();
                    Pagamento p = new Pagamento();

                    pe.DataPedido = DateTime.Now;
                    pe.Descricao = "TESTE";
                    pe.Aplicacao = true;
                    pe.Criador = "TESTE";
                    pe.DataPrevisaoLayout = DateTime.Now;
                    pe.DataPrevisaoEntrega = DateTime.Now;
                    pe.HoraPrevisaoEntrega = Convert.ToString(DateTime.Now.Hour) + Convert.ToString(DateTime.Now.Minute);
                    pe.Observacao = "TESTE";
                    pe.Situacao = true;

                    pe.Usuario = u;
                    pe.Cliente = c;
                    pe.OrigemDoPedido = o;
                    pe.TipoDeServico = ts;
                    pe.Armazenamento = a;
                    pe.Pagamento = p;

                    p.Valor = 0;
                    p.Sinal = true;
                    p.ValorSinal = 0;
                    p.TipoDePagamento = tp;
                    p.Pedido = pe;                    

                    Console.WriteLine(u.Save(session));
                    Console.WriteLine(c.Adiciona(session));
                    Console.WriteLine(o.Adiciona(session));
                    Console.WriteLine(tp.Adiciona(session));
                    Console.WriteLine(ta.Adiciona(session));
                    Console.WriteLine(a.Adiciona(session));
                    Console.WriteLine(pe.Adiciona(session));
                    Console.WriteLine(p.Adiciona(session));
                    Console.WriteLine(ts.Adiciona(session));


                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine(ex.Message);
                }
            }            

            session.Close();
            Console.Read();
        }
    }
}
