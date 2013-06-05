function InputManager::Init_controls(%this)
{
    //  Create ActionMap
    new ActionMap(playercontrols);

    //  Use arrow keys to move Player
    //  Release key to stop moving
    playercontrols.bindCmd(keyboard, "up", "Player.MoveUp();", "Player.Stop();");
    playercontrols.bindCmd(keyboard, "down", "Player.MoveDown();", "Player.Stop();");
    playercontrols.bindCmd(keyboard, "left", "Player.MoveLeft();", "Player.Stop();");
    playercontrols.bindCmd(keyboard, "right", "Player.MoveRight();", "Player.Stop();");

    //  Push ActionMap to top of stack
    playercontrols.push();
}