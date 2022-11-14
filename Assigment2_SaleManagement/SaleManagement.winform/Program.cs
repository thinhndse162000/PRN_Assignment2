namespace SaleManagement.winform
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new frmLogin());
=======
            Application.Run(new frmProductsObject());
>>>>>>> 74ca44e (add search product)
        }
    }
}