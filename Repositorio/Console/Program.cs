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
            try
            {
                Usuario u = new Usuario();                
                u.Login = "ADM";
                u.Senha = "1234";
                u.Nome = "Administrador";
                u.Gravar = true;
                u.Alterar = true;
                u.Deletar = true;
                Console.WriteLine(Convert.ToInt64(u.Adiciona(session)));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            session.Close();
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
