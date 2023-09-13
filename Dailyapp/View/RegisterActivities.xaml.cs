using Dailyapp.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dailyapp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterActivities : ContentPage
	{
		public RegisterActivities ()
		{
			InitializeComponent ();
		}

        public void CrearUsuario()
        {
            try
            {
                registerdaily.Children.Add(registerdaily);
                ConexionMain.Abrir();
                SqlCommand coma = new SqlCommand("select * from dailyactivies", ConexionMain.conectar);
                SqlDataReader rdear = coma.ExecuteReader();
                while (rdear.Read())
                {
                    StackLayout dailybox = new StackLayout();
                    Entry dame = new Entry();
                    Entry ddate = new Entry();
                    Entry dtime = new Entry();
                    Entry ddescript = new Entry();
                    Button daccept = new Button();

                }
            }
            catch (Exception)
            {

            }
        }
    }
}