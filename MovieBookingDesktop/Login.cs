using System;
using System.Configuration;
using System.Windows.Forms;
using MovieBookingSytem.Persistence;
using System.Data.SqlClient;
using System.Data;

namespace MovieBookingDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //"data source=server85;initial catalog=MovieBooking;integrated security=True;MultipleActiveResultSets=True;App=MovieBookingSystem"

            string dbsvr = txtServer.Text ;
            string dbCatalog = txtDb.Text ;
            string dbUser =txtUser.Text ;
            string dbPW =txtPassword.Text;
            string _connStr;
            _connStr = string.Format("Data Source = {0}; Initial Catalog = {1};User ID = {2}; Password={3};", dbsvr, dbCatalog, dbUser, dbPW);

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["MovieBookingContext"].ConnectionString = _connStr;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            try
            {

                using (var conn = new SqlConnection(_connStr))
                {
                    conn.Open();

                    ConnectionState conState = conn.State;

                    if (conState == ConnectionState.Closed || conState == ConnectionState.Broken)
                    {
                        MessageBox.Show("Unable to login.");
                    }
                    else
                    {
                        var movielist = new MovieList();
                        movielist.Show();
                        this.Hide();

                    }
 

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Movie Booking", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    Environment.Exit(0);
        }
    }
}
