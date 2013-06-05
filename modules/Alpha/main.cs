//  Code called when program starts
function Alpha::create( %this )
{
    //  Load GUI Profiles
    exec("./gui/guiProfiles.cs");   //  Need this to create GUI controls
    exec("./scripts/controls.cs");
    exec("./scripts/scenewindow.cs");
    exec("./scripts/scene.cs");
    exec("./scripts/background.cs");
    exec("./scripts/player.cs");

    createSceneWindow();
    createScene();

    mySceneWindow.setScene(myScene);
    createBackground();
    createPlayer();

    //  Debug
    //  Enable visualization for "collision", "position", and "aabb"
    myScene.setDebugOn("collision", "position", "aabb");

    //  Disable visualization for "collision", "position", and "aabb"
    //myScene.setDebugOff("collision", "position", "aabb");

    //  Create Scene Object
    /*
    new SceneObject();
    mySceneObject.createPolygonBoxCollisionShape(10, 500);  //  
    mySceneObject.setBodyType("static");    //  static do not respond to physical forces, e.g. gravity, and will not move when hit by other objects
    //mySceneObject.setBodyType("dynamic");    //  dynamic is responsive to physical forces and bounce off other objects on collision
    myScene.add(mySceneObject);
    */
    
    //  Must be at the end of the function
    new ScriptObject(InputManager);
    InputManager.Init_controls();
    mySceneWindow.addInputListener(InputManager);
    //myScene.removeInputListener(InputManager);    //  Disables inputListener
	echo("Begin");
	echo(InputManager);
}

//  Code called when program ends
function Alpha::destroy( %this )
{
    playercontrols.pop();
    destroySceneWindow();
    InputManager.delete();
}