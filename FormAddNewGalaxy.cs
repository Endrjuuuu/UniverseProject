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
    public partial class FormAddNewGalaxy : Form
    {
        Universe universe = Universe.UniverseInstance;
        public FormAddNewGalaxy()
        {
            InitializeComponent();
            comboBox_galaxyType.DataSource = Enum.GetValues(typeof(GalaxyType));

        }

        private void button_addNewGalaxy_Click(object sender, EventArgs e)
        {
            string glaxyName = textBox_newGalaxyName.Text;
            bool isNumberOfStars = int.TryParse(textBox_numberOfStars.Text, out int numerOfStars);
            if (universe.GalaxyDict.ContainsKey(glaxyName))
            {
                MessageBox.Show("Istnieje juz galaktyka o tej nazwie");
            }
            else
            {
                universe.GalaxyDict.Add(glaxyName, new Galaxy(glaxyName, (GalaxyType)comboBox_galaxyType.SelectedIndex, numerOfStars));
            }
        }
    }
}
