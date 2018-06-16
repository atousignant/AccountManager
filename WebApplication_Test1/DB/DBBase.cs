using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SQLite;

namespace WebApplication_Test1.DB
{
    public abstract class DBBase
    {
        #region Constructor


        #endregion

        #region Fields


        #endregion

        #region Properties

        public SQLiteConnection DBConnection => DB.Instance.Connection; 
        
        #endregion

        #region Methods


        #endregion
    }
}