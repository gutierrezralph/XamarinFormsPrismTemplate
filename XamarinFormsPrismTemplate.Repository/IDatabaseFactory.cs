using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsPrismTemplate.Repository
{
    public interface IDatabaseFactory
    {
        string GetDatabasePath(string databaseName);
    }
}
