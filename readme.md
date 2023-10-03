### Better Triggers
A better way to handle multiple triggers in Unity. Supports both 3D and 2D.

### Overview
Unity doesn't provide a way to identify triggers on a gameobject. This project aims to create a simplified way to allow developers to identify and handle triggers easily. Using an event-based architecture, this project is a wrapper over the existing triggers in Unity that provides helper functions and events to easily use triggers without worrying about the identification.

### Download
You can simply download the `Trigger.cs` script from the `Assets` folder.

>If you want to download a demo scene with everything set up, you can do so by downloading the entirety of the `Assets/` folder and copy the contents into your project.

### How to use?
YouTube Tutorial: -TBA-

1. Download the `Trigger.cs` file and put it anywhere in your project.
2. Move/Attach the Collider component with `isTrigger = true` to an empty child object of the parent.![Step 2](https://i.imgur.com/JyzjZch.png)
3. Attach the new `Trigger` component to the same object the collider component is attached to.![Step 3](https://i.imgur.com/QuvxnXJ.png)
4. Add `using BetterTriggers;` to the script you're handling the trigger in.
5. Create public/serialized private field of type `Trigger` and assign your new child gameobject to it.![Step5.1](https://i.imgur.com/Rudvi1q.png)![Step5.2](https://i.imgur.com/LdTXAJx.png)
6. Register the events in any of the initialization functions (Start, Awake, CustomStartFunction, etc.)![Step 6](https://i.imgur.com/IOxpY59.png)

That's it!

### Events
This script provides three different type of output events to communicate externally:
1. <b>OnTriggerEntered</b> or <b>OnTriggerEntered2D</b>
2. <b>OnTriggerExited</b> or <b>OnTriggerExited2D</b>
3. <b>OnTriggerStayed</b> or <b>OnTriggerStayed2D</b>

All of the events returns a `Collider` (or `Collider2D`) and can be used like the Unity's `OnCollisionEnter(Collider collider)`. 

### Tag Filtering
Built-in support for tag filtering has been added. By default, all tags are allowed. If you want to allow only particular tags, add them to the allowedTags array exposed in the Unity editor.
