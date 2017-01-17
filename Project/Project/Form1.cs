using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        private StorageDBContext db = new StorageDBContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label4.Visible = false;
            if (this.comboBox1.SelectedItem != null)
            {
                int i = this.comboBox1.SelectedItem.ToString().Equals("管理员") ? 1 : 2;
                Password pass = db.Passwords.Find(i);
                if (pass != null)
                {
                    if (this.textBox1.Text.Equals(pass.password))
                    {
                        if (this.textBox2.Text.Equals(this.textBox3.Text))
                        {
                            pass.password = this.textBox2.Text;
                            db.Entry(pass).State = EntityState.Modified;
                            db.SaveChanges();
                            db.Entry(pass).Reload();
                            this.Close();
                        }
                        else
                        {
                            this.label4.Visible = true;
                            this.label4.Text = "新密码不相等";
                        }
                    }
                    else
                    {
                        this.label4.Visible = true;
                        this.label4.Text = "密码不正确";
                    }
                }
                else
                {
                    this.label4.Visible = true;
                    this.label4.Text = "不存在数据";
                }
            }
        }

    }
}
