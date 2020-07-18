using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameAssets;

namespace InheritanceSimulation
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        //Initialize the character class
        Character objChar = new Character();
        //Initialize the assassin class
        Assassin assassin = new Assassin();
        //Initialize the mercenary class
        Mercenary mercenary = new Mercenary();
        //Initialize the sniper class
        Sniper sniper = new Sniper();
        
        //Function for submit name button
        private void SubmitName_Click(object sender, EventArgs e)
        {
            //set name in character class equal to what the player inputed
            objChar.name = NameBox.Text;
            //Run a check to make sure there is a name
            StoryBox.Text = objChar.CheckName();
        }

        //Function for submit age button
        private void SubmitAge_Click(object sender, EventArgs e)
        {
            //set age in character class equal to what the player inputed
            objChar.age = AgeBox.Text;
            //if the name is not null break into the if statemate
            if (objChar.name != null)
            {
                //Display the greetings method from the character class
                StoryBox.Text = objChar.Greeting();
                //tell the player what to do next
                MessageBox.Show("Please now pick a character class using the drop down.");
            }
            else
                //make sure the player entered an age
                StoryBox.Text = objChar.CheckAge();
        }
        //Function for drop down
        private void CharacterOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set the characterClass equal to the index selected by the player
            objChar.characterClass = CharacterOptions.SelectedIndex;
            //run the decision function
            Decision();
        }
        //This method is used for the decision the player will make
        //Depending on what option they picked in the drop down will depend on what outcome they get
        private void Decision()
        {
            //If the player picks the first item in the drop down
            if (objChar.characterClass == 0)
            {
                //Show the first case in character classes
                StoryBox.Text = assassin.ClassDescription();
            }
            //If the player picks the second item in the drop down
            else if (objChar.characterClass == 1)
            {
                //Show the second case in character classes
                StoryBox.Text = mercenary.ClassDescription();
            }
            //If the player picks the third item in the drop down
            else if (objChar.characterClass == 2)
            {
                //Show the third case in character classes
                StoryBox.Text = sniper.ClassDescription();
            }
            //let the player know they are at the end of the simulation
            MessageBox.Show("Thank you for creating a character this is currently the end of the simulation. You may now close the application.");
        }
    }
}
