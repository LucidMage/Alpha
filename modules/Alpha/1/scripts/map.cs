function createMap()
{
	//	Add Tiled Map
    %mapSprite = new TmxMapSprite()
    {
       Map = "ToyAssets:testtown_map";
    };
	
	myScene.add( %mapSprite );
}