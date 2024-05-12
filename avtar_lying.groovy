// Avatar Lying Script

integer isLying = FALSE; // Flag to track if the avatar is lying down

default
{
    state_entry()
    {
        // Set up touch event
        llSetText("Touch me to sit", <1.0, 1.0, 1.0>, 1.0);
    }

    touch_start(integer total_number)
    {
        // Toggle lying state
        isLying = !isLying;

        // If the avatar is lying down, play lying animation
        if (isLying)
        {
            llStartAnimation("lying_animation"); // Replace "lying_animation" with the name of your animation
        }
        else // If the avatar is standing, stop the animation
        {
            llStopAnimation("lying_animation");
        }
    }
}