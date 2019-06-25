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
    public partial class EditRentalForm : Form
    {
        public EditRentalForm()
        {
            InitializeComponent();
        }

        private void EditRentalForm_Load(object sender, EventArgs e)
        {
            using (RentalService rentalService=new RentalService())
            {
                lbRentals.DataSource = rentalService.List();
                lbRentals.DisplayMember = "DisplayString";
                lbRentals.ValueMember = "RentalId";
            }
            using (MovieService movieService = new MovieService())
            {
                cbMovies.DataSource = movieService.List();
                cbMovies.DisplayMember = "MovieName";
                cbMovies.ValueMember = "MovieId";
                cbMovies.SelectedIndex = -1;
            }
            using (CustomerService customerService = new CustomerService())
            {
                cbCustomers.DataSource = customerService.List();
                cbCustomers.DisplayMember = "DisplayString";
                cbCustomers.ValueMember = "CustomerId";
                cbCustomers.SelectedIndex = -1;
            }

            using (DefinitionService definitionService=new DefinitionService())
            {
                cbRecordStatuses.DataSource = definitionService.GetRecordStatus();
                cbRecordStatuses.DisplayMember = "RecordStatusName";
                cbRecordStatuses.ValueMember = "RecordStatusId";
                cbRecordStatuses.SelectedIndex = -1;
            }
        }

        private void lbRentals_DoubleClick(object sender, EventArgs e)
        {
            using (RentalService rentalService=new RentalService())
            {
                int rentalId =Convert.ToInt32(lbRentals.SelectedValue);
                var selected = rentalService.Get(rentalId);

                cbCustomers.SelectedValue = selected.CustomerId;
                cbMovies.SelectedValue = selected.MovieId;
                cbRecordStatuses.SelectedValue = selected.RecordStatusId;
                txtTotalPrice.Text = selected.TotalPrice.ToString();
                dtpBeginDate.Value = selected.BeginDate;
                dtpEndDate.Value = selected.EndDate;

    }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (RentalService rentalService=new RentalService())
            {
                int rentalId = Convert.ToInt32(lbRentals.SelectedValue);
                var selected = rentalService.Get(rentalId);

                RentalDTO rental = new RentalDTO
                {
                    RentalId = selected.RentalId,
                    CustomerId = Convert.ToInt32(cbCustomers.SelectedValue),
                    MovieId = Convert.ToInt32(cbMovies.SelectedValue),
                    BeginDate = dtpBeginDate.Value,
                    EndDate = dtpEndDate.Value,
                    TotalPrice = Convert.ToDecimal(txtTotalPrice.Text),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 2,
                    RecordStatusId = Convert.ToByte(cbRecordStatuses.SelectedValue)

                };

                var result = rentalService.Update(rental);

                if (result)
                {
                    lbRentals.DataSource = null;

                    lbRentals.DataSource = rentalService.List();
                    lbRentals.DisplayMember = "DisplayString";
                    lbRentals.ValueMember = "RentalId";
            

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
