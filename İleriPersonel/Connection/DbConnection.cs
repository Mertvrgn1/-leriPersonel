using İleriPersonel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İleriPersonel.Connection
{
    public static class DbConnection
    {
        static PersonelContext db;
        public static PersonelContext GetConnection()
        {
            if (db == null)
            {
                PersonelContext db = new PersonelContext();
                return db;
            }
            return db;
        }
    }
}
