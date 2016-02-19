using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Core;

namespace Client
{
    public partial class Form1 : Form
    {
        MovieCtr mCtr = new MovieCtr();

        public Form1()
        {
            InitializeComponent();
            updTable();
        }

        private void btnGetMovies_Click(object sender, EventArgs e)
        {
            updTable();
        }

        private void btnIdSearch_Click(object sender, EventArgs e)
        {
            Movie m = mCtr.FindMovieById(Convert.ToInt32(txtIdSearch.Text));
            MessageBox.Show(m.Title);
        }

        private void btnCreateMovie_Click(object sender, EventArgs e)
        {
            Movie nm = new Movie();
            nm.Title = txtTitle.Text;
            nm.Description = rtxtDescription.Text;
            nm.Premiere = DateTime.Parse(dtpickerPremiere.Value.ToString("dd-MM-yyyy"));
            mCtr.CreateMovie(nm);
            clearCreateFields();
            updTable();
        }

        private void clearCreateFields()
        {
            txtTitle.Clear();
            rtxtDescription.Clear();
        }

        private void updTable()
        {
            List<Movie> movieList = mCtr.GetMovieList();
            dataGridView1.DataSource = movieList;

            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Titel";
            dataGridView1.Columns[2].HeaderText = "Beskrivelse";
            dataGridView1.Columns[3].HeaderText = "Præmiere dato";

            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
