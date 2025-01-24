using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Separater : Kinematic
{
    Separate myMoveType;
    Face mySeekRotateType;
    LookWhereGoing myFleeRotateType;

    public bool flee = false;
    //set targets
    public Kinematic[] myTargets = new Kinematic[4];
    // Start is called before the first frame update
    void Start()
    {

        myMoveType = new Separate();
        myMoveType.character = this;
        myMoveType.target = myTarget;
        myMoveType.flee = flee;

        mySeekRotateType = new Face();
        mySeekRotateType.character = this;
        mySeekRotateType.target = myTarget;

        myFleeRotateType = new LookWhereGoing();
        myFleeRotateType.character = this;
        myFleeRotateType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = flee ? myFleeRotateType.getSteering().angular : mySeekRotateType.getSteering().angular;
        base.Update();
    }
}
