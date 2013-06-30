function createNPC(%position)
{
   //  Create Player
   %npc = new Sprite(NPC);

   //  Is affected by forces/other objects
   %npc.setBodyType(dynamic);

   //  Centre on screen
   %npc.position = %position;
   //%npc.size = 1;

   //  On layer closest to camera
   %npc.sceneLayer = 14;

   //  Set animation
   //%npc.image = "ToyAssets:TD_DwarfImage";
   %npc.imageName = "ToyAssets:TD_DwarfWalk";
   //%npc.animation = "ToyAssets:TD_DwarfWalkSouth";
   %npc.animation = %npc.imageName @ "South";

   //  Collision Circle, if size not set = size of image
   // (radius, [relative xPos, relative yPos])
   %npc.createCircleCollisionShape(0.25, 0, -0.25);
   
   // Stop from rotating on collision
   %npc.setCollisionCallback(true);
   %npc.setFixedAngle(true);
   /*
   //	Move Variables
   %npc.xSpeed = 0;
   %npc.ySpeed = 0;*/

   //  Add to Scene
   myScene.add(%npc);
}

function NPC::onCollision(%this, %sceneobject, %collisiondetails)
{
   %this.setLinearVelocity("0 0");
   %this.setAngularVelocity("0");
}