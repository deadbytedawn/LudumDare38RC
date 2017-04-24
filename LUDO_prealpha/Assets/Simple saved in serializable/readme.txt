Tutorial on how to use "Simple saved in serializable"


#### In any use ####

Whenever you have a class that use some kind of attribute associated with the system saved it is necessary that you add at the beginning of the class:
[RequireComponent (typeof (SerializableComponent))]
This makes unity add the "Serializable component" Component to your GameObject

It is also necessary to have a "Serializable Manager" in some GameObject as the api is in that class

#### Warning ####

Never use Destroy (Object obj, float time) with a time in an object that you want to be saved. This causes when the game is close unity remove it before it can be saved.

Never use start an object you want to save but not loaded correctly that start to be executed after loading, use awake
void Awake() {}

#### Events ####

Whenever an object of any type is loaded it will call this function
void OnLoad() {}

#### Objects supporting be saved ####

It can be stored any object that is Serializable type
https://msdn.microsoft.com/en-us/library/ms973893.aspx


Supports the saving of the following objects of unity:
Vector2, Vector3, Vector4, Quaternion and Color

######## Static saved (simple) ########

To save a static object, ie it is always instantiated in the same posision.
To save a value must be put:
[Save ("ID")]
public float time;
That will make time is saved and carge, which is in brackets designed that there is a variable ID
in the class to load the system will search for that ID is the same as when loading to be carge the object correspondingly, so that value always has to be UNIQUE.

######## dynamic mode (not so simple) ########

To save a dynamic object that is created when the program is running and then load it the same.
All objects you want to be saved need to have the prefab in a Resources folder and to instantiate use:


	"SerializableManager.PrefabInstantiate (GameObject prefab)" this will returns it the GameObject that instantiate

	
if you want to save some special feature of transform you have to put at the beginning of the class this:
[Save (true, true, true)]
The first true means you'll want to save the posision, the second and the third rotation scale
all fields containing [Save] will be saved and loaded

######## contact ########
for any questions or problems do not hesitate to contact me by my mail: zedgeincorporation@gmail.com