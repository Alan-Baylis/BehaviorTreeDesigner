# Included nodes
Here is a complete list of all the included nodes and a short description.

* [Base nodes](#base-nodes)
* [Composites](#composites)
* [Debyg](#debug)
* [Decorators](#decorators)
* [Actions](#actions)
  * [Entries](#entries)
  * [Animation](#animation)

## Base nodes
* Root:
  > The base node of a tree. Must always be included for a tree to be valid.
    Does not return anything since it does not have any inputs.

* Subtree:
  > Runs another tree as a subtree to this tree. Very useful for splitting up
    more complex trees into more managable parts.
    Returns whatever the subtree returns.

## Composites

* Selector:
  > Runs children from left to right until one of them returns SUCCESS.  
    Returns SUCCESS if any child is successful, otherwise FAILURE.

* Sequence:
  > Runs children from left to right until one of them returns FAILURE.  
    Returns SUCCESS if all children is successful, otherwise FAILURE.

* Parallel:
  > Runs all children simultaneously.  
    Returns SUCCESS if all children is successful, otherwise FAILURE.

* Random:
  > Runs one random node and returns it status.

## Debug

* FixedValue:
  > Always returns the selected value.

* Logger:
  > Logs name and result of child node.

* ReadEntry:
  > Logs the content of the selected Blackboard Entry.

## Decorators

* Inverter:
  > Inverts the return value of the child if that value is SUCCESS or FAILURE.

* Repeater:
  > Repeats the child node n times always returning after one tick.  
  	Returns RUNNING during the ticks its repeating, after its done, it returns  
	  last child’s result.

* Wait:
  > Waits a certain number of seconds until the child is allowed to run.  
    Returns RUNNING while waiting.

## Actions

* WalkToTarget:
  > Sets the agents Nav Mesh position to the selected Entry, returns RUNNING while walking,  
    SUCCESS when closer than the specified distance and FAILURE if path could not be found.  
    NOTE that the Entry must be a Transform.

* GetNextWaypoint:
  > Gets a new waypoint from the waypoint system and adds it to the specified Entry.
    Returns SUCCESS when i new waypoint was found, otherwise FAILURE.

### Entries

* SetEntry:
  > Sets an Entry. Class entries can only be set to null.

* HasEntry:
  > Returns SUCCESS if Entry matches the Value, FAILURE if not.  
    Class entries can only match to "not null".

* TagToEntry:
  > Finds the closest Transform with the selected Tag and returns SUCCESS, if no  
    Transform was found it returns FAILURE.

* LayerToEntry:
  > Finds the closest Transform with the selected Layer and returns SUCCESS, if no  
    Transform was found it returns FAILURE.

* TriggerToEntry:
  > When the named GameObject triggers the collider, the parent objects Transform is  
    set as the Entry. NOTE: This requires a child GameObject to be set up, with a  
    trigger Collider and a RigidBody. The child also requires the ColliderHelper script.

### Animation

* SetBool:
  > Sets a bool parameter on the animator.

* SetTrigger:
  > Sets a trigger parameter on the animator.

* SetInteger:
  > Sets a integer parameter on the animator.

* SetFloat:
  > Sets a float parameter on the animator.
