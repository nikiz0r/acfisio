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
                    Action = "Index"
                },
                new Menu
                {
                    Id = 1,
                    Title = "Atendimentos",
                    Action = "Atendimentos"
                },
                new Menu
                {
                    Id = 2,
                    Title = "Contato",
                    Action = "Contato"
                }
            };
        }
    }
}