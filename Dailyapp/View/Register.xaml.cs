using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data;
using System.Data.SqlClient;


namespace Dailyapp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Register : ContentPage
	{
		public Register ()
		{
			InitializeComponent ();
		}

        private void Registrarbutt_Clicked(object sender, EventArgs e)
        {
			try
			{
                SqlConnection cn = new SqlConnection("Data Source = 192.168.0.101; Initial Catalog = DESKTOP-I9OFA2R;Integrate Security = False; User Id = dailyadmin; Password = 12345678");
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO dailyuser(username,userpass) values(@userName,@userPass)", cn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@userName", DailyUser);
                    cmd.Parameters.AddWithValue("@userPass", PasswordUser);
                    cmd.ExecuteNonQuery();
                    DisplayAlert("User Register","","");
                    cn.Close();
                }      
                
            }
			catch (Exception ex)
			{

                DisplayAlert("Error", ex.Message, "Okay");
			}
        }
    }
}