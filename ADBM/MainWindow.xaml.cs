using HandyControl.Data;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace ADBM
{
	public partial class MainWindow
	{
		public MainWindow()
		{
			InitializeComponent();

			//temp dis login
			
			this.Hide();
			Login lgn = new Login();
			lgn.ShowDialog();

			if (lgn.auth)
            {
				this.Show();
            } else
            {
				this.Close();
            }

			
			
         
		}

		public void FillGrid(String tableName)
		{
			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;
			using (SqlConnection con = new SqlConnection(ConString))
			{
				CmdString = "SELECT * FROM "+ tableName;
				SqlCommand cmd = new SqlCommand(CmdString, con);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable("DataTable");
				sda.Fill(dt);

				int indexofpw = dt.Columns.IndexOf(columnName:"Password");
				if (indexofpw > 0)
                {
					dt.Columns.RemoveAt(indexofpw);
				}
				EmployeesGrid.ItemsSource = dt.DefaultView;
				
			}
		}

        private void button_Click(object sender, RoutedEventArgs e)
        {
			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			string CmdString = string.Empty;
			using (SqlConnection con = new SqlConnection(ConString))
			{
				CmdString = "PR_GetEmployees;";
				SqlCommand cmd = new SqlCommand(CmdString, con);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable("DataTable");



				sda.Fill(dt);

				int indexofpw = dt.Columns.IndexOf(columnName: "Password");
				if (indexofpw > 0)
				{
					dt.Columns.RemoveAt(indexofpw);
				}
				EmployeesGrid.ItemsSource = dt.DefaultView;
				Name.Content = "Employees";
			}
		}

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
			FillGrid("Table_Customers");
			Name.Content = "Customers";
		}

        private void itemsbtn_Click(object sender, RoutedEventArgs e)
        {
			FillGrid("Table_Item");
			Name.Content = "Items";
		}

        private void MakeSale_Click(object sender, RoutedEventArgs e)
        {
			MakeSale mS = new MakeSale();
			mS.ShowDialog();
			FillGrid("Table_Sale");
			Name.Content = "Sales";
		}

        private void Salesbtn_Click(object sender, RoutedEventArgs e)
        {
			FillGrid("Table_Sale");
			Name.Content = "Sales";
		}

        private void MakeSale_Copy_Click(object sender, RoutedEventArgs e)
        {
			ChequeReturn cR = new ChequeReturn();
			cR.ShowDialog();
			FillGrid("Table_ChequeReturns");
			Name.Content = "ChequeReturns";

		}

        private void MakeSale_Copy1_Click(object sender, RoutedEventArgs e)
        {
			ItemReturn iR = new ItemReturn();
			iR.ShowDialog();
			FillGrid("Table_ItemReturn");
			Name.Content = "Item Returns";

		}


        private void Salesbtn_Copy3_Click(object sender, RoutedEventArgs e)
        {
			FillGrid("Table_ChequeReturns");
			Name.Content = "Cheque Returns";
		}

        private void Salesbtn_Copy2_Click(object sender, RoutedEventArgs e)
        {
			FillGrid("Table_ItemReturn");
			Name.Content = "Item Returns";
		}

        private void Salesbtn_Copy_Click(object sender, RoutedEventArgs e)
        {
			FillGrid("Table_Stock");
			Name.Content = "Stock";
		}

        private void Salesbtn_Copy1_Click(object sender, RoutedEventArgs e)
        {
			FillGrid("Table_Suppliers");
			Name.Content = "Suppliers";
		}


		private void MarkasPaid(object sender, RoutedEventArgs e)
		{
            try
            {
				DataRowView row = (DataRowView)EmployeesGrid.SelectedItems[0];
				int SID = (int) row["SID"];

                DateTime dt = DateTime.Today;

				string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
				string CmdString = string.Empty;

				using (SqlConnection openCon = new SqlConnection(ConString))
				{
					string save = "UPDATE Table_Sale SET PaymentDate='"+ dt +"' WHERE SID="+ SID +";";

					using (SqlCommand querySave = new SqlCommand(save))
					{
						querySave.Connection = openCon;
						openCon.Open();
						querySave.ExecuteNonQuery();
					}

				}


			}
            catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
            }

			FillGrid("Table_Sale");

		}

		private void MarkasResolved(object sender, RoutedEventArgs e)
		{
			try
			{
				DataRowView row = (DataRowView)EmployeesGrid.SelectedItems[0];
				int CRID = (int)row["CRID"];

				DateTime dt = DateTime.Today;

				string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
				string CmdString = string.Empty;

				using (SqlConnection openCon = new SqlConnection(ConString))
				{
					string save = "UPDATE Table_ChequeReturns SET Status='Resolved' WHERE CRID=" + CRID + ";";

					using (SqlCommand querySave = new SqlCommand(save))
					{
						querySave.Connection = openCon;
						openCon.Open();
						querySave.ExecuteNonQuery();
					}

				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			FillGrid("Table_ChequeReturns");

		}


		private void closeWindow(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}

	

}
