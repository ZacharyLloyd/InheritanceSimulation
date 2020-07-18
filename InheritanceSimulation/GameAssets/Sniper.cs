using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAssets
{
    public class Sniper : Character
    {
        //variable for class item unique to each class
        public string classItem;

        //Function to display information about the class
        public string ClassDescription()
        {
            //assigning something to the variable
            classItem = "FN Herstal Ballista silenced long range rifle";
            //giving the method text to pass into the story box
            return "You have choosen the Sniper Class and your special weapon is : " + classItem + ". You are excellent at elimating targets from ranges they don't even hear you fire a bullet from, once you have a target in your sights they are as good as gone.";
        }
    }
}
