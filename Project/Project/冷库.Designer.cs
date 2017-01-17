using System;
using System.Windows.Forms;
namespace Project
{
    partial class Storage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private double x = Screen.PrimaryScreen.Bounds.Width * 0.9;
        private double y = Screen.PrimaryScreen.Bounds.Height * 0.8;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameF = new System.Windows.Forms.TextBox();
            this.PhoneF = new System.Windows.Forms.TextBox();
            this.AreaF = new System.Windows.Forms.TextBox();
            this.EmailF = new System.Windows.Forms.TextBox();
            this.RentF = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Empty = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.RentDue = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.RentLeftF = new System.Windows.Forms.TextBox();
            this.DescriptionF = new System.Windows.Forms.TextBox();
            this.Cash = new System.Windows.Forms.Button();
            this.MonthPicker = new System.Windows.Forms.DateTimePicker();
            this.Cheque = new System.Windows.Forms.Button();
            this.Card = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Label();
            this.Rent2 = new System.Windows.Forms.Label();
            this.Card2 = new System.Windows.Forms.Label();
            this.Cash2 = new System.Windows.Forms.Label();
            this.Cheque2 = new System.Windows.Forms.Label();
            this.Out = new System.Windows.Forms.Button();
            this.In = new System.Windows.Forms.Button();
            this.PreviousMonth = new System.Windows.Forms.Button();
            this.NextMonth = new System.Windows.Forms.Button();
            this.Lists = new System.Windows.Forms.DataGridView();
            this.NewMonth = new System.Windows.Forms.Button();
            this.unused = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.used = new System.Windows.Forms.Button();
            this.permsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Empty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lists)).BeginInit();
            this.SuspendLayout();
            // 
            // NameF
            // 
            this.NameF.Enabled = false;
            this.NameF.Location = new System.Drawing.Point(135, 537);
            this.NameF.Name = "NameF";
            this.NameF.Size = new System.Drawing.Size(130, 20);
            this.NameF.TabIndex = 4;
            // 
            // PhoneF
            // 
            this.PhoneF.Enabled = false;
            this.PhoneF.Location = new System.Drawing.Point(135, 563);
            this.PhoneF.Name = "PhoneF";
            this.PhoneF.Size = new System.Drawing.Size(130, 20);
            this.PhoneF.TabIndex = 5;
            // 
            // AreaF
            // 
            this.AreaF.Enabled = false;
            this.AreaF.Location = new System.Drawing.Point(417, 488);
            this.AreaF.Name = "AreaF";
            this.AreaF.Size = new System.Drawing.Size(215, 20);
            this.AreaF.TabIndex = 9;
            // 
            // EmailF
            // 
            this.EmailF.Enabled = false;
            this.EmailF.Location = new System.Drawing.Point(135, 589);
            this.EmailF.Name = "EmailF";
            this.EmailF.Size = new System.Drawing.Size(130, 20);
            this.EmailF.TabIndex = 6;
            // 
            // RentF
            // 
            this.RentF.Enabled = false;
            this.RentF.Location = new System.Drawing.Point(417, 517);
            this.RentF.Name = "RentF";
            this.RentF.Size = new System.Drawing.Size(215, 20);
            this.RentF.TabIndex = 10;
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.Location = new System.Drawing.Point(12, 544);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(50, 18);
            this.ClientName.TabIndex = 6;
            this.ClientName.Text = "姓名： ";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(12, 570);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(80, 18);
            this.Phone.TabIndex = 7;
            this.Phone.Text = "手机号码： ";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(12, 596);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(80, 18);
            this.Email.TabIndex = 8;
            this.Email.Text = "邮箱地址： ";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(305, 495);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(50, 18);
            this.Area.TabIndex = 9;
            this.Area.Text = "面积： ";
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.Location = new System.Drawing.Point(305, 520);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(50, 18);
            this.Rent.TabIndex = 10;
            this.Rent.Text = "应收： ";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(305, 603);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(50, 18);
            this.Status.TabIndex = 11;
            this.Status.Text = "状态： ";
            // 
            // Empty
            // 
            this.Empty.Location = new System.Drawing.Point(417, 606);
            this.Empty.Name = "Empty";
            this.Empty.Size = new System.Drawing.Size(215, 21);
            this.Empty.TabIndex = 12;
            this.Empty.TabStop = false;
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(12, 638);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 26);
            this.Save.TabIndex = 7;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // RentDue
            // 
            this.RentDue.AutoSize = true;
            this.RentDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDue.Location = new System.Drawing.Point(305, 574);
            this.RentDue.Name = "RentDue";
            this.RentDue.Size = new System.Drawing.Size(50, 18);
            this.RentDue.TabIndex = 20;
            this.RentDue.Text = "已收： ";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(305, 547);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(50, 18);
            this.Description.TabIndex = 19;
            this.Description.Text = "备注： ";
            // 
            // RentLeftF
            // 
            this.RentLeftF.Location = new System.Drawing.Point(417, 575);
            this.RentLeftF.Name = "RentLeftF";
            this.RentLeftF.Size = new System.Drawing.Size(215, 20);
            this.RentLeftF.TabIndex = 12;
            // 
            // DescriptionF
            // 
            this.DescriptionF.Location = new System.Drawing.Point(417, 545);
            this.DescriptionF.Name = "DescriptionF";
            this.DescriptionF.Size = new System.Drawing.Size(215, 20);
            this.DescriptionF.TabIndex = 11;
            // 
            // Cash
            // 
            this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.Location = new System.Drawing.Point(411, 643);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(108, 26);
            this.Cash.TabIndex = 14;
            this.Cash.Text = "转入现金";
            this.Cash.UseVisualStyleBackColor = true;
            this.Cash.Click += new System.EventHandler(this.Cash_Click);
            // 
            // MonthPicker
            // 
            this.MonthPicker.CustomFormat = "MM/yyyy";
            this.MonthPicker.Enabled = false;
            this.MonthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthPicker.Location = new System.Drawing.Point(703, 486);
            this.MonthPicker.Name = "MonthPicker";
            this.MonthPicker.Size = new System.Drawing.Size(205, 20);
            this.MonthPicker.TabIndex = 17;
            this.MonthPicker.Value = new System.DateTime(2016, 4, 15, 0, 0, 0, 0);
            // 
            // Cheque
            // 
            this.Cheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cheque.Location = new System.Drawing.Point(542, 643);
            this.Cheque.Name = "Cheque";
            this.Cheque.Size = new System.Drawing.Size(108, 26);
            this.Cheque.TabIndex = 15;
            this.Cheque.Text = "转入支票";
            this.Cheque.UseVisualStyleBackColor = true;
            this.Cheque.Click += new System.EventHandler(this.Cheque_Click);
            // 
            // Card
            // 
            this.Card.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.Location = new System.Drawing.Point(299, 643);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(89, 26);
            this.Card.TabIndex = 13;
            this.Card.Text = "转入卡";
            this.Card.UseVisualStyleBackColor = true;
            this.Card.Click += new System.EventHandler(this.Card_Click);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(700, 547);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(76, 18);
            this.Sum.TabIndex = 51;
            this.Sum.Text = "当月已收：";
            // 
            // Rent2
            // 
            this.Rent2.AutoSize = true;
            this.Rent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent2.Location = new System.Drawing.Point(700, 519);
            this.Rent2.Name = "Rent2";
            this.Rent2.Size = new System.Drawing.Size(76, 18);
            this.Rent2.TabIndex = 52;
            this.Rent2.Text = "当月应收：";
            // 
            // Card2
            // 
            this.Card2.AutoSize = true;
            this.Card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card2.Location = new System.Drawing.Point(703, 582);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(35, 18);
            this.Card2.TabIndex = 53;
            this.Card2.Text = "卡： ";
            // 
            // Cash2
            // 
            this.Cash2.AutoSize = true;
            this.Cash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash2.Location = new System.Drawing.Point(811, 582);
            this.Cash2.Name = "Cash2";
            this.Cash2.Size = new System.Drawing.Size(50, 18);
            this.Cash2.TabIndex = 54;
            this.Cash2.Text = "现金： ";
            // 
            // Cheque2
            // 
            this.Cheque2.AutoSize = true;
            this.Cheque2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cheque2.Location = new System.Drawing.Point(942, 585);
            this.Cheque2.Name = "Cheque2";
            this.Cheque2.Size = new System.Drawing.Size(50, 18);
            this.Cheque2.TabIndex = 55;
            this.Cheque2.Text = "支票： ";
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(0, 0);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(75, 23);
            this.Out.TabIndex = 68;
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(0, 0);
            this.In.Name = "In";
            this.In.Size = new System.Drawing.Size(75, 23);
            this.In.TabIndex = 67;
            // 
            // PreviousMonth
            // 
            this.PreviousMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousMonth.Location = new System.Drawing.Point(871, 624);
            this.PreviousMonth.Name = "PreviousMonth";
            this.PreviousMonth.Size = new System.Drawing.Size(133, 26);
            this.PreviousMonth.TabIndex = 17;
            this.PreviousMonth.Text = "上月";
            this.PreviousMonth.UseVisualStyleBackColor = true;
            this.PreviousMonth.Click += new System.EventHandler(this.PreviousMonth_Click);
            // 
            // NextMonth
            // 
            this.NextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextMonth.Location = new System.Drawing.Point(690, 622);
            this.NextMonth.Name = "NextMonth";
            this.NextMonth.Size = new System.Drawing.Size(133, 26);
            this.NextMonth.TabIndex = 16;
            this.NextMonth.Text = "下月";
            this.NextMonth.UseVisualStyleBackColor = true;
            this.NextMonth.Click += new System.EventHandler(this.NextMonth_Click);
            // 
            // Lists
            // 
            this.Lists.AllowUserToAddRows = false;
            this.Lists.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lists.GridColor = System.Drawing.SystemColors.Control;
            this.Lists.Location = new System.Drawing.Point(0, 0);
            this.Lists.Name = "Lists";
            this.Lists.Size = new System.Drawing.Size(1066, 480);
            this.Lists.TabIndex = 64;
            this.Lists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lists_CellContentClick);
            // 
            // NewMonth
            // 
            this.NewMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMonth.Location = new System.Drawing.Point(690, 651);
            this.NewMonth.Name = "NewMonth";
            this.NewMonth.Size = new System.Drawing.Size(133, 26);
            this.NewMonth.TabIndex = 18;
            this.NewMonth.Text = "转到下月";
            this.NewMonth.UseVisualStyleBackColor = true;
            this.NewMonth.Visible = false;
            this.NewMonth.Click += new System.EventHandler(this.NewMonth_Click);
            // 
            // unused
            // 
            this.unused.Enabled = false;
            this.unused.Location = new System.Drawing.Point(97, 493);
            this.unused.Name = "unused";
            this.unused.Size = new System.Drawing.Size(77, 28);
            this.unused.TabIndex = 2;
            this.unused.Text = "未使用";
            this.unused.UseVisualStyleBackColor = true;
            this.unused.Click += new System.EventHandler(this.unused_Click);
            // 
            // hide
            // 
            this.hide.Enabled = false;
            this.hide.Location = new System.Drawing.Point(14, 493);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(77, 28);
            this.hide.TabIndex = 1;
            this.hide.Text = "隐藏";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // used
            // 
            this.used.Enabled = false;
            this.used.Location = new System.Drawing.Point(180, 491);
            this.used.Name = "used";
            this.used.Size = new System.Drawing.Size(77, 28);
            this.used.TabIndex = 3;
            this.used.Text = "已使用";
            this.used.UseVisualStyleBackColor = true;
            this.used.Click += new System.EventHandler(this.used_Click);
            // 
            // permsave
            // 
            this.permsave.Enabled = false;
            this.permsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permsave.Location = new System.Drawing.Point(135, 638);
            this.permsave.Name = "permsave";
            this.permsave.Size = new System.Drawing.Size(130, 26);
            this.permsave.TabIndex = 8;
            this.permsave.Text = "永久保存";
            this.permsave.UseVisualStyleBackColor = true;
            this.permsave.Click += new System.EventHandler(this.permsave_Click);
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1073, 681);
            this.Controls.Add(this.permsave);
            this.Controls.Add(this.used);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.unused);
            this.Controls.Add(this.NewMonth);
            this.Controls.Add(this.Lists);
            this.Controls.Add(this.NextMonth);
            this.Controls.Add(this.PreviousMonth);
            this.Controls.Add(this.In);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Cheque2);
            this.Controls.Add(this.Cash2);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Rent2);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.Cheque);
            this.Controls.Add(this.MonthPicker);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.RentDue);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.RentLeftF);
            this.Controls.Add(this.DescriptionF);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Empty);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.RentF);
            this.Controls.Add(this.EmailF);
            this.Controls.Add(this.AreaF);
            this.Controls.Add(this.PhoneF);
            this.Controls.Add(this.NameF);
            this.Name = "Storage";
            this.Text = "冷库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Storage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Empty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameF;
        private System.Windows.Forms.TextBox PhoneF;
        private System.Windows.Forms.TextBox AreaF;
        private System.Windows.Forms.TextBox EmailF;
        private System.Windows.Forms.TextBox RentF;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label Rent;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.PictureBox Empty;
        private Button Save;
        private Label RentDue;
        private Label Description;
        private TextBox RentLeftF;
        private TextBox DescriptionF;
        private Button Cash;
        private DateTimePicker MonthPicker;
        private Button Cheque;
        private Button Card;
        private Label Sum;
        private Label Rent2;
        private Label Card2;
        private Label Cash2;
        private Label Cheque2;
        private Button Out;
        private Button In;
        private Button PreviousMonth;
        private Button NextMonth;
        private DataGridView Lists;
        private Button NewMonth;
        private Button unused;
        private Button hide;
        private Button used;
        private Button permsave;
    }
}

