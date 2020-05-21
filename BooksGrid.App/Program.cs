using BooksGrid.App.Utilities;
using BooksGrid.Core.Managers;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace BooksGrid.App
{
    static class Program
    {
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<BookCatalogForm>());
        }

        private static void Bootstrap()
        {
            container = new Container();

            container.Register<IGradientGenerator, RgbGradientGenerator>();
            container.Register<ICatalogReader, CsvCatalogReader>();

            container.Verify();
        }
    }
}
