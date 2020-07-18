using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssets
{
    public class Mercenary : Character
    {
        //variable for class item unique to each class
        public string classItem;

        //Function to display information about the class
        public string ClassDescription()
        {
            //assigning something to the variable
            classItem = "Fully decked out HK 416";
            //giving the method text to pass into the story box
            return "You have choosen the Mercenary Class and your special weapon is : " + classItem + ". You are excellent at getting out of situations most men would fear, there is nothing that will stop you from accomplishing your mission.";
        }
    }
}
