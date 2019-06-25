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

namespace MovieStore.WinUI.Rentals
{
    public partial class NewRentalForm : Form
    {
        public NewRentalForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (RentalService rentalService=new RentalService())
            {
                RentalDTO rental = new RentalDTO
                {
                    CustomerId = Convert.ToInt32(cbCustomers.SelectedValue),
                    MovieId = Convert.ToInt32(cbMovies.SelectedValue),
                    BeginDate = dtpBeginDate.Value,
                    EndDate = dtpEndDate.Value,
                    TotalPrice =Convert.ToDecimal(txtTotalPrice.Text),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 2,
                    RecordStatusId = 1

                };

                var result = rentalService.Add(rental);

                if (result != null)
                {
                    MessageBox.Show("Kayıt başarılı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void NewRentalForm_Load(object sender, EventArgs e)
        {
            using (CustomerService customerService=new CustomerService())
            {
                cbCustomers.DataSource = customerService.List();
                cbCustomers.DisplayMember = "DisplayString";
                cbCustomers.ValueMember = "CustomerId";
            }
            using (MovieService movieService = new MovieService())
            {
                cbMovies.DataSource = movieService.List();
                cbMovies.DisplayMember = "MovieName";
                cbMovies.ValueMember = "MovieId";
            }

        }
    }
}
