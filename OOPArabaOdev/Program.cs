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

                // Uygulama ba�lad���nda g�sterilecek ana form
                Application.Run(new Form1());
            }
        }
    }

}
  