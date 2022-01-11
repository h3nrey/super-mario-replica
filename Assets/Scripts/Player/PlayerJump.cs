using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private PlayerBehaviour _playerBehaviour;
    [SerializeField] float jumpForce;
    [SerializeField] float rayDistance;
    public bool canJump;

    void Awake()
    {
        _playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
   
    // Update is called once per frame
    internal void Jump()
    {
       if(canJump)
       	 _playerBehaviour.rb.AddForce(Vector2.up * jumpForce);
	print("pulou com essa força : " + jumpForce);
    }


}
