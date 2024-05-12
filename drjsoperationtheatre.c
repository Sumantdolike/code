// Doctor Speech Script

integer speechInProgress;
string doctorName = "Dr. jSmith";

// Customize the speech here
string speechText = "Good day, that means it needs operation at the moment otherwise it become more worsen,Fortunately, you have normal blood pressure and sugar level .  ";

default
{
    state_entry()
    {
        // Initialize variables
        speechInProgress = FALSE;
        llSetText("Touch here to talk js smith", <1.0, 1.0, 1.0>, 1.0);
    }

    touch_start(integer total_number)
    {
        if (!speechInProgress)
        {
            llSay(0, "Good day, . Today, I recieved your xray report , you have some knee bone fracture in there " + doctorName + ".");
            llSleep(2.0); // Wait for 2 seconds before starting the speech
            llSay(0, speechText);
            speechInProgress = TRUE;
            llSetText("Touch me to end the speech", <1.0, 0.0, 0.0>, 1.0); // Change text color to red
        }
        else
        {
            llSay(0, "Please sit on the bed and after two days go can go to your home before meeting Dr Jonathan, who sitting in front of me     , Thank you .");
            speechInProgress = FALSE;
            llSetText("Touch here to listen dr js", <1.0, 1.0, 1.0>, 1.0); // Change text color back to white
        }
    }
}