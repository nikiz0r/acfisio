namespace acfisio.Helpers
{
    using System.Collections.Generic;
    using Models;

    public static class MenuHelper
    {
        public static List<Menu> GetMenuItems()
        {
            return new List<Menu>
            {
                new Menu
                {
                    Id = 0,
                    Title = "Home",
                    Uri = "Home.aspx"
                },
                new Menu
                {
                    Id = 1,
                    Title = "Produtos",
                    Uri = "/",
                    SubMenu = new List<Menu>
                    {
                        new Menu
                        {
                            Id = 1,
                            Title = "Prod1",
                            Uri = "Prod1.aspx"
                        },
                        new Menu
                        {
                            Id = 0,
                            Title = "Prod2",
                            Uri = "Prod2.aspx"
                        }
                    }
                }
            };
        }
    }
}