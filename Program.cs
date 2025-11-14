

namespace portfolioTUI
{
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using portfolioTUI;
    using Terminal.Gui;
    using Terminal.Gui.App;
    using Terminal.Gui.Drawing;
    using Terminal.Gui.Input;
    using Terminal.Gui.ViewBase;
    using Terminal.Gui.Views;
    internal static class Program
    {
        private static void Main()
        {
            Application.Init();

            var app = new Toplevel();
            var win = new Window()
            {
                X = 0,
                Y = 1, // Leave one row for the toplevel menu

                // By using Dim.Fill(), it will automatically resize without manual intervention
                Width = Dim.Fill(),
                Height = Dim.Fill()
            };

            var appBar = new MenuBarv2(new MenuBarItemv2[]
            {
                new MenuBarItemv2("_Navigation", new MenuItemv2 []
                {
                    new MenuItemv2("_Landing Page", "", () =>
                    {
                        win.RemoveAll();
                        win.Add(new LandingPageView());
                    }),

                    new MenuItemv2("_About Page", "", () =>
                    {
                        win.RemoveAll();
                        win.Add(new AboutPageView());
                    }),
                    new MenuItemv2("_Projects Page", "", () => 
                    { 
                        win.RemoveAll();
                        win.Add(new ProjectsPageView());
                    }),
                    new MenuItemv2("_Skills Page", "", () => 
                    { 
                        win.RemoveAll();
                        win.Add(new SkillsPageView());
                    }),
                    new MenuItemv2("_Experiences Page", "", () => 
                    { 
                        win.RemoveAll();
                        win.Add(new ExperiencePageView());
                    }),
                    new MenuItemv2("_Contact Page", "", () => 
                    { 
                        win.RemoveAll();
                        win.Add(new ContactPageView());
                    }),
                    

                }),
            });
            win.Add(new LandingPageView());
            app.Add(appBar, win);
            try
            {
                Application.Run(app);
            }
            finally
            {
                Application.Shutdown();
            }
        }
        
    }
    
}

