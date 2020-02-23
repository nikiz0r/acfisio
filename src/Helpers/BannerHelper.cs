namespace acfisio.Helpers
{
    using System.Collections.Generic;
    using Models;

    public static class BannerHelper
    {
        public static List<Banner> GetBanners()
        {
            return new List<Banner>
            {
                new Banner
                {
                    Id = 1,
                    Title = "Atendimentos",
                    Subtext = "Fisioterapia especializada em ortopedia esportiva e hidroterapia no tratamento " +
                    "de dores crônicas, musculares, tendinites, bursites, pré e pós-operatório.",
                    ImageUri = "Content/images/banner/atendimento.jpg",
                    Url = "Atendimentos"
                },
                new Banner
                {
                    Id = 2,
                    Title = "Contato",
                    Subtext = "Em construção",
                    ImageUri = "Content/images/banner/contato.jpg",
                    Url = "Contato"
                }
            };
        } 
    }
}