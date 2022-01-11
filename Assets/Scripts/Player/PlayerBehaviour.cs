using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody2D rb;
    

    //externals
	[SerializeField] internal PlayerInput _input;
    	public PlayerJump _jump;
    	public PlayerMovement _movement;
	

    void Awake()
    {
	_jump = GetComponent<PlayerJump>();	
	_movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        /* float inputX = Input.GetAxisRaw("Horizontal") * speed;
        
        rb.velocity = new Vector2(inputX, rb.velocity.y);

        if(Input.GetButtonDown("Jump")) {
	_jump.Jump();
         }
	*/
    }
}
