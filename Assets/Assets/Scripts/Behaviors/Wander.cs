using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : Separate
{
    
    public float wanderOffset;
    public float wanderRadius;

    public Vector3 range;
    public float wanderRate;
    public Vector3 wanderOrient;
    public float maxAcceleration;


    protected override Vector3 getTargetPosition()
    {
        range = Random.insideUnitCircle.normalized * wanderRate;
        wanderOrient = new Vector3(range.x, 0, range.z) + target.transform.position;
        
        //idk what millington was trying to do here i couldnt get this to work properly
        //combines target orient
        //target.transform.position = (wanderOrient * wanderRadius) + wanderOffset;

        //center of circle
       // target.transform.position = character.transform.position + wanderOffset * character.transform.position;
        //target location
       // target.transform.position += wanderRadius * target.transform.position;

        return wanderOrient;
    }
}
