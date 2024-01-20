namespace CSharp
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
            Application.EnableVisualStyles();
            Application.Run(new FrmUI.FrmChat());
            return;
            //Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            if (frm.getToken() != null && frm.getToken() != "")
            {
                Application.Run(new FrmUI.FrmMain(frm.getToken()));
            }
        }
    }
}