using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        private StorageDBContext db = new StorageDBContext();
        private Password admin,employee;

        public Login()
        {
            InitializeComponent();
            admin = db.Passwords.Find(1);
            if (admin == null)
            {
                admin = new Password();
                employee = new Password();
                admin.Id = 1;
                employee.Id = 2;
                admin.password = "1234";
                employee.password = "1234";
                db.Passwords.Add(admin);
                db.Passwords.Add(employee);
                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;

            admin = db.Passwords.Find(1);
            employee = db.Passwords.Find(2);

            db.Entry(admin).Reload();
            db.Entry(employee).Reload();

            admin = db.Passwords.Find(1);
            employee = db.Passwords.Find(2);

            if (this.password.Text.Equals(admin.password) &&
                this.comboBox1.SelectedItem.ToString().Equals("管理员"))
            {
                this.Hide();
                Storage str = new Storage(true);
                str.Show();
            }
            else if (this.password.Text.Equals(employee.password) &&
                this.comboBox1.SelectedItem.ToString().Equals("员工"))
            {
                this.Hide();
                Storage str = new Storage(false);
                str.Show();
            }
            else
            {
                this.label1.Visible = true;
                this.label1.Text = "组合不对";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            Form1 form = new Form1();
            form.Show();
        }

    }
}
