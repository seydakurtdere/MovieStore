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
    public partial class NewMovieForm : Form
    {
        public NewMovieForm()
        {
            InitializeComponent();
        }

        List<MovieActorDTO> actors = new List<MovieActorDTO>();

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MovieService movieService = new MovieService())
            {
                MovieDTO movie = new MovieDTO
                {
                    MovieName = txtMovieName.Text,
                    GenreId = Convert.ToByte(cbGenres.SelectedValue),
                    DirectorName = txtDirectorName.Text,
                    ReleaseDate = dtpReleaseDate.Value,
                    ImdbScore = Convert.ToByte(txtImdbScore.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    RecordStatusId = 1,
                    CreatedDate = DateTime.Now,
                    CreatedBy = 2
                };

                movie.ActorList = actors;
                if (movie.ActorList.Count > 0)
                {



                    var result = movieService.Add(movie);

                    if (result != null)
                    {
                        lbActors.DataSource = null;

                        lbActors.DataSource = actors;
                        lbActors.DisplayMember = "FullName";
                        lbActors.ValueMember = "MovieActorId";

                        MessageBox.Show("Kayıt başarılı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Kayıt sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen oyuncu ekleyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MovieActorDTO movieActor = new MovieActorDTO();

            movieActor.FullName = txtMovieActor.Text;

            actors.Add(movieActor);
     
            lbActors.DataSource = null;

            lbActors.DataSource = actors;
            lbActors.DisplayMember = "FullName";
            lbActors.ValueMember = "MovieActorId";
        }

        private void NewMovieForm_Load(object sender, EventArgs e)
        {
            using (DefinitionService definitionService = new DefinitionService())
            {
                cbGenres.DataSource = definitionService.GetGenres();
                cbGenres.DisplayMember = "GenreName";
                cbGenres.ValueMember = "GenreId";

            }
        }
    }
}
