using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PassPro.DataAccess
{
    public class DB
    {
        public static readonly DbSession Context = new DbSession("DosConn");
    }
}
