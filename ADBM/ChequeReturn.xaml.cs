using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace ADBM
{
    /// <summary>
    /// Interaction logic for ChequeReturn.xaml
    /// </summary>
    public partial class ChequeReturn
    {
        public ChequeReturn()
        {
            InitializeComponent();
        }

        private void MakeSale_Click(object sender, RoutedEventArgs e)
        {
			
			int SID = int.Parse(SaleID.Text);
			DateTime saleDate = DateR.SelectedDate.Value;
			String cnumber = CNo.Text;

			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;

			using (SqlConnection openCon = new SqlConnection(ConString))
			{
				string save = "INSERT INTO Table_ChequeReturns VALUES ("+SID+" , '"+saleDate+"' , '"+ cnumber +"', 'UnResolved');";

				using (SqlCommand querySave = new SqlCommand(save))
				{
					querySave.Connection = openCon;
					openCon.Open();
					querySave.ExecuteNonQuery();
				}
			}
			this.Close();
		}
    }
}
