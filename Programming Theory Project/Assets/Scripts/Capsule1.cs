using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule1 : CapsuleBase // INHERITANCE
{
    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        point = 10;
    }

    public override void CollisionAction() // POLYMORPHISM
    {
        Destroy(gameObject);
    }
}
