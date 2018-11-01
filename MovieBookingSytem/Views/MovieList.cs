using System;
using System.Drawing;
using System.Windows.Forms;
using MovieBookingSytem.Persistence;

namespace MovieBookingDesktop
{
    public partial class MovieList : Form
    {
        public MovieList()
        {
            InitializeComponent();
            MoviesList("");
        }
        private void MoviesList(string keyword)
        {

            using (var unitOfWork = new UnitOfWork(new  MovieBookingContext()))
            {
                dgvMovies.DataSource = null;
                dgvMovies.Columns.Clear();

                var payments = unitOfWork.Movies.GetMoviesList(keyword);
                dgvMovies.AutoGenerateColumns = false;
                dgvMovies.DataSource = payments;

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "N2";

                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();

                column1.DataPropertyName = "Id";
                column1.Name = "No";
                column1.FillWeight = 8;
                column1.Visible = false;
                column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvMovies.Columns.Add(column1);

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "Title";
                column2.Name = "Title";
                column2.FillWeight = 18;
                column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvMovies.Columns.Add(column2);

                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "Description";
                column3.Name = "Description";
                column3.FillWeight = 25;
                column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvMovies.Columns.Add(column3);

                DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
                column4.DataPropertyName = "Director";
                column4.Name = "Director";
                column4.FillWeight = 15;
                column4.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvMovies.Columns.Add(column4);


                DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
                column5.DataPropertyName = "Casts";
                column5.Name = "Cast";
                column5.FillWeight = 15;
                column5.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvMovies.Columns.Add(column4);

                dgvMovies.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMovies.Refresh();


            }
        }

        private void MovieList_Load(object sender, EventArgs e)
        {

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
           var movie =new MovieView();
            movie.Show();

        }
    }
}
