function createPlayer(%position)
{
   //  Create Player
   %player = new Sprite(Player);

   //  Is affected by forces/other objects
   %player.setBodyType(dynamic);

   //  Centre on screen
   %player.position = %position;
   //%player.size = 1;

   //  On layer closest to camera
   %player.sceneLayer = 14;

   //  Set animation
   //%player.image = "ToyAssets:TD_Wizard_CompSprite";
   %player.imageName = "ToyAssets:TD_Wizard_Walk";
   //%player.animation = "ToyAssets:TD_Wizard_WalkSouth";
   %player.animation = %player.imageName @ "South";

   // Collision Circle, if size not set = size of image
   // (radius, [relative xPos, relative yPos])
   %player.createCircleCollisionShape(0.25, 0, -0.25);
   
   %player.setCollisionCallback(true);
   %player.setFixedAngle(true);
   /*
   //	Move Variables
   %player.xSpeed = 0;
   %player.ySpeed = 0;*/
   %player.speed = 4;

   // Set Behaviours
   %controls = PlayerControlsBehaviour.createInstance();
   %player.addBehavior(%controls);

   // Add to Scene
   myScene.add(%player);
}

function Player::onCollision(%this, %sceneobject, %collisiondetails)
{
   %this.setLinearVelocity("0 0");
   %this.setAngularVelocity("0");
}