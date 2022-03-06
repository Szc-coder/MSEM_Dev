using MSEM_Dev.page;
using System.Windows.Forms;

namespace MSEM_Dev
{
    class MsemApplication
    {
        public static void Main()
        {
            Login login = new Login();
            Application.Run(login);
            /*            index index1 = new index();
                        Application.Run(index1);*/
        }
    }
}
