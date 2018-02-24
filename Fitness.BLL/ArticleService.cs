using Fitness.IBLL;
using Fitness.Model.Entities;
using System.Collections.Generic;
using System.Linq;
using Fitness.IDAL;

namespace Fitness.BLL
{
    public partial class ArticleService : BaseService<Article>,IArticleService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DbSession.ArticleDal;
        }

        public IList<Article> GetArticleModel()
        {
            return this.DbSession.ArticleDal.LoadEntities(c => true).ToList();       
        } 
    }
}
