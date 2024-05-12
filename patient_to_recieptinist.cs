// Patient Script

string inquiry = " Hello good day , my name is user user I need to see a Dr. smith as today I am booked for operation of my leg .";

default
{
    state_entry()
    {
        llSetText("Touch me to talk to the receptionist", <1,1,1>, 1.0);
    }

    touch_start(integer total_number)
    {
        llSay(0, inquiry);
    }
}