// Receptionist Script

string greeting = "Welcome to the virtual clinic. yeah you are booked for today please take this reciept and go to the dr room which located next to the xray-room?";

default
{
    state_entry()
    {
        llSetText("Touch here for revert", <1,1,1>, 1.0);
    }

    touch_start(integer total_number)
    {
        llSay(0, greeting);
    }
}