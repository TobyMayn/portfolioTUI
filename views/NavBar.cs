using portfolioTUI;
using Terminal.Gui.Views;
namespace portfolioTUI
{
    public class NavBar : MenuBarv2
    {
        private ViewRouter _router;
        public MenuBarv2 AppBar {get;}
        public NavBar (ViewRouter router) {
            _router = router;

            AppBar = new MenuBarv2(new MenuBarItemv2[]
                {
                    new MenuBarItemv2("_Navigation", new MenuItemv2 []
                    {
                        new MenuItemv2("_Landing Page", "", () =>
                        {
                            _router.NavigateTo(PortfolioPage.Home);
                        }),

                        new MenuItemv2("_About Page", "", () =>
                        {
                            _router.NavigateTo(PortfolioPage.About);
                        }),
                        new MenuItemv2("_Projects Page", "", () => 
                        { 
                            _router.NavigateTo(PortfolioPage.Projects);
                        }),
                        new MenuItemv2("_Skills Page", "", () => 
                        { 
                            _router.NavigateTo(PortfolioPage.Skills);
                        }),
                        new MenuItemv2("_Experiences Page", "", () => 
                        { 
                            _router.NavigateTo(PortfolioPage.Experience);
                        }),
                        new MenuItemv2("_Contact Page", "", () => 
                        { 
                            _router.NavigateTo(PortfolioPage.Contact);
                        }),
                    }),
                }
            );
        }
    
    }
}
