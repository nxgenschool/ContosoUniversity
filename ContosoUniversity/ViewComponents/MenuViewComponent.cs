using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ContosoUniversity.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // Your logic to get menu items
            List<MenuItem> MenuItems = new List<MenuItem>();

            MenuItem item1 = new MenuItem();
            item1.Text = "Students";
           // item1.Url = "/Students";

            List<MenuItem> submenu1 = new List<MenuItem>();        
            MenuItem sub1 = new MenuItem();
            sub1.Text = "Index";
            sub1.Url = "/Students";
            submenu1.Add(sub1);

            MenuItem sub2 = new MenuItem();
            sub2.Text = "Courses";
            sub2.Url = "/Courses";
            submenu1.Add(sub2);

            item1.SubMenu = submenu1;
            MenuItems.Add(item1);

            MenuItem item2 = new MenuItem();
            item2.Text = "Stations";
            //item2.Url = "/Stations";


            List<MenuItem> submenu2 = new List<MenuItem>();

            MenuItem sub3 = new MenuItem();
            sub3.Text = "Index";
            sub3.Url = "/Stations";

            submenu2.Add(sub3);

            MenuItem sub4 = new MenuItem();
            sub4.Text = "Privacy";
            sub4.Url = "Privacy";
            submenu2.Add(sub4);

            item2.SubMenu = submenu2;

            MenuItems.Add(item2);

            //string xmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "navigation.xml");
            //XmlSerializer serializer = new XmlSerializer(typeof(NavigationModel));

            //using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            //{
            //    NavigationModel navigationModel = (NavigationModel)serializer.Deserialize(fileStream);
            //    var menuItems = navigationModel.MenuItems;

            //    foreach (var menuItem in menuItems)
            //    {
            //        MenuItems.Add(menuItem);

            //        //if (menuItem.SubMenu != null && menuItem.SubMenu.Count > 0)
            //        //{
            //        //   menuItem.SubMenu

            //        //}
            //    }
            //}




            return View(MenuItems);
        }
    }
}
