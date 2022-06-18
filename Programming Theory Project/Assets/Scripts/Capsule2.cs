using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule2 : CapsuleBase // INHERITANCE
{
    public GameObject particleObject;

    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();
        point = 20 ;
    }

    public override void CollisionAction() // POLYMORPHISM
    {
        Instantiate(particleObject, this.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
