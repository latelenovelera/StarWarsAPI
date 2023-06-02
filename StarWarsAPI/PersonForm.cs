using System;
using StarWarsAPI.Objects;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsAPI
{
    //Inherits from Form
    public partial class PersonForm : Form
    {
        //Runs PersonForm
        public PersonForm()
        {
            InitializeComponent();
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
           
        }

        //Goes back to home screen and can choose another form (planet or species)
        private void personHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        //Checks to make sure person (id) isn't empty otherwise display is 'no data.'
        //Displays information on a person's id then checks a person homeworld
        //to split the url cutting off at index 5.  
        //Then checks the given id to display the name of the planet otherwise there is 'no data.' 
        private async void personSearchBtn_Click(object sender, EventArgs e)
        {
            People personName = await JsonHelper.GetPeople(personIdBox.Text);
            if(personName != null)
            {
                personNameLbl.Text = personName.name;

                personHeightLbl.Text = personName.height;

                personMassLbl.Text = personName.mass;

                personHairColorLbl.Text = personName.hair_color;

                personSkinColorLbl.Text = personName.skin_color;

                personEyeColorLbl.Text = personName.eye_color;

                personBirthYearLbl.Text = personName.birth_year;

                personGenderLbl.Text = personName.gender;

                if (personName.homeworld != null)
                {
                    string[] planetName = personName.homeworld.Split('/');
                    Planet planet_name = await JsonHelper.GetPlanet(planetName[5]);
                    if (planet_name != null)
                    {
                        personHomeworldLbl.Text = planet_name.name;
                    }
                    else
                    {
                        personHomeworldLbl.Text = "No data";
                    }
                }
            }
            else
            {
                MessageBox.Show("No data");
            }
        }

    }
}
