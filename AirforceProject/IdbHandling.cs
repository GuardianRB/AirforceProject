using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirforceProject
{
    interface IdbHandling
    {
        bool CheckLogin(string username, string password);

        bool Register(string username, string password, string name, string surname);

        string GetFlightVars(string name);
        //returns "weight,speed"; gets it from the record that has the name of the plane

        void WriteResult(string name, DateTime timeRecorded, int distance, int fuelAvailable, int fuelUsed, int bombsAvailable, int bombsUsed, int numBuildsDestroy, string bestBuilding);
        // Could be used to run a previous experiment? Just add an option at the setup page.

        string GetResults(string name);
        /*
            returns the following string:

        Aircraft used:	name
        Distance:	distance
        Fuel before flight:	fuelAvailable
        Fuel after flight: fuelUsed
        Bombs before flight:	bombsAvailable
        Bombs after flight:		bombsUsed
        Number of buildings destroyed:	numBuildsDestroy
        Best building destroyed:	bestBuilding

            Doesn't have to be exactly like this.
            Just pre-format it so that the returned string can be used as-is for a messagebox.
        */
    }
}
