using MSEM_Dev.page;
using System.Windows.Forms;

namespace MSEM_Dev
{
    class MsemApplication
    {
        [STAThread]
        public static void Main()
        {
            Login login = new Login();
            Application.Run(login);
        }
    }
}
