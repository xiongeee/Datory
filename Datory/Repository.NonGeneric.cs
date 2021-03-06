﻿using System.Collections.Generic;

namespace Datory
{
    public partial class Repository : IRepository
    {
        public DatabaseType DatabaseType { get; }
        public string ConnectionString { get; }
        public string TableName { get; }
        public List<TableColumn> TableColumns { get; }

        public Repository(DatabaseType databaseType, string connectionString)
        {
            DatabaseType = databaseType;
            ConnectionString = connectionString;
            TableName = null;
            TableColumns = null;
        }

        public Repository(DatabaseType databaseType, string connectionString, string tableName)
        {
            DatabaseType = databaseType;
            ConnectionString = connectionString;
            TableName = tableName;
            TableColumns = null;
        }

        public Repository(DatabaseType databaseType, string connectionString, string tableName, List<TableColumn> tableColumns)
        {
            DatabaseType = databaseType;
            ConnectionString = connectionString;
            TableName = tableName;
            TableColumns = tableColumns;
        }
    }
}
