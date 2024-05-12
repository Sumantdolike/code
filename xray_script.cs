// X-ray Machine Script

integer isScanning = FALSE;

default
{
    touch_start(integer num_detected)
    {
        if (!isScanning)
        {
            llOwnerSay("Starting X-ray scan...");
            isScanning = TRUE;
            llSetTimerEvent(5.0); // Simulate a 5-second scan
        }
    }

    timer()
    {
        llOwnerSay("X-ray scan complete!");
        // Display the scanned image on a screen
        // Replace the following line with your display script
        llSay(0, "YOUR REPORT HAS BEEN SENT TO DOCTOR ");
        isScanning = FALSE;
        llSetTimerEvent(0.0);
    }
}