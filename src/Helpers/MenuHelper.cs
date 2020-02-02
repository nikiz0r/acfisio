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
                    Action = "/"
                },
                new Menu
                {
                    Id = 1,
                    Title = "Fisioterapia Ortopédica",
                    Action = "Ortopedica"
                },
                new Menu
                {
                    Id = 2,
                    Title = "Fisioterapia Aquática",
                    Action = "Aquatica"
                },
                new Menu
                {
                    Id = 3,
                    Title = "Mobilidade Sênior",
                    Action = "Senior"
                },
                new Menu
                {
                    Id = 4,
                    Title = "Dry Needling",
                    Action = "DryNeedling"
                }
            };
        }
    }
}