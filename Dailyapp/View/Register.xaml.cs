using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data;
using System.Data.SqlClient;
using Dailyapp.Data;

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
                ConexionMain cn = new ConexionMain();
                ConexionMain.Abrir();

                SqlCommand cmd = new SqlCommand("INSERT INTO dailyuser(username,userpass) values(@userName,@userPass)", ConexionMain.conectar);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@userName", DailyUser);
                cmd.Parameters.AddWithValue("@userPass", PasswordUser);
                cmd.ExecuteNonQuery();
                //DisplayAlert("User Register");
                ConexionMain.Cerrar();
      
                
            }
			catch (Exception ex)
			{

                DisplayAlert("Error", ex.Message, "Okay");
			}
        }
    }
}