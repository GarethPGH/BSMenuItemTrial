using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace DataDrivenMenu.Controllers{
public ActionResult DataDrivenMenu()
{
   
  BSMenuItemManager mgr =
           new BSMenuItemManager();
  mgr.Load();
  return View(mgr);
}

