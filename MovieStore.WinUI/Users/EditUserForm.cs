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

namespace MovieStore.WinUI.Users
{
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            using (DefinitionService definitionService = new DefinitionService())
            {
                cbRecordStatus.DataSource = definitionService.GetRecordStatus();
                cbRecordStatus.DisplayMember = "RecordStatusName";
                cbRecordStatus.ValueMember = "RecordStatusId";
            }

            using (UserService userService = new UserService())
            {
                var users = userService.List();
                lbUsers.DataSource = users;
                lbUsers.DisplayMember = "DisplayString";
                lbUsers.ValueMember = "UserId";
            }
        }

        private void lbUsers_DoubleClick(object sender, EventArgs e)
        {
            var selectedUser = lbUsers.SelectedItem as UserDTO;

            using (UserService userService = new UserService())
            {
                var user = userService.Get(selectedUser.UserId);

                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtUserName.Text = user.UserName;
                txtPassword.Text = user.Password;
                cbRecordStatus.SelectedValue = user.RecordStatusId;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (UserService userService=new UserService())
            {
                UserDTO user = new UserDTO
                {
                    UserId = Convert.ToInt32(lbUsers.SelectedValue),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    LastLoginDate = DateTime.Now,
                    RecordStatusId =Convert.ToByte(cbRecordStatus.SelectedValue),
                    CreatedDate = DateTime.Now,
                    CreatedBy = 2
                };
                var result = userService.Update(user);

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
