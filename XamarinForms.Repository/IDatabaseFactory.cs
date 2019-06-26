using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinForms.Repository
{
    public interface IDatabaseFactory
    {
        string GetDatabasePath(string databaseName);
    }
}
