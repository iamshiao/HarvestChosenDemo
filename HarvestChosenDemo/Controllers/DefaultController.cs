using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarvestChosenDemo.Controllers
{
    public class DefaultController : Controller
    {
        private SelectListItem[] _items = new[]
        {
            new SelectListItem { Value = "1", Text = "item 1" },
            new SelectListItem { Value = "2", Text = "item 2" },
            new SelectListItem { Value = "3", Text = "item 3" },
            new SelectListItem { Value = "4", Text = "item 4" },
        };

        // GET: Default
        public ActionResult Index()
        {
            var model = new MyViewModel();

            // preselect items with values 2 and 4
            model.SelectedValues = new[] { 2, 4 };

            // the list of available values
            model.Values = _items;

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(MyViewModel model)
        {
            var selectedVal = model.SelectedValues;
            model.Values = _items;

            return View(model);
        }
    }

    public class MyViewModel
    {
        public int[] SelectedValues { get; set; }
        public SelectListItem[] Values { get; set; }
    }
}