function createPlayer()
{
    //  Create Player
    %player = new Sprite(Player);

    //  Is affected by forces/other objects
    %player.setBodyType(dynamic);

    //  Centre on screen
    %player.Position = "0 0";
    %player.Size = "8 8";

    //  On layer closest to camera
    %player.SceneLayer = 1;

    //  Set animation
    %player.Image = "ToyAssets:TD_Wizard_CompSprite";
	%player.Animation = "ToyAssets:TD_Wizard_WalkSouth";

    //  Collision Box, not setting the size = size of image
    %player.createPolygonBoxCollisionShape();
	
	//	Check is Moving
	//%player.isMoving = false;
	
	//	Move Variables
	%player.MoveSpeed = 1;
	%player.MoveTicks = 50;

    //  Add to Scene
    myScene.add(%player);
}

//	User Input
function Player::MoveUp(%this)
{
	echo("Moving Up");
	%this.setPosition( %this.Position.x, %this.Position.y + %this.MoveSpeed );
	%this.Animation = "ToyAssets:TD_Wizard_WalkNorth";
	//%this.isMoving = true;
	%this.MoveSchedule = %this.schedule(%this.MoveTicks, MoveUp);
}
function Player::MoveDown(%this)
{
	echo("Moving Down");
	%this.setPosition( %this.Position.x, %this.Position.y - %this.MoveSpeed );
	%this.Animation = "ToyAssets:TD_Wizard_WalkSouth";
	//%this.isMoving = true;
	%this.MoveSchedule = %this.schedule(%this.MoveTicks, MoveDown);
}
function Player::MoveLeft(%this)
{
	echo("Moving Left");
	%this.setPosition( %this.Position.x - %this.MoveSpeed, %this.Position.y );
	%this.Animation = "ToyAssets:TD_Wizard_WalkWest";
	//%this.isMoving = true;
	%this.MoveSchedule = %this.schedule(%this.MoveTicks, MoveLeft);
}
function Player::MoveRight(%this)
{
	echo("Moving Right");
	%this.setPosition( %this.Position.x + %this.MoveSpeed, %this.Position.y );
	%this.Animation = "ToyAssets:TD_Wizard_WalkWest";
	//%this.isMoving = true;
	%this.MoveSchedule = %this.schedule(%this.MoveTicks, MoveRight);
}

function Player::Stop(%this)  
{
	echo("Stop");
	//%this.isMoving = false;
	cancel(%this.MoveSchedule);
}  