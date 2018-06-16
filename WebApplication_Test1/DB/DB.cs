using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using WebApplication_Test1.Config;
using WebApplication_Test1.Models;

namespace WebApplication_Test1.DB
{
    public class DB
    {
        #region Constructor

        public DB()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), AppConstants.SQLiteDBName);

            Connection = new SQLiteConnection(databasePath);

            Connection.CreateTable<Position>();
            Connection.CreateTable<Person>();
            Connection.CreateTable<Department>();
        }

        #endregion

        #region Fields


        #endregion

        #region Properties

        public SQLiteConnection Connection { get; set; }

        #endregion

        #region Methods


        #endregion

        #region Singleton

        private static DB _instance;

        public static DB Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                _instance = new DB();
                return _instance;
            }
            
        }

        #endregion


    }
}