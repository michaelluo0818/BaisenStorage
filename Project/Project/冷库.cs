using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Project
{
    public partial class Storage : Form
    {
        private StorageDBContext db = new StorageDBContext();
        private static Month month;
        private static DateTime currentM = DateTime.Today;
        private int col = 0, row = 0;
        private bool admin = false;
        private static double totalRent = 0;
        private static double totalPaid = 0;

        public Storage(bool admin)
        {
            InitializeComponent();
            this.admin = admin;
            if (this.admin)
            {
                this.hide.Enabled = true;
                this.unused.Enabled = true;
                this.used.Enabled = true;
                this.EmailF.Enabled = true;
                this.PhoneF.Enabled = true;
                this.NameF.Enabled = true;
                this.Save.Enabled = true;
                this.permsave.Enabled = true;
                this.RentF.Enabled = true;
                this.AreaF.Enabled = true;
            }
            this.MonthPicker.Value = DateTime.Today;
            month = db.Months.Find(this.MonthPicker.Value.ToString("yyyy/MM"));
            if (month == null)
            {
                if (db.Months.Find(this.MonthPicker.Value.AddMonths(-1).ToString("yyyy/MM")) == null)
                {
                    initValue();
                }
                else
                {
                    month = db.Months.Find(this.MonthPicker.Value.AddMonths(-1).ToString("yyyy/MM"));
                    currentM = currentM.AddMonths(-1);
                    this.MonthPicker.Value = currentM;
                }
            }
            initList();
                
        }

        private void initValue()
        {
            month = new Month();
            month.CurrentMonth = DateTime.Today.ToString("yyyy/MM");
            month.Rooms = new List<Room>();
            for (int i = 0; i < 25; i++)
            {
                Room room = new Room();
                room.Uid = Guid.NewGuid();
                room.Str = new List<Storages>();
                room.Unit = (i + 1);
                for (int j = 0; j < 13; j++)
                {
                    Storages str = initStorage(j);
                    room.Str.Add(str);
                }
                month.Rooms.Add(room);
            }
            db.Months.Add(month);
            db.SaveChanges();
            this.Text = "总应收： " + totalRent + "                       总已收： " + totalPaid;
        }

        private void initList()
        {
            this.Lists.ColumnCount = 13;
            this.Lists.RowHeadersWidth = this.Lists.Width/28;
            this.Lists.RowHeadersWidth = 49;
            int count = 1;

            for (int i = 1; i < this.Lists.ColumnCount + 1; i++)
            {
                this.Lists.Columns[i-1].Name = "" + i;
                this.Lists.Columns[i - 1].Width = (this.Lists.Width - this.Lists.RowHeadersWidth)/13;
                this.Lists.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (Room room in month.Rooms.OrderBy(a => a.Unit))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = "" + count++;
                row.Height = this.Lists.Height / 26;
                row.CreateCells(this.Lists);
                int i = 0;
                foreach(DataGridViewCell cell in row.Cells)
                {
                    Storages str = room.Str.OrderBy(a => a.unit).ElementAt(i++);
                    cell.Value = "";
                    cell.ReadOnly = true;

                    DataGridViewCellStyle style = setStyles(str);
                    cell.Style = style;
                }
                this.Lists.Rows.Add(row);
            }
            totalPaid = 0;
            totalRent = 0;
            foreach (Room room in month.Rooms)
            {
                foreach (Storages _str in room.Str)
                {
                    totalPaid += _str.sumPaid;
                    totalRent += _str.rent;
                }
            }
            this.Text = "总应收： " + totalRent + "                       总已收： " + totalPaid;
        }

        public DataGridViewCellStyle setStyles(Storages str)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            if (!str.notEmpty)
            {
                style.BackColor = Color.White;
            }
            else if (!str.used)
            {
                style.BackColor = Color.NavajoWhite;
            }
            else if (str.sumPaid >= str.rent && str.notEmpty && str.used && str.rent > 0)
            {
                style.BackColor = Color.Aquamarine;
            }
            else
            {
                style.BackColor = Color.LightCoral;
            }
            return style;
        }

        public Storages readStorage(Storages str)
        {
            Storages _str = new Storages();
            _str.Uid = Guid.NewGuid();
            _str.notEmpty = str.notEmpty;
            _str.carryOver = str.carryOver;
            _str.used = str.used;
            _str.unit = str.unit;
            _str.name = str.name;
            _str.email = str.email;
            _str.phoneNum = str.phoneNum;
            _str.desc = str.desc;
            _str.area = str.area;
            _str.rent = str.rent;
            _str.rentleft = 0;
            _str.chequePaid = 0;
            _str.cashPaid = 0;
            _str.cardPaid = 0;
            _str.sumPaid = 0;
            totalRent += str.rent;
            return _str;
        }

        public Storages initStorage(int unit)
        {
            Storages _str = new Storages();
            _str.Uid = Guid.NewGuid();
            _str.notEmpty = false;
            _str.carryOver = false;
            _str.used = false;
            _str.unit = unit;
            _str.name = "";
            _str.email = "";
            _str.phoneNum = "";
            _str.desc = "";
            _str.area = 0;
            _str.rent = 0;
            _str.rentleft = 0;
            _str.chequePaid = 0;
            _str.cashPaid = 0;
            _str.cardPaid = 0;
            _str.sumPaid = 0;
            return _str;
        }

        private void Lists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            col = e.ColumnIndex;
            row = e.RowIndex;
            refreshstuff();
        }

        private void refreshstuff()
        {
            if (row >= 0 && col >= 0)
            {
                Storages str = db.Strs.Find(month.Rooms.OrderBy(a => a.Unit).ElementAt(row).Str.OrderBy(a => a.unit).ElementAt(col).Uid);
                this.NameF.Text = str.name;
                this.PhoneF.Text = str.phoneNum;
                this.EmailF.Text = str.email;
                this.RentF.Text = str.rent.ToString();
                this.AreaF.Text = str.area.ToString();
                if (!str.notEmpty)
                {
                    this.Empty.BackColor = Color.Transparent;
                }
                else if (!str.used)
                {
                    this.Empty.BackColor = Color.NavajoWhite;
                }
                else if (str.sumPaid >= str.rent && str.notEmpty && str.used && str.rent > 0)
                {
                    this.Empty.BackColor = Color.Aquamarine;
                }
                else 
                {
                    this.Empty.BackColor = Color.LightCoral;
                }
                this.DescriptionF.Text = str.desc;
                this.RentLeftF.Text = str.rentleft.ToString();
                this.Sum.Text = "当月已收： " + str.sumPaid;
                this.Rent2.Text = "当月应收： " + str.rent;
                this.Card2.Text = "卡： " + str.cardPaid;
                this.Cash2.Text = "现金： " + str.cashPaid;
                this.Cheque2.Text = "支票： " + str.chequePaid;
                DataGridViewCellStyle style = setStyles(str);
                this.Lists.CurrentCell.Style = style;
                totalPaid = 0;
                totalRent = 0;
                foreach (Room room in month.Rooms)
                {
                    foreach (Storages _str in room.Str)
                    {
                        totalPaid += _str.sumPaid;
                        totalRent += _str.rent;
                    }
                }
                this.Text = "总应收： " + totalRent + "                       总已收： " + totalPaid;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Storages str = db.Strs.Find(month.Rooms.OrderBy(b => b.Unit).ElementAt(row).Str.OrderBy(b => b.unit).ElementAt(col).Uid);
            decimal a;

            if(!string.IsNullOrWhiteSpace(this.NameF.Text) &&
               !string.IsNullOrWhiteSpace(this.PhoneF.Text))
            {
                str.name = this.NameF.Text;
                str.phoneNum = this.PhoneF.Text;
                if (this.EmailF.Text != null)
                {
                    str.email = this.EmailF.Text;
                }
                str.notEmpty = true;
                str.used = true;
                str.carryOver = false;
               
            } else
            {
                this.NameF.Text = "必须填入姓名，电话和邮箱";
            }

            if (!string.IsNullOrWhiteSpace(this.DescriptionF.Text))
            {
                str.desc = this.DescriptionF.Text;
            }

            if (!string.IsNullOrWhiteSpace(this.RentF.Text) &&
               !string.IsNullOrWhiteSpace(this.AreaF.Text))
            {
                if (decimal.TryParse(this.AreaF.Text, out a)
                   && decimal.TryParse(this.RentF.Text, out a))
                {
                    str.area = Double.Parse(this.AreaF.Text);
                    str.rent = Double.Parse(this.RentF.Text);
                }
            }

            db.Entry(str).State = EntityState.Modified;
            db.SaveChanges();
            refreshstuff();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Storages str = db.Strs.Find(month.Rooms.OrderBy(b => b.Unit).ElementAt(row).Str.OrderBy(b => b.unit).ElementAt(col).Uid);
            decimal a;
            if (!string.IsNullOrWhiteSpace(this.RentF.Text) &&
               !string.IsNullOrWhiteSpace(this.AreaF.Text) &&
               !string.IsNullOrWhiteSpace(this.RentLeftF.Text))
            {
                if (decimal.TryParse(this.AreaF.Text, out a)
                   && decimal.TryParse(this.RentF.Text, out a))
                {
                    str.area = Double.Parse(this.AreaF.Text);
                    str.rent = Double.Parse(this.RentF.Text);
                }
                else
                {
                    this.RentF.Text = "不是数字";
                    this.AreaF.Text = "不是数字";
                }

                if (!string.IsNullOrWhiteSpace(this.DescriptionF.Text))
                {
                    str.desc = this.DescriptionF.Text;
                }

                if (decimal.TryParse(this.RentLeftF.Text, out a))
                {
                    str.sumPaid += Double.Parse(this.RentLeftF.Text);
                    str.cardPaid += Double.Parse(this.RentLeftF.Text);
                }
                else
                {
                    this.RentLeftF.Text = "不是数字";
                }
                db.Entry(str).State = EntityState.Modified;
                db.SaveChanges();
            }
            refreshstuff();
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            Storages str = db.Strs.Find(month.Rooms.OrderBy(b => b.Unit).ElementAt(row).Str.OrderBy(b => b.unit).ElementAt(col).Uid);
            decimal a;
            if (!string.IsNullOrWhiteSpace(this.RentF.Text) &&
               !string.IsNullOrWhiteSpace(this.AreaF.Text) &&
               !string.IsNullOrWhiteSpace(this.RentLeftF.Text))
            {
                if (decimal.TryParse(this.AreaF.Text, out a)
                   && decimal.TryParse(this.RentF.Text, out a))
                {
                    str.area = Double.Parse(this.AreaF.Text);
                    str.rent = Double.Parse(this.RentF.Text);
                }
                else
                {
                    this.RentF.Text = "不是数字";
                    this.AreaF.Text = "不是数字";
                }

                if (!string.IsNullOrWhiteSpace(this.DescriptionF.Text))
                {
                    str.desc = this.DescriptionF.Text;
                }

                if (decimal.TryParse(this.RentLeftF.Text, out a))
                {
                    str.sumPaid += Double.Parse(this.RentLeftF.Text);
                    str.cashPaid += Double.Parse(this.RentLeftF.Text);
                }
                else
                {
                    this.RentLeftF.Text = "不是数字";
                }
                db.Entry(str).State = EntityState.Modified;
                db.SaveChanges();
            }
            refreshstuff();
        }

        private void Cheque_Click(object sender, EventArgs e)
        {
            Storages str = db.Strs.Find(month.Rooms.OrderBy(b => b.Unit).ElementAt(row).Str.OrderBy(b => b.unit).ElementAt(col).Uid);
            decimal a;
            if (!string.IsNullOrWhiteSpace(this.RentF.Text) &&
               !string.IsNullOrWhiteSpace(this.AreaF.Text) &&
               !string.IsNullOrWhiteSpace(this.RentLeftF.Text))
            {
                if (decimal.TryParse(this.AreaF.Text, out a)
                   && decimal.TryParse(this.RentF.Text, out a))
                {
                    str.area = Double.Parse(this.AreaF.Text);
                    str.rent = Double.Parse(this.RentF.Text);
                }
                else
                {
                    this.RentF.Text = "不是数字";
                    this.AreaF.Text = "不是数字";
                }

                if (!string.IsNullOrWhiteSpace(this.DescriptionF.Text))
                {
                    str.desc = this.DescriptionF.Text;
                }

                if (decimal.TryParse(this.RentLeftF.Text, out a))
                {
                    str.sumPaid += Double.Parse(this.RentLeftF.Text);
                    str.chequePaid += Double.Parse(this.RentLeftF.Text);
                }
                else
                {
                    this.RentLeftF.Text = "不是数字";
                }
                db.Entry(str).State = EntityState.Modified;
                db.SaveChanges();
            }
            refreshstuff();
        }

        private void NextMonth_Click(object sender, EventArgs e)
        {
            currentM = currentM.AddMonths(1);
            Month othermonth = db.Months.Find(currentM.ToString("yyyy/MM"));
            if (othermonth == null)
            {
                MessageBox.Show("没有下个月资料",currentM.ToString("yyyy/MM"));
                currentM = currentM.AddMonths(-1);
                if (admin)
                {
                    this.NewMonth.Visible = true;
                }
            }
            else
            {
                month = othermonth;
                this.Lists.Rows.Clear();
                initList();
                this.MonthPicker.Value = currentM;
            }
        }

        private void PreviousMonth_Click(object sender, EventArgs e)
        {
            currentM = currentM.AddMonths(-1);
            Month othermonth = db.Months.Find(currentM.ToString("yyyy/MM"));
            if (othermonth == null)
            {
                MessageBox.Show("没有上个月资料", currentM.ToString("yyyy/MM"));
                currentM = currentM.AddMonths(1);
            }
            else
            {
                month = othermonth;
                this.Lists.Rows.Clear();
                initList();
                this.MonthPicker.Value = currentM;
                this.NewMonth.Visible = false;
            }
        }

        private void NewMonth_Click(object sender, EventArgs e)
        {
            this.Lists.Rows.Clear();
            this.NewMonth.Visible = false;
            Month newMonth = new Month();
            newMonth.Rooms = new List<Room>();
            currentM = currentM.AddMonths(1);
            this.MonthPicker.Value = currentM;
            newMonth.CurrentMonth = currentM.ToString("yyyy/MM");
            month = db.Months.Find(currentM.AddMonths(-1).ToString("yyyy/MM"));
            foreach (Room room in month.Rooms.OrderBy(a => a.Unit))
            {
                Room _room = new Room();
                _room.Uid = Guid.NewGuid();
                _room.Str = new List<Storages>();
                _room.Unit = room.Unit;
                int i = 0;
                foreach (Storages str in room.Str.OrderBy(a => a.unit))
                {
                    Storages _str;
                    if (str.carryOver)
                    {
                        _str = readStorage(str);
                        i++;
                    }
                    else
                    {
                        _str = initStorage(i++);
                    }
                    _room.Str.Add(_str);
                }
                newMonth.Rooms.Add(_room);
            }
            db.Months.Add(newMonth);
            db.SaveChanges();
            month = db.Months.Find(currentM.ToString("yyyy/MM"));
            initList();
        }

        private void used_Click(object sender, EventArgs e)
        {
            Storages str = db.Strs.Find(month.Rooms.OrderBy(a => a.Unit).ElementAt(row).Str.OrderBy(a => a.unit).ElementAt(col).Uid);
            str.notEmpty = true;
            str.used = true;
            str.carryOver = true;
            db.Entry(str).State = EntityState.Modified;
            db.SaveChanges();
            refreshstuff();
        }

        private void unused_Click(object sender, EventArgs e)
        {
            Storages str = db.Strs.Find(month.Rooms.OrderBy(a => a.Unit).ElementAt(row).Str.OrderBy(a => a.unit).ElementAt(col).Uid);
            str.used = false;
            str.notEmpty = true;
            str.carryOver = true;
            str.name = "";
            str.email = "";
            str.phoneNum = "";
            str.area = 0;
            str.rent = 0;
            db.Entry(str).State = EntityState.Modified;
            db.SaveChanges();
            refreshstuff();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            Storages str = db.Strs.Find(month.Rooms.OrderBy(a => a.Unit).ElementAt(row).Str.OrderBy(a => a.unit).ElementAt(col).Uid);
            str.notEmpty = false;
            str.used = false;
            str.carryOver = false;
            str.name = "";
            str.email = "";
            str.phoneNum = "";
            str.area = 0;
            str.rent = 0;
            db.Entry(str).State = EntityState.Modified;
            db.SaveChanges();
            refreshstuff();
        }

        private void permsave_Click(object sender, EventArgs e)
        {
            Storages str = db.Strs.Find(month.Rooms.OrderBy(b => b.Unit).ElementAt(row).Str.OrderBy(b => b.unit).ElementAt(col).Uid);
            decimal a;

            if (!string.IsNullOrWhiteSpace(this.NameF.Text) &&
               !string.IsNullOrWhiteSpace(this.PhoneF.Text))
            {
                str.name = this.NameF.Text;
                str.phoneNum = this.PhoneF.Text;
                if (this.EmailF.Text != null)
                {
                    str.email = this.EmailF.Text;
                }
                str.notEmpty = true;
                str.used = true;
                str.carryOver = true;
            }
            else
            {
                this.NameF.Text = "必须填入姓名，电话";
            }

            if (!string.IsNullOrWhiteSpace(this.DescriptionF.Text))
            {
                str.desc = this.DescriptionF.Text;
            }

            if (!string.IsNullOrWhiteSpace(this.RentF.Text) &&
              !string.IsNullOrWhiteSpace(this.AreaF.Text))
            {
                if (decimal.TryParse(this.AreaF.Text, out a)
                   && decimal.TryParse(this.RentF.Text, out a))
                {
                    str.area = Double.Parse(this.AreaF.Text);
                    str.rent = Double.Parse(this.RentF.Text);
                }
            }

            db.Entry(str).State = EntityState.Modified;
            db.SaveChanges();
            refreshstuff();
        }

        private void Storage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
