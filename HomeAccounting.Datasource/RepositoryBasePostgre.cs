using HomeAccounting.Datasource.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.Datasource
{
    public class RepositoryBasePostgre : IRepository
    {
        private string _connectionString = "Host=localhost; Username=postgres; Password=qwerty; Database=postgres;";

        public void AddAccount(DBAccount account)
        {
            //using (Npgsql.NpgsqlConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            //{
            //    db.Execute("INSERT INTO Public.Accounts (CreationDate,Title) VALUES($1,$2)", account); ;
            //}
        }

        public void GetAccountById(DBAccount account)
        {
            //using (Npgsql.NpgsqlConnection db = new Npgsql.NpgsqlConnection(_connectionString))
            //{
            //    DBAccount account = db.Query<DBAccount($"SELECT * FROM accounts WHERE id = {id}").FirstOrDefault; 
            //}
        }
    }
}
