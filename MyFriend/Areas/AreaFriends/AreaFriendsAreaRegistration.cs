using System.Web.Mvc;

namespace MyFriend.Areas.AreaFriends
{
    public class AreaFriendsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AreaFriends";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AreaFriends_default",
                "AreaFriends/{controller}/{action}/{id}",
                new { controller="Home",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}