function createScene()
{
    //  Destroy the scene if it already exists
    if (isObject(myScene))
        destroyScene();

    //  Create Scene
    new Scene(myScene);
	
    %mapSprite = new TmxMapSprite()
    {
       Map = "ToyAssets:testtown_map";
    };
	myScene.add( %mapSprite );
}

function destroyScene()
{
    //  Finish if no scene available
    if ( !isObject(mySceneWindow) )
        return;

    //  Delete Scene
    mySceneWindow.delete();
}