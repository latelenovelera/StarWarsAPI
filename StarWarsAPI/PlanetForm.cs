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
    //Inherits from Form
    public partial class PlanetForm : Form
    {
        //Runs PlanetForm
        public PlanetForm()
        {
            InitializeComponent();
        }
       
        private void PlanetForm_Load(object sender, EventArgs e)
        {

        }

        //Checks the id of planet from GetPlanet
        //to display information.
        //If id does not exist message will display 'no data.'
        private async void planetSearchBtn_Click(object sender, EventArgs e)
        {
            Planet planet = await JsonHelper.GetPlanet(planetIdBox.Text);
            if (planet != null)
            {
                planetNameLbl.Text = planet.name;  

                planetRotationPdLbl.Text = planet.rotation_period;

                planetOrbitalPdLbl.Text = planet.orbital_period;

                planetDiameterLbl.Text = planet.diameter;

                planetClimateLbl.Text = planet.climate;

                planetGravityLbl.Text = planet.gravity;

                planetTerrainLbl.Text = planet.terrain;

                planetSurfaceH20Lbl.Text = planet.surface_water;

                planetPopulationLbl.Text = planet.population;
            }
            else
            {
                MessageBox.Show("No data");
            }
        }

        //Goes back to home screen and can choose another form (people or species)
        private void planetHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
    }
}
