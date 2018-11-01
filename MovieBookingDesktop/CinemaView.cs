using System;
using System.Windows.Forms;
using MovieBookingSytem.Core.Domain;
using MovieBookingSytem.Persistence;

namespace MovieBookingDesktop
{
    public partial class CinemaView : Form
    {
        public CinemaView()
        {
            InitializeComponent();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            int result;

            if (int.TryParse(txtId.Text, out result))
                Update(Convert.ToInt32(txtId.Text));
            else
                Save();
        }


        private void Save()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                  
                    var cinema = new Cinema() {Name = txtName.Text,Contact=txtContact.Text,Address = txtAddress.Text};
                    unitOfWork.Cinemas.Add(cinema);
                  
                    
                    if (unitOfWork.Complete() > 0)
                    {
                        txtId.Text = cinema.Id.ToString();
                        MessageBox.Show(@"Save Successfull");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Update(int Id)
        {
            try
            {
                var image = new ImageByteConverter();
                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    var cinema = unitOfWork.Cinemas.Get(Id);
                    cinema.Name = txtName.Text;
                    cinema.Address =txtAddress.Text;
                    cinema.Contact = txtContact.Text;

                 
                    if (unitOfWork.Complete() > 0)
                    {
                        MessageBox.Show(@"Update Successfull");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void GetCinema(int Id)
        {
            try
            {

                var image = new ImageByteConverter();

                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    var cinema = unitOfWork.Cinemas.Get(Id);

                    txtId.Text = cinema.Id.ToString();
                    txtName.Text = cinema.Name;
                    txtAddress.Text =cinema.Address;
                    txtContact.Text = cinema.Contact;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
