using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndigeneApp.Models;
using System.IO;
using System.Reflection;

namespace IndigeneApp
{
    /// <summary>
    /// A singleton class that returns an SQLiteConnection
    /// </summary>
    class DataBaseConnection
    {
        //private static string connectionString1 = @"Data Source=.\SQLEXPRESS;Initial Catalog=crimedb;Integrated Security=True";

        private DataBaseConnection(){}
        private static bool overwrite = false;
        public static String SCHEMA_EXISTENCE = "SCHEMA_EXISTENCE";
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The ISessionFactory  of this appliation</returns>
 
        public static ISessionFactory CreateSessionFactory() {
            //String dirName = Assembly.GetExecutingAssembly().Location + "\\indigenedata.db";
            String dirName = Directory.GetCurrentDirectory() + "\\indigenedata.db";
            Console.WriteLine(dirName);
            return Fluently.Configure()
                            .Database(SQLiteConfiguration.Standard.UsingFile(dirName))
                            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Indigene>())
                            .ExposeConfiguration(BuildSchema)
                            .BuildSessionFactory();
        }

        public static bool overwriteSchema() {
            if (Application.UserAppDataRegistry.GetValue(SCHEMA_EXISTENCE) != null) {
                return false;
            } else {
                return true;
            }
        }

        public static void saveCurrentSchema() {
            Application.UserAppDataRegistry.SetValue(SCHEMA_EXISTENCE, "dontOverWrite");
        }
        

        private static void BuildSchema(Configuration configuration)
        {
            if (overwriteSchema()) {
                SchemaExport schemaExport = new SchemaExport(configuration);
                schemaExport.Create(false, true);
                //Application.UserAppDataRegistry.SetValue(SCHEMA_EXISTENCE, "dontOverWrite");
            }

        }
    }

}
