function createBackground()
{
    //  Create "Sprite"
    %background = new Sprite(); //  %value = local variable
    //new Sprite(Background);   //  non-local alternative

    //  Set as static
    %background.setBodyType(static);

    //  Centre to 0,0 = the centre of the scene
    %background.Position = "0 0";

    //  Set to the same size as the camera (scenewindow.cs)
    %background.Size = "100 75";

    //  Set to the backmost layer (0-31)
    %background.SceneLayer = 31;

    //  Set image
    %background.Image = "ToyAssets:treeBackground1";

    //  Create border collisions
    %background.createEdgeCollisionShape(-50, -34.5, -50, 34.5);
    %background.createEdgeCollisionShape(50, -34.5, 50, 34.5);
    %background.createEdgeCollisionShape(-50, 34.5, 50, 34.5);
    %background.createEdgeCollisionShape(-50, -34.5, 50, -34.5);

    //  Add to Scene
    myScene.add(%background);
}