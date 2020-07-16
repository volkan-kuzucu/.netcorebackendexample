using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void Add(Article article)
        {
            if (_articleDal.Get(x => x.Name == article.Name) == null)
            {
                _articleDal.Add(article);
            }
            else
            {
                throw new Exception("Bu Makale adı zaten mevcut.");
            }
        }

        public void Delete(Article article, int id)
        {
            if (_articleDal.Get(x => x.Id == id) != null)
            {
                _articleDal.Delete(article);
            }
            else
            {
                throw new Exception("Silinecek bir Makale Yok.");
            }
        }

        public void Update(Article article, int id)
        {
            if (_articleDal.Get(x => x.Id == id) != null)
            {
                _articleDal.Update(article);
            }
            else
            {
                throw new Exception("Güncellenecek bir Makale Yok.");
            }
        }

        public List<Article> GetAll()

        {
            return _articleDal.GetList().ToList();
        }

        Article IArticleService.GetById(int id)
        {
            if(_articleDal.Get(x=>x.Id == id) != null)
            {
                return _articleDal.Get(x => x.Id == id);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

    }
}
