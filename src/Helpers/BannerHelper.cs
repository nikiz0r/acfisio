namespace acfisio.Helpers
{
    using System.Collections.Generic;
    using acfisio.Models;
    
    public static class BannerHelper
    {
        public static List<Banner> GetBanners()
        {
            return new List<Banner>
            {
                new Banner
                {
                    Id = 1,
                    Title = "Atendimento",
                    Subtext = "bla bla bla bla bla bla bla",
                    ImageUri = "Content/images/banner/atendimento.jpg"
                },
                new Banner
                {
                    Id = 2,
                    Title = "Contato",
                    Subtext = "bla bla bla bla bla bla bla",
                    ImageUri = "Content/images/banner/contato.jpg"
                },
                new Banner
                {
                    Id = 3,
                    Title = "Home",
                    Subtext = "bla bla bla bla bla bla bla",
                    ImageUri = "Content/images/banner/home.jpg"
                },
                new Banner
                {
                    Id = 4,
                    Title = "Sobre",
                    Subtext = "bla bla bla bla bla bla bla",
                    ImageUri = "Content/images/banner/sobre.jpg"
                }
            };
        } 
    }
}