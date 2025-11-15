

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

            var router = new ViewRouter(win);
            var appBar = new NavBar(router).AppBar;

            router.NavigateTo(PortfolioPage.Home);
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

