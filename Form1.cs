using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniverseProject.Models;

namespace UniverseProject
{
    public partial class Form1 : Form
    {
        Universe universe = Universe.UniverseInstance;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = universe.GalaxyDict.Values.ToList();
        }

        private void button_showAddGalaxyForm_Click(object sender, EventArgs e)
        {
            FormAddNewGalaxy formAddNewGalaxy = new FormAddNewGalaxy();
            formAddNewGalaxy.Show();
        }

        private void button_showAddStarForm_Click(object sender, EventArgs e)
        {
            FormAddNewStar formAddNewStar = new FormAddNewStar();
            formAddNewStar.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = universe.GalaxyDict.Values.ToList();
        }

        private void button_sortNumberOfStars_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var data = universe.GalaxyDict.Values.GroupBy(key => key.NumberOfStars);
            dataGridView1.DataSource = data.ToList();
        }
    }
}