using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DesdignPattern_Singleton
{
    public class User
    {
  
        private DatabaseSingleton _database = DatabaseSingleton.GetInstance();       
    }
}
