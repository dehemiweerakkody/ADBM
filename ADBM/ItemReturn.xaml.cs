using HandyControl.Tools;
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

namespace ADBM
{
	/// <summary>
	/// Interaction logic for ItemReturn.xaml
	/// </summary>
	public partial class ItemReturn
	{
		public ItemReturn()
		{
			ConfigHelper.Instance.SetLang("en");
			InitializeComponent();
			FillSales();
		}

		private void FillSales()
		{
			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;
			using (SqlConnection con = new SqlConnection(ConString))
			{
				CmdString = "SELECT * FROM Table_Sale;";
				SqlCommand cmd = new SqlCommand(CmdString, con);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable("DataTable");

				sda.Fill(dt);

				SalesList.ItemsSource = dt.DefaultView;
				SalesList.DisplayMemberPath = "SID";
				SalesList.SelectedValuePath = "SID";
			}
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			

			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;
			using (SqlConnection con = new SqlConnection(ConString))
			{
				CmdString = "SELECT * FROM Table_Sale WHERE SID ="+ SalesList.SelectedValue.ToString()+ ";";
				SqlCommand cmd = new SqlCommand(CmdString, con);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable("DataTable");

				sda.Fill(dt);

				ICode.Text = dt.Rows[0]["ICode"].ToString();

				CmdString = "SELECT * FROM Table_Stock WHERE ICode = '" + dt.Rows[0]["ICode"].ToString() + "';";
				SqlCommand cmd2 = new SqlCommand(CmdString, con);
				SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
				DataTable dt2 = new DataTable("DataTable");

				sda2.Fill(dt2);
				


				StockID.Text = dt2.Rows[0]["StockID"].ToString();
			}
		}

		private void MakeSale_Click(object sender, RoutedEventArgs e)
		{
			
			int SID = int.Parse(SalesList.SelectedValue.ToString());
			DateTime saleDate = DateR.SelectedDate.Value;
			String amount = Amount.Text;

			int stockid = int.Parse(StockID.Text);
			String icode = ICode.Text;

			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;

			using (SqlConnection openCon = new SqlConnection(ConString))
			{
				string save = "INSERT INTO Table_ItemReturn VALUES ('"+ icode +"' , " + SID + " , " + stockid + " , '" + saleDate + "' , " + amount + ");";

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
