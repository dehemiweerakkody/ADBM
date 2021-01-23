using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ADBM.Dialogs;
using HandyControl.Data;

namespace ADBM
{
    public partial class Login
    {
        public bool auth = false;
        public Login()
        {
            InitializeComponent();
        }

        private bool getResult(String Table)
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT * FROM "+ Table +" WHERE NIC='" + userName.Text + "' AND Password='" + password.Password + "';";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("DataTable");

                sda.Fill(dt);

                int count = dt.Rows.Count;
                if (count > 0)
                {
                    return true;
                } else
                {
                    return false;
                }

            }
        }

        private void employeebtn_Click(object sender, RoutedEventArgs e)
        {

            if (userName.Text.Length > 0 && password.Password.Length > 0)
            {
                bool result = getResult("Table_Admins");
                if (result)
                {
                    auth = true;
                    this.Close();
                }
                else
                {
                    bool result2 = getResult("Table_Employee");
                    if (result2)
                    {
                        auth = true;
                        this.Close();
                    }
                    else
                    {
                        DialogWindow dW = new DialogWindow();
                        dW.Show();
                    }
                    
                }
            } else
            {
                DialogWindow dW = new DialogWindow();
                dW.Show();
            }

            
        }
    }
}
