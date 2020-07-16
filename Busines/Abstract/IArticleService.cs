using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IArticleService
    {
        List<Article> GetAll();
        Article GetById(int id);
        void Add(Article article);
        void Delete(Article article, int id);
        void Update(Article article, int id);
    }
}
