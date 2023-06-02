using StarWarsAPI.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsAPI
{
    public partial class HomeForm : Form
    {
        //Choose what to search planet, person or species 
        //and takes you to that form
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        //shows planet form
        //and hides the home form
        private void planetBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlanetForm planet = new PlanetForm();
            planet.Show();
        }

        //takes to person form
        //and hides home
        private void personBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonForm person = new PersonForm();
            person.Show();
        }

        //takes to species form
        //and hides home
        private void speciesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpeciesForm species = new SpeciesForm();
            species.Show();
        }

        
    }
}
