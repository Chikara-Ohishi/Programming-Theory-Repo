using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule3 : CapsuleBase // INHERITANCE
{
    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        point = 30;
    }

    public override void CollisionAction() // POLYMORPHISM
    {
        Destroy(gameObject);
    }
}
