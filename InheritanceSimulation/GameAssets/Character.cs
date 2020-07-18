using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameAssets
{
    public class Character
    {
        //variable for name of player
        public string name;
        //variable for age of player
        public string age;
        //variable for character class they will pick in the drop down
        public int characterClass;

        //Gretting method used when player give name and age
        public string Greeting()
        {
            return "Hello, " + name + " your character's age is " + age;
        }

        //Check created to make sure the player enters a name
        public string CheckName()
        {
            if (name == null)
            {
                return "You need to enter a name into the text box.";
            }
            return name;
        }
        
        //Check created to make sure the player enters an age
        public string CheckAge()
        {
            if(age == null)
            {
                return "You need to enter an age into the text box.";
            }
            return age;
        }
    }
}
