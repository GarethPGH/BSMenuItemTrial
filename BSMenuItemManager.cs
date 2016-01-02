using System;
using System.Collections.Generic;

public class BSMenuItem
{
    public string Title { get; set; }
    public string Action { get; set; }
}

public class BSMenuItemManager
{
    public BSMenuItemManager()
    {
        //single property for BSMenuItem
        Menus = new List<BSMenuItem>();
    }
    //This sets Menus from above into a generic list
    public List<BSMenuItem> Menus { get; set; }

    public void Load()
    {//load event
        
        BSMenuItem entity = new BSMenuItem();
        //This creates new separate instances of object type BSMenuItem (from BSMenuItem.cs)
        entity.Title = "Home";
        entity.Action = "/Home/Home";
        //assigns title and action properties of each instance
        Menus.Add(entity);
        //And adds the instance to the list in Menus from above

        entity = new BSMenuItem();
        entity.Title = "Maintenance";
        entity.Action = "/Maintenance/Maintenance";
        Menus.Add(entity);

        entity = new BSMenuItem();
        entity.Title = "Reports";
        entity.Action = "/Reports/Reports";
        Menus.Add(entity);

        entity = new BSMenuItem();
        entity.Title = "Lookup";
        entity.Action = "/Lookup/Lookup";
        Menus.Add(entity);
        //Three different instances using variable entity added to the list
    }
}