namespace acfisio.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using Helpers;

    public class ModelWrapper
    {
        public List<Banner> Banners { get; private set; }
        public List<Menu> Menu { get; private set; }
        public object Page { get; }

        public ModelWrapper(object page = null)
        {
            this.Page = page;
        }
        
        public ModelWrapper Build()
        {
            return this;
        }

        public ModelWrapper WithBanners()
        {
            this.Banners = BannerHelper.GetBanners();
            return this;
        }

        public ModelWrapper WithMenu()
        {
            this.Menu = MenuHelper.GetMenuItems().OrderBy(m => m.Id).ToList();
            return this;
        }
    }
}