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
         
        }
        private void MoviesList(string keyword)
        {


            try
            {
                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    dgvMovies.DataSource = null;
                    dgvMovies.Columns.Clear();
                    //Get movie from the database
                    var movies = unitOfWork.Movies.GetMoviesList(keyword);
                    dgvMovies.AutoGenerateColumns = false;

                    //Asssig movies object to the grid
                    dgvMovies.DataSource = movies;

                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.Format = "N2";

                    DataGridViewColumn column1 = new DataGridViewTextBoxColumn();

                    column1.DataPropertyName = "Id";
                    column1.Name = "No";
                    column1.FillWeight = 8;
                    //  column1.Visible = false;
                    column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvMovies.Columns.Add(column1);

                    DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                    column2.DataPropertyName = "Title";
                    column2.Name = "Title";
                    column2.FillWeight = 10;
                    column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvMovies.Columns.Add(column2);

                    DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                    column3.DataPropertyName = "Description";
                    column3.Name = "Description";
                    column3.FillWeight = 30;
                    column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvMovies.Columns.Add(column3);

                    DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
                    column4.DataPropertyName = "Director";
                    column4.Name = "Director";
                    column4.FillWeight = 10;
                    column4.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvMovies.Columns.Add(column4);


                    DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
                    column5.DataPropertyName = "Casts";
                    column5.Name = "Cast";
                    column5.FillWeight = 40;
                    column5.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvMovies.Columns.Add(column5);


                    dgvMovies.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    dgvMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvMovies.Refresh();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }
         
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
           var movie =new MovieView();
            movie.Show();

        }


        private void cmdFind_Click(object sender, EventArgs e)
        {
            MoviesList(txtKeyword.Text);
        }

        private void dgvMovies_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvMovies.SelectedRows.Count > 0)
                {
                    //open Movie Detail
                    int id = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["No"].Value.ToString());
                    var movie = new MovieView();
                    movie.GetMovie(id);
                    movie.Show();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MovieList_Load(object sender, EventArgs e)
        {
           // MoviesList("");
        }

        private void txtKeyword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                MoviesList(txtKeyword.Text);
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            MoviesList(txtKeyword.Text);
        }

        private void tsbNewCinema_Click(object sender, EventArgs e)
        {
            var cinema = new CinemaView();
            cinema.Show();

        }
            
        private void tsbCinemaList_Click(object sender, EventArgs e)
        {
            var cinemalist = new CinemaListView();
            cinemalist.Show();
        }

        private void tsbMoviesList_Click(object sender, EventArgs e)
        {
            MoviesList(txtKeyword.Text);
        }

        private void tsbNewSchedule_Click(object sender, EventArgs e)
        {

            //Open new movie User Interface
            try
            {
                int id;

                if (dgvMovies.SelectedRows.Count > 0)
                     id = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["No"].Value.ToString());
                else
                 id = 0;

                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    var movie = unitOfWork.Movies.Get(id);
                    var movieSchedule = new MovieScheduleView(movie);
                    movieSchedule.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void MovieList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgvMovies_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int id;

                if (dgvMovies.SelectedRows.Count > 0)
                    id = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells["No"].Value.ToString());
                else
                    id = 0;

                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    if (MessageBox.Show(this, "Delete?", "Movie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var movie=unitOfWork.Movies.Get(id);
                            unitOfWork.Movies.Remove(movie);

                        if (unitOfWork.Complete() > 0)
                        {
                            MoviesList("");
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
}
