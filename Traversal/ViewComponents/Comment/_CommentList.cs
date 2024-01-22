using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDal());
        [HttpGet]
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.GetListByFilter(id);
            return View(values);
        }
    }
}
