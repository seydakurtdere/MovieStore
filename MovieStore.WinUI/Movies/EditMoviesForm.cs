using MovieStore.DTO;
using MovieStore.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore.WinUI.Movies
{
    public partial class EditMoviesForm : Form
    {
        public EditMoviesForm()
        {
            InitializeComponent();
        }

        private void EditMoviesForm_Load(object sender, EventArgs e)
        {
            using (MovieService movieService=new MovieService())
            {
                lbMovies.DataSource = movieService.List();
                lbMovies.DisplayMember = "MovieName";
                lbMovies.ValueMember = "MovieId";
            }

            using (DefinitionService definitionService=new DefinitionService())
            {
                cbGenres.DataSource = definitionService.GetGenres();
                cbGenres.DisplayMember = "GenreName";
                cbGenres.ValueMember = "GenreId";

                cbRecordStatuses.DataSource = definitionService.GetRecordStatus();
                cbRecordStatuses.DisplayMember = "RecordStatusName";
                cbRecordStatuses.ValueMember = "RecordStatusId";

            }
        }

        private void lbMovies_DoubleClick(object sender, EventArgs e)
        {
            using (MovieService movieService=new MovieService())
            {
                var selectedMovie = lbMovies.SelectedItem as MovieDTO;

                var selected = movieService.Get(selectedMovie.MovieId);

                txtMovieName.Text = selected.MovieName;
                cbGenres.SelectedValue = selected.GenreId;
                txtDirectorName.Text = selected.DirectorName;
                dtpReleaseDate.Value = selected.ReleaseDate;
                txtImdbScore.Text = selected.ImdbScore.ToString();
                txtQuantity.Text = selected.Quantity.ToString();
                txtUnitPrice.Text = selected.UnitPrice.ToString();
                cbRecordStatuses.SelectedValue = selected.RecordStatusId;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MovieService movieService = new MovieService())
            {
                var selected = lbMovies.SelectedItem as MovieDTO;

                MovieDTO movie = new MovieDTO
                {
                    MovieId = selected.MovieId,
                    MovieName = txtMovieName.Text,
                    GenreId =Convert.ToByte(cbGenres.SelectedValue),
                    DirectorName = txtDirectorName.Text,
                    ReleaseDate = dtpReleaseDate.Value,
                    ImdbScore =Convert.ToByte(txtImdbScore.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    RecordStatusId = Convert.ToByte(cbRecordStatuses.SelectedValue),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 2,
                    ModifiedBy = 3,
                    ModifiedDate = DateTime.Now
                };

                var result = movieService.Update(movie);

                if (result)
                {
                    lbMovies.DataSource = null;

                    lbMovies.DataSource = movieService.List();
                    lbMovies.DisplayMember = "MovieName";
                    lbMovies.ValueMember = "MovieId";

                    MessageBox.Show("güncellendi", "onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("güncellemede hata oluştu", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
