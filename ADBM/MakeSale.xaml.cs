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
	/// Interaction logic for MakeSale.xaml
	/// </summary>
	public partial class MakeSale
	{
		
		public MakeSale()
		{
			InitializeComponent();
			FillItems();
			FillCustomers();
			FillReps();
			ConfigHelper.Instance.SetLang("en-us");
		}

		private void FillItems()
		{
			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;
			using (SqlConnection con = new SqlConnection(ConString))
			{
				CmdString = "SELECT ICode FROM Table_Item;";
				SqlCommand cmd = new SqlCommand(CmdString, con);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable("DataTable");

				sda.Fill(dt);

				for (int i = 0; i < dt.Rows.Count; i++)
				{
					itemsList.Items.Add(dt.Rows[i]["ICode"]);
					
				}

			}
		}

		private void FillCustomers()
		{
			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;
			using (SqlConnection con = new SqlConnection(ConString))
			{
				CmdString = "SELECT CID,CName FROM Table_Customers;";
				SqlCommand cmd = new SqlCommand(CmdString, con);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable("DataTable");

				sda.Fill(dt);

					CustomersList.ItemsSource = dt.DefaultView;
					CustomersList.DisplayMemberPath = "CName";
					CustomersList.SelectedValuePath = "CID";
				

			}
		}

		private void FillReps()
		{
			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;
			using (SqlConnection con = new SqlConnection(ConString))
			{
				CmdString = "SELECT RepID,Name FROM Table_Employee;";
				SqlCommand cmd = new SqlCommand(CmdString, con);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable("DataTable");

				sda.Fill(dt);

					RepsList.ItemsSource = dt.DefaultView;
					RepsList.DisplayMemberPath = "Name";
					RepsList.SelectedValuePath = "RepID";
			   

			}
		}

		private void MakeSale_Copy1_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void MakeSaleBTN_Click(object sender, RoutedEventArgs e)
		{
			
			String Icode = itemsList.SelectedItem.ToString();
			int CID = int.Parse(CustomersList.SelectedValue.ToString());
			int RepID = int.Parse(RepsList.SelectedValue.ToString());
			DateTime saleDate = SaleDate.SelectedDate.Value;
			DateTime expayDate = expectedDate.SelectedDate.Value;
			Double Payamount = Double.Parse(PaymentAmount.Text);
			int qty = int.Parse(quantity.Text);
			String payment = paymentType.Text;
			String trackingNo = tracking.Text;
			String currier = Currier.Text;

			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;

			using (SqlConnection openCon = new SqlConnection(ConString))
			{
				string save = "INSERT INTO Table_Sale VALUES ('" + Icode + "', " + CID + ", " + RepID + ", '" + saleDate + "', '" + expayDate + "', null, " + Payamount + ", " + qty + ", '" + payment + "', '" + trackingNo + "', '" + currier + "');";

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
