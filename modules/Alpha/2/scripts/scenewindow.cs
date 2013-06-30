function createSceneWindow()
{
    //  Check mySceneWindow exists
    if ( !isObject(mySceneWindow) )
    {
        //  Create Scene Window
        new SceneWindow(mySceneWindow);

        //  Set Gui Profile
        mySceneWindow.Profile = GuiDefaultProfile;  //  GuiDefaultProfile is used by default

        //  Place the sceneWindow on the Canvas
        Canvas.setContent(mySceneWindow);   //  mySceneWindow fills entire canvas
    }

    //  These are the default values
    mySceneWindow.setCameraPosition(0, 0);
    mySceneWindow.setCameraSize(100, 75);
    mySceneWindow.setCameraZoom(5);
    mySceneWindow.setCameraAngle(0);
}

function destroySceneWindow()
{
    //  Finish if no window available
    if ( !isObject(mySceneWindow) )
        return;

    //  Delete window
    mySceneWindow.delete();
}

function centreOnSprite(%sprite)
{
   mySceneWindow.setCameraPosition(%sprite.position);
   
   // Schedule to centre camera on player sprite
   mySceneWindow.PositionSchedule = schedule(1, 0, centreOnSprite, %sprite);
}