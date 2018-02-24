using Fitness.DAL;
using Fitness.IDAL;
using System.Data.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Fitness.DalFactory
{
    /// <summary>
    /// DBSession用于解耦和DAL和BLL层
    /// </summary>
    public class DBSession:IDBSession
    {
        public DbContext db = DbContextFactory.CreateCurrentDbContext();
        private IInvitationDal _invitationDal;
        public IInvitationDal InvitationDal
        {
            get
            {
                if (_invitationDal == null)
                {
                    //_invitationDal = new InvitationDal();//这里把DAL层和DalFactory层耦合在一起，通过简单工厂解决
                    _invitationDal = SimpleDalFactory.CreateInvitationDal();
                }
                return _invitationDal;
            }
            set
            {
                _invitationDal = value;
            }
        }
        private IArticleDal _articleDal;
        public IArticleDal ArticleDal
        {
            get
            {
                if (_articleDal == null)
                {
                    _articleDal = SimpleDalFactory.CreateArticleDal();
                }
                return _articleDal;
            }
            set
            {
                _articleDal = value;
            }
        }
        private IUsersDal _usersDal;
        public IUsersDal UsersDal
        {
            get
            {
                if (_usersDal == null)
                {
                    _usersDal = SimpleDalFactory.CreateUsersDal();
                }
                return _usersDal;
            }
            set
            {
                _usersDal = value;
            }
        }

        public DbContext Db
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public int ExecuteSql(string sql, params SqlParameter[] pars)
        {
            throw new System.NotImplementedException();
        }

        public List<T> ExecuteSelectSql<T>(string sql, params SqlParameter[] pars)
        {
            throw new System.NotImplementedException();
        }
    }
}
