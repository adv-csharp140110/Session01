using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App01.DataSource;
using App01.Model;
using App01.Service;

namespace App01.UI
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        UserService userService = new UserService();
        private int currentIndex = 0;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Id = int.Parse(textBoxId.Text),
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text
            };

            userService.Add(user);

            clearForm();
        }

        private void clearForm()
        {
            textBoxId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            showCurrentUser();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            currentIndex = InMemoryDB.Users.Count - 1;
            showCurrentUser();
        }

        private void showCurrentUser()
        {
            var user = userService.GetByIndex(currentIndex);
            textBoxId.Text = user.Id.ToString();
            textBoxFirstName.Text = user.FirstName;
            textBoxLastName.Text = user.LastName;
            textBoxPhone.Text = user.Phone;
            textBoxEmail.Text = user.Email;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = 0;
            showCurrentUser();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex > InMemoryDB.Users.Count - 1)
                currentIndex = InMemoryDB.Users.Count - 1;
            showCurrentUser();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        //DRY: Don't Repeat Yourself
    }
}
