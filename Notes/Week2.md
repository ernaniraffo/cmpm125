# Week 2

## Game Engine Physics

- Newtonian physics
- RigidBody physics
- Soft Body physics
    - Deformable solid objects, i.e. cloth
    - High intensity for accurate simulation, use sparingly or animate when possible
    - Useful for:
        - cloth
        - ropes
        - high detail character simulation
        - soft vegetation
- Joints
    - connecting points on multiple physics objects, usually rigid bodies
- Rag doll
    - complex rigidbody/soft body with joints usually simulating an organic body
- Fluid physics
    - complex calculations of fluids to represent animation of liquids in games
    - Navier-Stokes & Lattice Boltzmann algorithms are common but simplified
- `FixedUpdate()`
    - Useful for applying Physics changes

## Colliders

- Sphere, Box, Capsule, and Mesh
- Radius/Size & Center allow you to change size and center of the collider, regardless of mesh shape
- Physics Materials
    - allows you to set the friction

## Rigibodies

- Mass
- Drag & Angular Drag
    - Decay rate of force and torque on the object
    - How long it takes to slow down
- Center of Mass
    - change center of mass location
- Use Gravity
- Collision Detection
    - level of detail on determining collision
    - higher calculation cost options for faster/smaller objects (bullets)
- Constraints
    - prevent a rigidbody from moving in certain vectors of position or rotation
- Kinematic Physics
    - `Rigidbody.isKinematic`
    - uninterrupted physics object, one that can apply physics but can’t receive
    - (idea for game: platforms that react to physics [weight, objects, etc.])
- Rigidbody force and torque
    - Force is motion in space
        - speed of motion in Unity is called velocity, measured in units/second
    - Torque is rotation in space
        - speed of motion in Unity is called angular velocity
        - radians/second
    - One can create the other
- Force methods

```csharp
rb.AddForce(Vector3 force, ForceMode mode = ForceMode.Force);
rb.AddForce(Vector3.up); // will send something upwards regardless of its rotation
rb.AddRelativeForce(Vector3 force, ForceMode mode = ForceMode.Force);
rb.AddRelativeForce(Vector3.forward);
```

- Torque Methods

```csharp
rb.AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force);
rb.AddRelativeTorque(..)
```

- AddExplosionForce
    - amount of force based on point of explosion and power
    - `Physics.OverlapSphere`

### Trigger Volumes

- colliders that don’t actually collide
- rigid bodies will pass right through them
- something entered a volume
- `OnTrigger____`
    - goes on the object with the `isTrigger` collider
    - provides you with the collider that entered the trigger volume
    - `OnTriggerEnter`
    - `OnTriggerStay` (probably will not use this often)
    - `OnTriggerExit` (sometimes is never called [trap is deleted])
    
    ```csharp
    private void OnTriggerEnter(Collider other)
    {
    	other.gameObject.GetComponent<BasicCharacter>().ChangeHealth(-5);
    	Debug.Log("Entered: " + other.gameObject.name);
    }
    ```
    
    - Quick note: `[SerializedField]` shows private variables in the inspector
- `OnCollision____`
    - Enter, Stay, Exit
    - `OnTrigger___` is used more

### Tags and Layers

- Tags are case sensitive
- One tag per `GameObject`
- Static methods
    - `GameObject.FindWithTag()`
    - `GameObject.FindGameObjectsWithTag()`

### Character Controller

- Rigidbody + Collider
- Traditional first player movement, no force
- Detect collisions based on `CharacterController.OnControllerColliderHit`
    - `isGrounded`
- Recommend trying making your own character movement

### Raycast

- one endpoint, one direction going on forever
- projection of a ray (endpoint & line) and detecting every object that is within the ray
- starting point (`Vector3`) and a direction (`Vector3`)

### Unity Raycast

```csharp
bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
```

- must define the variable first for `RaycastHit`
- `out` - used to let C# know to assign the results to the variable hit
- `PhysicsRaycastAll` to get an array of `RaycastHit[]` results for everything it collided with
- `Debug.DrawRay`
- Ray pointing to the bottom - what is the player standing on?