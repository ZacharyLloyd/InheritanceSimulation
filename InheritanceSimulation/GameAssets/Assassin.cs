using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssets
{
    public class Assassin : Character
    {
        //variable for class item unique to each class
        public string classItem;

        //Function to display information about the class
        public string ClassDescription()
        {
            //assigning something to the variable
            classItem = "Silenced FN Five Seven handgun";
            //giving the method text to pass into the story box
            return "You have choosen the Assassin Class and your special weapon is : " + classItem + ". You are excellent at working in the shadows and getting out before your target is even discovered dead.";
        }
    }
}
