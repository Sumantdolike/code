// X-ray Machine Script

integer isXrayOn = FALSE;

default
{
    state_entry()
    {
        llSetText("Touch to toggle X-ray effect", <1,1,1>, 1.0);
    }

    touch_start(integer total_number)
    {
        if (isXrayOn)
        {
            llOwnerSay("X-ray effect turned off.");
            llSetPrimitiveParams([PRIM_FULLBRIGHT, ALL_SIDES, FALSE]);
            isXrayOn = FALSE;
        }
        else
        {
            llOwnerSay("X-ray effect turned on.");
            llSetPrimitiveParams([PRIM_FULLBRIGHT, ALL_SIDES, TRUE]);
            isXrayOn = TRUE;
        }
    }
}