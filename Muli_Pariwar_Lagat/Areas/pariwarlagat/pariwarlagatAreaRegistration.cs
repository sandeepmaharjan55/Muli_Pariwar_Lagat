using System.Web.Mvc;

namespace Muli_Pariwar_Lagat.Areas.pariwarlagat
{
    public class pariwarlagatAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "pariwarlagat";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "pariwarlagat_default",
                "pariwarlagat/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}