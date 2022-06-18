using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;
    [SerializeField] private float thrust;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move() // ABSTRACTION
    {
        float right = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * right * thrust * Time.deltaTime);
        float forward = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward * forward * thrust * Time.deltaTime);
    }
}
