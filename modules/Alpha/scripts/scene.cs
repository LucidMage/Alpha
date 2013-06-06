function createScene()
{
    //  Destroy the scene if it already exists
    if (isObject(myScene))
        destroyScene();

    //  Create Scene
    new Scene(myScene);
}

function destroyScene()
{
    //  Finish if no scene available
    if ( !isObject(mySceneWindow) )
        return;

    //  Delete Scene
    mySceneWindow.delete();
}