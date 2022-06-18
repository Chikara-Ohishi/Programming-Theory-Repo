using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleBase : MonoBehaviour
{
    public float point { get; protected set; } // ENCAPSULATION

    private GameManager gameManager;

    // Start is called before the first frame update
    protected void Start()
    {
        GameObject obj = GameObject.FindWithTag("GameController");
        gameManager = obj.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.AddPoint(point);
        CollisionAction();
    }

    public virtual void CollisionAction()
    {

    }
}
