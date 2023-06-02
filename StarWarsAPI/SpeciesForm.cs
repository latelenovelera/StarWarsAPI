using StarWarsAPI.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StarWarsAPI
{
    //Inherits from Form
    public partial class SpeciesForm : Form
    {
        //Runs the SpeciesForm
        public SpeciesForm()
        {
            InitializeComponent();
        }

        //Loops through all_species from AllSpecies list results
        //to display all attributes from the Species class
        //and gets all the information from Star Wars Api. 
        //If any attribute(s) are missing 'n/a' will be the response.
        //Also, goes through url of homeworld where it cuts off the id of people homeworld
        //and replaces it by naming it.
        private async void Display()
        {
            AllSpecies all_species = await JsonHelper.GetAllSpecies();
            foreach (var species in all_species.results)
            {
                string plntName = "n/a";
                if (species.homeworld != null)
                {
                    string[] planetName = species.homeworld.Split('/');
                    Planet planet_name = await JsonHelper.GetPlanet(planetName[5]);
                    if (planet_name != null)
                    {
                        plntName  = planet_name.name;

                    }
                    else
                    {
                        plntName = "No data";

                    }

                }

                allSpeciesBox.Items.Add("Name: " + species.name);

                allSpeciesBox.Items.Add("Classification: " + species.classification);

                allSpeciesBox.Items.Add("Designation: " + species.designation);

                allSpeciesBox.Items.Add("Average height: " + species.average_height);

                allSpeciesBox.Items.Add("Skin colors: " + species.skin_colors );

                allSpeciesBox.Items.Add("Hair colors: " + species.hair_colors);

                allSpeciesBox.Items.Add("Eye colors: " + species.eye_colors);

                allSpeciesBox.Items.Add("Average lifespan: " + species.average_lifespan);

                allSpeciesBox.Items.Add("Homeworld: " + plntName);

                allSpeciesBox.Items.Add("Language: " + species.language);

            }
        }



        //Call of Display function
        private void SpeciesForm_Load(object sender, EventArgs e)
        {
            Display();
        }

        //Goes back to home screen and can choose another form (planet or people)
        private void speciesHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void allSpeciesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
