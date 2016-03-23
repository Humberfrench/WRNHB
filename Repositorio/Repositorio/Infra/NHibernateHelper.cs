using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace Repositorio.Infra
{
    public class NHibernateHelper
    {
        //FABRICA DE SESSION UNICA PARA O SISTEMA INTEIRO
        private static ISessionFactory fabrica = CriaSessionFactory();

        //CRIA UMA SESSION Factory com base na configuracao
        //para o nhibernate abrir varias fabricas de session e um processo muito custoso por isso abre somente uma fabrica de session para todo o sistema
        private static ISessionFactory CriaSessionFactory()
        {
            Configuration cfg = RecuperaConfiguracao();
            return cfg.BuildSessionFactory();
        }
        //RECUPERA TODAS AS CONFIGURACOES DO BANCO COM O NH IBERNETE
        public static Configuration RecuperaConfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            return cfg;
        }
        //GERA AS TABELAS DO BD COM BASE NOS MAPEAMENTOS FEITOS
        public static void GeraSchema()
        {
            Configuration cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }

        //ABRE UMA NOVA SESSION
        public static ISession AbreSession()
        {
            return fabrica.OpenSession();
        }

    }
}