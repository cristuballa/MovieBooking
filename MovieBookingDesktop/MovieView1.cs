using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using MovieBookingSytem.Core.Domain;
using MovieBookingSytem.Persistence;
using System.Threading.Tasks;

namespace MovieBookingDesktop
{
    public partial class MovieView : Form
    {
        public MovieView()
        {
            InitializeComponent();
            dtpReleaseDate.Value = DateTime.Today;
            ShowGenreToCbo();
            cboGenre.SelectedIndex = 0;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
           int result;

            if (int.TryParse(txtMovieId.Text, out result))
                Update(Convert.ToInt32(txtMovieId.Text));
            else
                Save();
        }



        private void Save()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    var image = new ImageByteConverter();
                    
                    //Supply the Movie object data
                    var movie = new Movie {
                                            Title = txtTitle.Text,
                                            Poster = image.ImageToByte(picPoster.Image),
                                            ReleaseDate = dtpReleaseDate.Value,
                                            Description = txtDescription.Text,
                                            Genre = (Genre)Enum.Parse(typeof(Genre), cboGenre.SelectedItem.ToString()),
                                            ImdbRating = (float)Convert.ToDecimal(txtIMDBRating.Text),
                                            RottenTomatoesRating = (float)Convert.ToDecimal(txtRottenTomatoes.Text),
                                            PgRating = txtPgRating.Text,
                                            Trailer = txtTrailerLink.Text,
                                            Director = txtDirector.Text,
                                            Casts = txtCast.Text
                                         };
                    //Add object to DBContext
                    unitOfWork.Movies.Add(movie);
                   //Save to the database
                    if (unitOfWork.Complete() > 0)
                    {
                        MessageBox.Show(@"Save Successfull");
                        txtMovieId.Text = movie.Id.ToString();
                    }

                   

                }
            }

      
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update(int movieId)
        {
            try
            {
                var image = new ImageByteConverter();
               
                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                    {

                    // Get Movie from Database
                    var movie = unitOfWork.Movies.Get(movieId);
                        movie.Title = txtTitle.Text;
                        movie.Poster =image.ImageToByte(picPoster.Image);
                        movie.ReleaseDate = dtpReleaseDate.Value;
                        movie.Description = txtDescription.Text;
                        movie.Genre = (Genre) Enum.Parse(typeof(Genre), cboGenre.SelectedItem.ToString());
                        movie.ImdbRating = (float) Convert.ToDecimal(txtIMDBRating.Text);
                        movie.RottenTomatoesRating = (float) Convert.ToDecimal(txtRottenTomatoes.Text);
                        movie.PgRating = txtPgRating.Text;
                        movie.Trailer = txtTrailerLink.Text;
                        movie.Director = txtDirector.Text;
                        movie.Casts = txtCast.Text;
                    // Add  Movie to the context
                    // unitOfWork.Movies.Add(movie);
                    // Save movie to the database
                        if (unitOfWork.Complete() > 0)
                        {
                        MessageBox.Show(@"Update Successfull");
                            txtMovieId.Text = movie.Id.ToString();
                        }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void GetMovie(int movieId)
        {
            try
            {
            var image = new ImageByteConverter();

                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {

                // Get Movie from Database and and show to UI

                    var movie = unitOfWork.Movies.Get(movieId); 
                    txtMovieId.Text = movie.Id.ToString();
                    txtTitle.Text= movie.Title;
                    dtpReleaseDate.Value = movie.ReleaseDate;
                    txtDescription.Text = movie.Description;
                    cboGenre.SelectedIndex =(int)movie.Genre;
                    txtIMDBRating.Text=movie.ImdbRating.ToString();
                    txtRottenTomatoes.Text = movie.RottenTomatoesRating.ToString();
                    txtPgRating.Text= movie.PgRating ;
                    txtTrailerLink.Text = movie.Trailer ;
                    txtDirector.Text= movie.Director ;
                    txtCast.Text = movie.Casts ;
                    picPoster.Image = image.ByteToImage(movie.Poster);                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowGenreToCbo()
        {
            try
            {

                foreach (var item in Enum.GetValues(typeof(Genre)))
                {
                    cboGenre.Items.Add(item);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                //dlg.Filter = "bmp files (*.bmp)|*.bmp|*.jpeg|*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox pic = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pic.Image = new Bitmap(dlg.FileName);
                    txtPosterPath.Text = dlg.FileName;
                    picPoster.Image = pic.Image;
                    
                }
            }
        }

        private void opdPoster_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
 
        }

        private void txtRottenTomatoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtIMDBRating_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void tsbMovieSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    var movie = unitOfWork.Movies.Get(Convert.ToInt32(txtMovieId.Text));
                    var movieSchedule = new MovieScheduleView(movie);
                    movieSchedule.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void txtIMDBRating_TextChanged(object sender, EventArgs e)
        {

        }

        private void MovieView_Load(object sender, EventArgs e)
        {

        }
    }
}
