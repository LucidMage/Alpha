function createPlayer(%position)
{
   //  Create Player
   %player = new Sprite(Player);

   //  Is affected by forces/other objects
   %player.setBodyType(dynamic);

   //  Centre on screen
   %player.position = %position;
   %player.size = "8 8";

   //  On layer closest to camera
   %player.sceneLayer = 1;

   //  Set animation
   //%player.image = "ToyAssets:TD_Wizard_CompSprite";
   %player.imageName = "ToyAssets:TD_Wizard_Walk";
   //%player.animation = "ToyAssets:TD_Wizard_WalkSouth";
   %player.animation = %player.imageName @ "South";

   // Collision Box, if size not set = size of image
   %player.createPolygonBoxCollisionShape();
   
   %player.setCollisionCallback(true);
   %player.setFixedAngle(true);
   /*
   //	Move Variables
   %player.xSpeed = 0;
   %player.ySpeed = 0;*/

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