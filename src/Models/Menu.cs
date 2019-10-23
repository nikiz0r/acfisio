namespace acfisio.Models
{
    using System.Collections.Generic;

    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Menu> SubMenu { get; set; }
        public string Uri { get; set; }
    }
}