using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DesdignPattern_Singleton
{
    class Hacker
    {

        public DatabaseSingleton Database = DatabaseSingleton.GetInstance();

    }
}
