using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string musicName = txtMusicName.Text;
            DateTime createDate = dtgCreateDate.Value;
            string musicLenght =txtLength.Text;
            int msLenght;
            if(musicName !=string.Empty && createDate != null && musicLenght !=string.Empty)
            {
                if (int.TryParse(musicLenght, out msLenght))
                {
                    using (SqlConnection conn=new SqlConnection(@"Data Source=DESKTOP-EH170R6\MSFIDAN;Initial Catalog=25.07.2019;Integrated Security=True"))
                    {
                        string comCommand = String.Format("Insert Into Music Values('{0}','{1}','{2}')", musicName, createDate, msLenght);
                        SqlCommand com = new SqlCommand(comCommand, conn);
                        conn.Open();
                        int result = com.ExecuteNonQuery();
                        if (result >= 1)
                        {
                            MessageBox.Show("Music add Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Sql Error");
                        }
                        }
                    }
                }
            }

        private void TxtMusicName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }          
    }

