using Fitness.IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DalFactory
{
    public partial interface IDBSession
    {
        IInvitationDal InvitationDal { get; set; }
        IArticleDal ArticleDal { get; set; }
        IUsersDal UsersDal { get; set; }

        DbContext Db { get; }
        bool SaveChanges();
        int ExecuteSql(string sql, params System.Data.SqlClient.SqlParameter[] pars);
        List<T> ExecuteSelectSql<T>(string sql, params System.Data.SqlClient.SqlParameter[] pars);
    }
}
