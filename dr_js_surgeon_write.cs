// Example of osDrawText placing text in the center
default
{
    state_entry()
    {
        string CommandList = ""; // Storage for our drawing commands
        integer textureWidth = 256; // Width of the texture
        integer textureHeight = 256; // Height of the texture
        integer fontSize = 20; // Font size of the text

        // Calculate the width of the text
        integer textWidth = llStringLength("XRAY") * fontSize;

        // Calculate the position to place the text in the center
        integer xPos = (textureWidth - textWidth) / 2; // X position
        integer yPos = (textureHeight - fontSize) / 2; // Y position

        // Move the pen to the calculated position
        CommandList = osMovePen(CommandList, xPos, yPos);

        // Draw the text
        CommandList = osDrawText(CommandList, "Dr js surgeon");

        // Set the dynamic texture data
        osSetDynamicTextureData("", "vector", CommandList, "width:" + (string)textureWidth + ",height:" + (string)textureHeight, 0);
    }
}