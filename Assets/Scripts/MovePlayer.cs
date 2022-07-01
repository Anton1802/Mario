using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private float playerSpeed = 5.0f;
    private float jumpPower = 5.0f;

    public Rigidbody2D player;

    private void Move()
    {

        var horizontal = Input.GetAxisRaw("Horizontal");

        player.velocity = new Vector2(horizontal * playerSpeed, player.velocity.y);

    }

    private void Jump() => player.velocity = new Vector2(0, jumpPower);

    void Update()
    {

        Move();

        if(Input.GetKey(KeyCode.Space))
        Jump();

    }



}
