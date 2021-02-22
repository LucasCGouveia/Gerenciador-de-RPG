using System;
using System.Data;
using System.Data.SqlClient; //Importar SQL
using Gerenciador.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
//using System.Threading.Tasks;


namespace Gerenciador.Repository
{
    public class ConexaoDB : DbContext
    {
        Resultado resultado = new Resultado();
        public static ClnFuncoesGerais.Operacao ObjOperacao;//Variável Enum Cep
        public ClnFuncoesGerais.Operacao EnumProperty//Propriedade p guardar Cep
        {
            get { return ObjOperacao; }
            set { ObjOperacao = value; }
        }
        //================================================================
        public static SqlConnection AbreBanco()
        {
            string StringConexao = @"Data Source=NOTNEWMIGHT\SQNPRD001;Initial Catalog=DasmeDB;Persist Security Info=True;User ID=sa;Password=010921";
            try
            {
                SqlConnection conn = new SqlConnection(StringConexao);
                conn.ConnectionString = StringConexao;
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //================================================================
        public void FechaBanco(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //================================================================
        public DataSet RetornaDataSet(string strQuery)
        {
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmdComando = new SqlCommand(strQuery, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmdComando);
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw e;//or MessageBox(e.Message);
            }
            finally
            {
                FechaBanco(conn);
            }
        }
        //================================================================
        public IDataReader RetornaDataReader(string strQuery)
        {
            try
            {
                IDataReader dr;
                SqlCommand OracleComando = new SqlCommand(strQuery, AbreBanco());
                dr = OracleComando.ExecuteReader();
                return dr;
            }
            catch (Exception e)
            {
                throw e;//or MessageBox(e.Message);
            }
            //finally
            //{
            // //FechaBanco(conn);
            //}
        }
        //================================================================
        //================================================================
        public DataTable RetornaDataTable(string strQuery)
        {
            try
            {
                SqlCommand command;
                SqlDataAdapter dataAdapter;

                //Aqui você abre a conexão com o banco

                //Consulta
                command = new SqlCommand(strQuery, AbreBanco());

                //Intermediario recebe a respota do comandos sql enviado  
                dataAdapter = new SqlDataAdapter(command);

                //Estrutura da tabela 
                DataTable objDataTable = new DataTable();

                //Preencher com a estrutura do select enviado com as tuplas
                dataAdapter.Fill(objDataTable);

                return objDataTable;
            }
            catch (Exception e)
            {
                throw e;//or MessageBox(e.Message);
            }
        }

        //public IEnumerable<T> RetornaLista(string strQuery)
        //{
        //    try
        //    {
        //        SqlCommand command;
        //        SqlDataAdapter dataAdapter;

        //        //Aqui você abre a conexão com o banco

        //        //Consulta
        //        command = new SqlCommand(strQuery, AbreBanco());

        //        //Intermediario recebe a respota do comandos sql enviado  
        //        dataAdapter = new SqlDataAdapter(command);

        //        //Estrutura da tabela 
        //        List<Tb_Usuarios> objDataTable = new List<Tb_Usuarios>();


        //        return objDataTable;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;//or MessageBox(e.Message);
        //    }
        //    //finally
        //    //{
        //    // //FechaBanco(conn);
        //    //}
        //}
        public void ExecutaComando(string strQuery)
        {
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                SqlCommand sqlComm = new SqlCommand(strQuery, conn);
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally //Em caso de erro ou não, o finally é executado para fechar a conexao com bd
            {
                FechaBanco(conn);
            }
        }

        public Resultado Executar(string strQuery)
        {
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                SqlCommand sqlComm = new SqlCommand(strQuery, conn);
                sqlComm.ExecuteNonQuery();
                resultado.sucesso = true;
            }
            catch (Exception ex)
            {
                resultado.sucesso = false;
                resultado.exception = ex;
            }
            finally //Em caso de erro ou não, o finally é executado para fechar a conexao com bd
            {
                FechaBanco(conn);
            }
            return resultado;
        }
        public DataTable GetTable(string strQuery)
        {
            Resultado resultado = new Resultado();
            SqlConnection conn;
            conn = AbreBanco();
            try
            {
                SqlCommand sqlComm = new SqlCommand(strQuery, conn);
                sqlComm.ExecuteNonQuery();
                resultado.sucesso = true;

                SqlDataAdapter dp = new SqlDataAdapter(sqlComm);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                resultado.sucesso = false;
                resultado.exception = ex;
                throw;
            }
            finally //Em caso de erro ou não, o finally é executado para fechar a conexao com bd
            {
                FechaBanco(conn);
            }
        }

        //================================================================================================================================================================================
        //================================================================================================================================================================================
        //================================================================================================================================================================================
        //================================================================================================================================================================================
        //================================================================================================================================================================================

        public ConexaoDB() : base("StrConexao")
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            var objectContext = (this as IObjectContextAdapter).ObjectContext;
            objectContext.CommandTimeout = 500;
        }

        public DbSet<TabUsuarios> TabUsuarios { get; set; }
        public DbSet<TabCampanhas> TabCampanhas { get; set; }
        public DbSet<TabPersonagens> TabPersonagens { get; set; }
        public DbSet<TabJogadores> TabJogadores { get; set; }
        public DbSet<TabRacas> TabRacas { get; set; }
        public DbSet<TabClasses> TabClasses { get; set; }
        public DbSet<TabItens> TabItens { get; set; }
        public DbSet<TabSkills> TabSkills { get; set; }
        public DbSet<TabAtributos> TabAtributos { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove as convenções do entity framework
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Mapeia a chave primária dinamicamente
            modelBuilder.Properties()
                        .Where(x => x.Name == "COD")
                        .Configure(x => x.IsKey());

            modelBuilder.Properties<string>().Configure(x => x.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(x => x.HasMaxLength(100));
            modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime"));
            
            modelBuilder.Properties()
            .Where(x => x.Name == "COD")
            .Configure(x => x.IsKey());

            modelBuilder.Properties<string>()
                .Where(x => x.Name.ToLower() == "mensagem")
                .Configure(x => x.HasMaxLength(8000));

            //Adiciona as configurações das tabelas
            modelBuilder.Configurations.Add(new TabUsuarios());
            modelBuilder.Configurations.Add(new TabCampanhas());
            modelBuilder.Configurations.Add(new TabPersonagens());
            modelBuilder.Configurations.Add(new TabJogadores());
            modelBuilder.Configurations.Add(new TabRacas());
            modelBuilder.Configurations.Add(new TabClasses());
            modelBuilder.Configurations.Add(new TabItens());
            modelBuilder.Configurations.Add(new TabSkills());
            modelBuilder.Configurations.Add(new TabAtributos());


            //Database.SetInitializer<Context>(new DBInitializer());
        }

        public override int SaveChanges()
        {
            //foreach (var entry in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("DataCriacao") != null))
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("ATIVO").CurrentValue = 1;
                }
            }

            return base.SaveChanges();
        }

        //================================================================================================================================================================================
        //================================================================================================================================================================================
        //================================================================================================================================================================================
        //================================================================================================================================================================================
        //================================================================================================================================================================================



    }
}
