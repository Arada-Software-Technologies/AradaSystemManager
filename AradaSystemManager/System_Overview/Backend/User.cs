using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arada_System_Manager.Overview.Back_End
{
    class User
    {
        //user Cridentials
        string id,username, password;

        //basic info
        string fName, lName, email, phone, title, picture;

        //permissions
        //first index indicates the subsystem
        //second index indicates the permission for an action
        bool[][] per = new bool[6][];

        //first index holdes the decimal value for the permission level of a sub system the user has
        //second index holds the number of actions that a sub system has
        int[,] permissionCodes = new int[6,2];

        //user account info
        DateTime accCreatedOn;
        string accCreatedBy;

        //active or inactive
        bool status;


        //This function is used to parse out the permissions values frmo the data that we get from the database
        //in the database for every subsystem the value stored will be a decimal value that represents the permission level for each of them.
        //that decimal value will be parsed out to a 'true' or 'false' value for each action
        private void permission()
        {
            int permissionCode;
            //loops 6 times for each sub system
            for (int i = 0; i < 6; i++)
            {
                per[i] = new bool[permissionCodes[i, 1]];
                permissionCode = permissionCodes[i, 0];

                for (int j = permissionCodes[i, 1]; j> 0; j--)
                {
                    if (permissionCodes[i, 0] < (2 ^ (j - 1)))
                    {
                        per[i][j] = false;
                    }
                    else
                    {
                        if(permissionCode % 2 == 0)
                        {
                            per[i][j] = false;
                        }
                        else
                        {
                            per[i][j] = true;
                        }
                        permissionCode /= 2;
                    }
                }
            }
        }

        public void login()
        {




            username = "";
            password = "";
        }

        //usses the id to load the data about the user from the database 
        public void getAcc()
        {

        }

        public void createAcc()
        {
            //System Generates username and password!!

        }

        public void editAcc()
        {

        }

        public void deactivateAcc()
        {

        }

        public void activateAcc()
        {

        }




    }
}
