// Doctor Speech Script

integer speechInProgress;
string doctorName = "Dr. jSmith";

// Customize the speech here
string speechText = "Good day, . Today, I recieved your request and please visit xray room for digital image for your leg then meet me at operation theatre";

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
            llSay(0, "nice to see youe " + doctorName + ".");
            llSleep(2.0); // Wait for 2 seconds before starting the speech
            llSay(0, speechText);
            speechInProgress = TRUE;
            llSetText("Touch me to end the speech", <1.0, 0.0, 0.0>, 1.0); // Change text color to red
        }
        else
        {
            llSay(0, "Thank you for listening.");
            speechInProgress = FALSE;
            llSetText("Touch me to start the speech", <1.0, 1.0, 1.0>, 1.0); // Change text color back to white
        }
    }
}