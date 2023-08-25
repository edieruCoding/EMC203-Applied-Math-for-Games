using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D player;

    float horizontal;
    float vertical;

    public float runSpeed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        player.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}