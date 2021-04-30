using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_One_Assign
{
   public class rulesClass
    {
        Random rd = new Random();

        //this method is used to check the trigger 
        public int genTrigger() {
            return rd.Next(1, 4);
        }

        public int genNewTrigger()
        {
            return rd.Next(1, 3);
        }


        //here we need to check the working stage 
        public Boolean chkStatus(int trigger,int chance) {
            if (trigger == chance)
            {
                return true;
            }
            else {
                return false;
            }
        }

        //here we need to check the working stage 
        public Boolean chkNewStatus(int trigger, int chance)
        {
            if (trigger == chance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
