using Terminal.Gui;
using Terminal.Gui.App;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
namespace portfolioTUI {

    public class ViewRouter {
        
        private readonly Window _hostContainer;
        private View? _currentView;
        public ViewRouter(Window hostContainer) {
            _hostContainer = hostContainer?? throw new ArgumentNullException(nameof(hostContainer));

        }

        public void NavigateTo(PortfolioPage pageType)
        {
            Application.Invoke(() =>
            {
                View nextView = GetOrCreateView(pageType);
                
                // Check if we are already on this view
                if (nextView == _currentView)
                {
                    return;
                }

                // Remove current view if it is not null
                if (_currentView != null)
                {
                    // Explicitly remove the old content view from the host. [2]
                    _hostContainer.Remove(_currentView);
                }

                _hostContainer.Add(nextView);
                _currentView = nextView;
                
            });
        }

    /// <summary>
    /// Factory method to create a new one.
    /// </summary>
        private View GetOrCreateView(PortfolioPage type)
    {
        View newView = type switch
        {
            PortfolioPage.Home => new LandingPageView(),
            PortfolioPage.About => new AboutPageView(),
            PortfolioPage.Projects => new ProjectsPageView(),
            PortfolioPage.Skills => new SkillsPageView(),
            PortfolioPage.Experience => new ExperiencePageView(),
            PortfolioPage.Contact => new ContactPageView(),
            _ => throw new ArgumentOutOfRangeException(nameof(type))
        };

        return newView;
    }
    }
}
