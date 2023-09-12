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

        public void CrearUsuario()
        {
            try
            {
                ConexionMain.Abrir();
                SqlCommand  cmd = new SqlCommand ("select * from dailyuser", ConexionMain.conectar);
                SqlDataReader rdr = cmd.ExecuteReader ();

            }
            catch (Exception)
            {

            }
        }
    }
}