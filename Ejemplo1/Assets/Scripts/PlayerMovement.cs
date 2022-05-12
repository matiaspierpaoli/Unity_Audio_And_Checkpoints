using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 pos = rb.position;
        pos.z = PlayerPrefs.GetFloat("postition", 0f);
        rb.position = pos;
    }

    private void FixedUpdate()
    {
        movement.z = Input.GetAxisRaw("Vertical");
        rb.AddForce(movement * speed * Time.deltaTime);
    }
}