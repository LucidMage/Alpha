function createNPC(%position)
{
   //  Create Player
   %npc = new Sprite(NPC);

   //  Is affected by forces/other objects
   %npc.setBodyType(dynamic);

   //  Centre on screen
   %npc.position = %position;
   %npc.size = "8 8";

   //  On layer closest to camera
   %npc.sceneLayer = 1;

   //  Set animation
   //%npc.image = "ToyAssets:TD_DwarfImage";
   %npc.imageName = "ToyAssets:TD_DwarfWalk";
   //%npc.animation = "ToyAssets:TD_DwarfWalkSouth";
   %npc.animation = %npc.imageName @ "South";

   //  Collision Box, if size not set = size of image
   %npc.createPolygonBoxCollisionShape();
   
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