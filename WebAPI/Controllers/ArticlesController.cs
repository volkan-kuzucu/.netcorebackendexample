using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            return Ok(_articleService.GetAll());

        }

        [HttpPost("add")]
        public IActionResult Add([FromBody]Article article)
        {
           _articleService.Add(article);

            return CreatedAtRoute("Article", new { id = article.Id }, article);
        }


        [HttpPost("update/{id}")]
        public IActionResult Update([FromBody]Article article, int id)
        {
           _articleService.Update(article,id);

            return CreatedAtRoute("Article", new { id = article.Id }, article);
        }

        [HttpPost("delete/{id}")]
        public IActionResult Delete([FromBody]Article article, int id)
        {
           _articleService.Delete(article,id);

            return CreatedAtRoute("Article", new { id = article.Id }, article);
        }
    }
}