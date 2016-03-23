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
            NHibernateHelper.GeraSchema();
            /*ISession session = NHibernateHelper.AbreSession();
            try
            {
                Usuario u = new Usuario();
                Usuario u2 = new Usuario();
                u.Login = "";
                u.Senha = "1234";
                u.Nome = "Administrador";
                u.Gravar = true;
                u.Alterar = true;
                u.Deletar = true;


                u2.Login = "IAGO";
                u2.Senha = "1234";
                u2.Nome = "Administrador";
                u2.Gravar = true;
                u2.Alterar = true;
                u2.Deletar = true;

                u.Adiciona(session);
                u2.Adiciona(session);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            session.Close();*/
            Console.Read();
            /*using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {               
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }
            }
            */
        }
    }
}
