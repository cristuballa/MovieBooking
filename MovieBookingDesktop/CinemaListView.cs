using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieBookingSytem.Persistence;

namespace MovieBookingDesktop
{
    public partial class CinemaListView : Form
    {
        public CinemaListView()
        {
            InitializeComponent();
            
        }

        private void Cinemas(string keyword)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    dgvCinemas.DataSource = null;
                    dgvCinemas.Columns.Clear();

                    var payments = unitOfWork.Cinemas.GetCinemaList(keyword);

                    dgvCinemas.AutoGenerateColumns = false;
                    dgvCinemas.DataSource = payments;

                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.Format = "N2";

                    DataGridViewColumn column1 = new DataGridViewTextBoxColumn();

                    column1.DataPropertyName = "Id";
                    column1.Name = "No";
                    column1.FillWeight = 8;
                    column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvCinemas.Columns.Add(column1);

                    DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                    column2.DataPropertyName = "Name";
                    column2.Name = "Name";
                    column2.FillWeight = 10;
                    column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvCinemas.Columns.Add(column2);

                    DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                    column3.DataPropertyName = "Address";
                    column3.Name = "Address";
                    column3.FillWeight = 30;
                    column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvCinemas.Columns.Add(column3);

                    DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
                    column4.DataPropertyName = "Contact";
                    column4.Name = "Contact";
                    column4.FillWeight = 15;
                    column4.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvCinemas.Columns.Add(column4);

                    dgvCinemas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvCinemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCinemas.Refresh();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }
          
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
           Cinemas(txtKeyword.Text);
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            var cinemaview=new CinemaView();
            cinemaview.Show();
        }

        private void dgvCinemas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvCinemas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCinemas.SelectedRows[0].Cells["No"].Value.ToString());
                var cinema = new CinemaView();
                cinema.GetCinema(id);
                cinema.Show();

            }
        }

        private void CinemaList_Load(object sender, EventArgs e)
        {
            Cinemas("");
        }

        private void txtKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Cinemas(txtKeyword.Text);
            }
        }

        private void dgvCinemas_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {

                try
                {
                    int id;

                    if (dgvCinemas.SelectedRows.Count > 0)
                        id = Convert.ToInt32(dgvCinemas.SelectedRows[0].Cells["No"].Value.ToString());
                    else
                        id = 0;

                    using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                    {
                        if (MessageBox.Show(this, "Delete?", "Cinema", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var movie = unitOfWork.MovieSchedules.Get(id);
                            unitOfWork.MovieSchedules.Remove(movie);
                            if (unitOfWork.Complete() > 0)
                            {
                                Cinemas("");
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void dgvCinemas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
