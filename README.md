# A Physics Simulator
3D unity simulation for Coulomb's Law. Also a 3D display of Palpatine.

To run, only build.exe and build_Data are needed. Place them in the same folder and run `build.exe`.

## General scripts
**GlobalVariables.cs**<br>
Contains global variables used for determining sizes of objects in the simulation

**LinearTransformation.cs**<br>
Contains functions for linear transformation (x-axis and y-axis rotation)

**KeyboardController.cs**<br>
Contains functions for controlling the simulation via KeyInput
* *Space* : Pause/resume
* *Alpha1* : Standard x,y,z mode
* *Alpha2* : r,z mode
* *Alpha3* : Manual control mode via arrow keys

**DiskRendererScript.cs**<br>
You don't want to know.

**MerryGoRound.cs**<br>
Script for spinning camera about the set-up.

## Scripts for line rendering `LineRendererDrawers`
**AxisXDrawer.cs, AxisYDrawer.cs, AxisZDrawer.cs**<br>
Draws the lines for the x, y and z axes.

**RingDrawer.cs**<br>
Draws a ring around the location of GameObject `RingPlaceholder`.

### Scripts for drawing vectors
**RadialVectorDrawer.cs**<br>
Draws a line from the ring to the moving ball object.

**ResultantVectorDrawer.cs**<br>
Draws a arrow extending from the moving ball object. Represent resultant electric field vector from a particular point in the ring.

**XComponentDrawer.cs, YComponentDrawer.cs, ZComponentDrawer.cs**<br>
Draws the x, y and z components of the resultant vector.

**RComponentDrawer.cs**<br>
Draws the r component of the resultant vector. Replaces the x and y components.

## Scripts for movement `Movement`
**BitchBall.cs**<br>
Follows ```PointBitchMaster```, which is being controlled via LeapMotion.

**BitchBallSpecial.cs**<br>
Follows along the side `PointBitchMaster`. Used in `PointAxisX`, `PointAxisY` and `PointAxisZ` for placement of axes.

### Palpatine mode
All objects for Palpatine mode are placed in the LightningBolt folder.
