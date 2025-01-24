using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : Align
{
    // TODO: override Align's getTargetAngle to face the target instead of matching it's orientation
    public override float getTargetAngle()
    {
        // --- replace me ---
        //float targetAngle = 0f;
        // ------------------
        Vector3 Dir = target.transform.position - character.transform.position;
        float targetAngle = Mathf.Atan2(Dir.x, Dir.z);
        targetAngle *= Mathf.Rad2Deg;

        //target.transform.eulerAngles.y is what aligns target to match its orientation
        return targetAngle;
    }
}
