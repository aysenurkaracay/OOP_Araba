namespace OOPArabaOdev
{
    using System;
    using System.Windows.Forms;

    namespace OOPArabaOdev
    {
        static class Program
        {
            
           
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Uygulama başladığında gösterilecek ana form
                Application.Run(new Form1());
            }
        }
    }

}
  