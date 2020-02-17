using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DesdignPattern_Singleton
{
    class DatabaseSingleton
    {
        private static DatabaseSingleton instance;
        private DatabaseSingleton() {
            Console.WriteLine("je me connecte à la base de donnée");
        }

        public static DatabaseSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseSingleton();
            }
            return instance;
        }
    }
}