﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace юрьева
{

    public partial class Form1 : Form
    {

        public static string ConnectionString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Sourse = Db.accdb;");
        public Form1()
        {
            InitializeComponent();

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();// ссылка на регистрацию
            this.Hide();// окно скрыто
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
