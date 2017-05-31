using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFriend.Areas.AreaFriends.Models;
using System.Windows.Forms;

namespace MyFriend.Areas.AreaFriends.Controllers
{
    public class HomeController : Controller
    {
        private FriendsEntities1 db = new FriendsEntities1();
        // GET: AreaFriends/Home
        public ActionResult Index()
        {
            return View(db.Articles.ToList());
        }

        [HttpGet]
        public ActionResult Insert()
        {
            ViewBag.datas = db.Activities.ToList(); // 將程式碼寫進View裡，保持Controller乾淨
            //ViewBag.datas = new SelectList(db.Categories, "CategoryID", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Articles article)
        {
            article.ArticleDate = DateTime.Now;

            db.Articles.Add(article);
            db.SaveChanges();
            return RedirectToAction("Index","Home",new {Area="AreaFriends" });
            
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            ViewBag.datas = db.Activities.ToList();
            return View(db.Articles.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Articles article)
        {

            article.ArticleDate = DateTime.Now;
            db.Entry(article).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Home", new { Area = "AreaFriends" });
            
        }

        public ActionResult Delete(int id = 0)
        {
            DialogResult result = MessageBox.Show("確定刪除?", "刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                db.Articles.Remove(db.Articles.Find(id));
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home", new { Area = "AreaFriends" });
            
        }
    }
}