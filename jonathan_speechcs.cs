// Doctor Speech Script

integer speechInProgress;
string doctorName = "Dr. jSmith";

// Customize the speech here
string speechText = " as i am going to give you some medicine and some eating plans that you have to follow ,here your discharge letter you can happily go to you residence .  ";

default
{
    state_entry()
    {
        // Initialize variables
        speechInProgress = FALSE;
        llSetText("Touch here to talk jonathan", <1.0, 1.0, 1.0>, 1.0);
    }

    touch_start(integer total_number)
    {
        if (!speechInProgress)
        {
            llSay(0, "Good day, . luckily your operation went well, for few weeks you have to take care of it  go to your home " + doctorName + ".");
            llSleep(2.0); // Wait for 2 seconds before starting the speech
            llSay(0, speechText);
            speechInProgress = TRUE;
            llSetText("Touch me to end the speech", <1.0, 0.0, 0.0>, 1.0); // Change text color to red
        }
        else
        {
            llSay(0, " Thank you, get well soon  .");
            speechInProgress = FALSE;
            llSetText("Touch here to listen dr jonathan", <1.0, 1.0, 1.0>, 1.0); // Change text color back to white
        }
    }
}