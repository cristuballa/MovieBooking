using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieBookingSytem.Core.Domain;
using MovieBookingSytem.Persistence;

namespace MovieBookingDesktop
{
    public partial class MovieScheduleView : Form
    {

        private readonly Movie _movie;
        public MovieScheduleView(Movie movie)
        {
            _movie = movie;
            InitializeComponent();
         
            ShowCinemaToCbo();
            lblMovie.Text = _movie.Title;
            dtpDateTo.Value=DateTime.Today;
            dtpDateFrom.Value=DateTime.Today;
            dtpTimeFrom.Value = DateTime.Now;
            dtpTimeTo.Value = DateTime.Now;

        }

        private void Add()
        {
            try
            {
                using (var unitOfWork=new UnitOfWork(new MovieBookingContext()))
                {
                    var movieschedule=new MovieSchedule
                                            {
                                               MovieId=_movie.Id,
                                               CinemaId=(int)cboCinema.SelectedValue,
                                               DateFrom =dtpDateFrom.Value,
                                               DateTo = dtpDateTo.Value,
                                               TimeFrom = dtpTimeFrom.Value,
                                               TimeTo = dtpTimeTo.Value,
                                               Price =(float)Convert.ToDecimal(txtPrice.Text),
                                               RowLetter = txtRowLetter.Text,
                                               SeatPerRow = Convert.ToInt32(txtSeatPerRow.Text)
  
                                            };

                    unitOfWork.MovieSchedules.Add(movieschedule);

                
                    if (unitOfWork.Complete() > 0)
                    {
                        MovieSchedule(_movie.Id);
                        cboCinema.SelectedIndex = 0;
                        txtPrice.Text = "";
                        txtRowLetter.Text = "";
                        txtSeatPerRow.Text = "";
                    }


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void MovieSchedule(int id)
        {

            using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
            {
                dgvSchedule.DataSource = null;
                dgvSchedule.Columns.Clear();

                var schedule = unitOfWork.MovieSchedules.GetMovieScheduleList(id);
                dgvSchedule.AutoGenerateColumns = false;
                dgvSchedule.DataSource = schedule;


                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "N2";

                DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
                column1.DataPropertyName = "Id";
                column1.Name = "No";
                column1.FillWeight = 8;
                column1.Visible = false;
                column1.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column1);

                DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
                column2.DataPropertyName = "Cinema";
                column2.Name = "Cinema";
                column2.FillWeight = 20;
                column2.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column2);

                DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
                column3.DataPropertyName = "DateFrom";
                column3.Name = "Date From";
                column3.FillWeight = 15;
                column3.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column3);

                DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
                column4.DataPropertyName = "DateTo";
                column4.Name = "Date To";
                column4.FillWeight = 15;
                column4.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column4);


                DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
                column5.DataPropertyName = "TimeFrom";
                column5.Name = "Time From";
                column5.FillWeight = 12;

                column5.DefaultCellStyle.Format = "HH:mm:ss";
                column5.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column5);

                DataGridViewColumn column8 = new DataGridViewTextBoxColumn();
                column8.DataPropertyName = "TimeTo";
                column8.Name = "Time To";
                column8.DefaultCellStyle.Format = "HH:mm:ss";
                column8.FillWeight = 12;
                column8.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column8);


                DataGridViewColumn column6 = new DataGridViewTextBoxColumn();
                column6.DataPropertyName = "Price";
                column6.Name = "Price";
                column6.FillWeight = 10;
                column6.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column6);


                DataGridViewColumn column7 = new DataGridViewTextBoxColumn();
                column7.DataPropertyName = "RowLetter";
                column7.Name = "Last Row";
                column7.FillWeight = 10;
                column7.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column7);


                DataGridViewColumn column9 = new DataGridViewTextBoxColumn();
                column9.DataPropertyName = "SeatPerRow";
                column9.Name = "Seats/Row";
                column9.FillWeight = 10;
                column9.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.Columns.Add(column9);

                dgvSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSchedule.Refresh();


            }
        }



        private void ShowCinemaToCbo()
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                {
                    var cinemas = unitOfWork.Cinemas.GetAll();
                    foreach (var cinema in cinemas)
                    {
                        cboCinema.DataSource = cinemas;
                        cboCinema.DisplayMember = "Name";
                        cboCinema.ValueMember = "Id";

                    }
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            Add();
        }


 

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtSeatPerRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void txtRowLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void MovieScheduleView_Load(object sender, EventArgs e)
        {

            MovieSchedule(_movie.Id);


        }


        private void dgvSchedule_KeyUp(object sender, KeyEventArgs e)
        {


            if(e.KeyCode==Keys.Delete )
            {

                try
                {
                    int id;

                    if (dgvSchedule.SelectedRows.Count > 0)
                        id = Convert.ToInt32(dgvSchedule.SelectedRows[0].Cells["No"].Value.ToString());
                    else
                        id = 0;

                    using (var unitOfWork = new UnitOfWork(new MovieBookingContext()))
                    {
                        if (MessageBox.Show(this, "Delete?", "Schedule", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            var movie = unitOfWork.MovieSchedules.Get(id);
                            unitOfWork.MovieSchedules.Remove(movie);
                            if (unitOfWork.Complete() > 0)
                            {
                                MovieSchedule(_movie.Id);
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
}
