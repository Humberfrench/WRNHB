using NHibernate;
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
            ///*
            try
            {
                Usuario u = new Usuario();
                u.Id = 1;
                u = u.BuscaPorId(session);

                Console.WriteLine(u.Nome);
                Console.WriteLine(u.Pedidos.Count);

                ClienteCPF c = new ClienteCPF();
                c.Id = 1;
                c = c.BuscaPorId(session);

                Console.WriteLine(c.CPF);
                Console.WriteLine(c.Pedidos.Count);

                Console.Read();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //*/
            
            /*          
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    
                    Usuario u = new Usuario();
                    u.Login = "AAA";
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

                    Console.WriteLine(Convert.ToInt64(u.Adiciona(session)));
                    Console.WriteLine(Convert.ToInt64(c.Adiciona(session)));
                    Console.WriteLine(Convert.ToInt64(o.Adiciona(session)));
                    Console.WriteLine(Convert.ToInt64(tp.Adiciona(session)));
                    Console.WriteLine(Convert.ToInt64(ta.Adiciona(session)));
                    Console.WriteLine(Convert.ToInt64(a.Adiciona(session)));
                    Console.WriteLine(Convert.ToInt64(pe.Adiciona(session)));
                    Console.WriteLine(Convert.ToInt64(p.Adiciona(session)));
                    Console.WriteLine(Convert.ToInt64(ts.Adiciona(session)));



                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine(ex.Message);
                }
            }
            */

            session.Close();
            Console.Read();
        }
    }
}
