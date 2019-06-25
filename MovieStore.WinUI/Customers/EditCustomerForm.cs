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

namespace MovieStore.WinUI.Customers
{
    public partial class EditMovieForm : Form
    {
        public EditMovieForm()
        {
            InitializeComponent();
        }

        private void EditMovieForm_Load(object sender, EventArgs e)
        {
            using (DefinitionService definitionService = new DefinitionService())
            {
                cbRecordStatus.DataSource = definitionService.GetRecordStatus();
                cbRecordStatus.DisplayMember = "RecordStatusName";
                cbRecordStatus.ValueMember = "RecordStatusId";
            }

            using (CustomerService ucustomerService = new CustomerService())
            {
                var customers = ucustomerService.List();
                lbCustomers.DataSource = customers;
                lbCustomers.DisplayMember = "DisplayString";
                lbCustomers.ValueMember = "CustomerId";
            }

        }

        private void lbCustomers_DoubleClick(object sender, EventArgs e)
        {
            var selectedCustomer = lbCustomers.SelectedItem as CustomerDTO;

            using (CustomerService customerService = new CustomerService())
            {
                var customer = customerService.Get(selectedCustomer.CustomerId);

                txtFirstName.Text = customer.FirstName;
                txtLastName.Text = customer.LastName;
                txtTcNumber.Text = customer.TcNumber;
                txtMobilePhone.Text = customer.MobilePhone;
                cbRecordStatus.SelectedValue = customer.RecordStatusId;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (CustomerService customerService=new CustomerService())
            {
                CustomerDTO customer = new CustomerDTO
                {
                    CustomerId = Convert.ToInt32(lbCustomers.SelectedValue),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    TcNumber = txtTcNumber.Text,
                    MobilePhone = txtMobilePhone.Text,
                    CreatedDate = DateTime.Now,
                    RecordStatusId = Convert.ToByte(cbRecordStatus.SelectedValue),
                    CreatedBy = 2
                };

                var result = customerService.Update(customer);

                if (result)
                {
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
