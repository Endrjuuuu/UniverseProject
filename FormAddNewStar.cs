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
    public partial class FormAddNewStar : Form
    {
        Universe universe = Universe.UniverseInstance;

        public FormAddNewStar()
        {
            InitializeComponent();
            //comboBox_galaxyOfStar.DataSource = universe.GalaxyDict.Keys.ToString();
            comboBox_galaxyOfStar.DataSource = new BindingSource(universe.GalaxyDict, null);
            comboBox_galaxyOfStar.DisplayMember = "Key";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string starName = textBox_nameOfStar.Text;
            bool isyearsOfStar = int.TryParse(textBox_yearsOfStar.Text, out int yearsOfStar);
            string nameOfGalaxy = comboBox_galaxyOfStar.Text;
            if (universe.GalaxyDict.ContainsKey(starName))
            {
                MessageBox.Show("Istnieje juz gwiazda o tej nazwie");
            }
            else
            {
                Galaxy galaxy = universe.GalaxyDict[nameOfGalaxy];
                galaxy.AddStar(starName, yearsOfStar);
            }
        }
    }
}
