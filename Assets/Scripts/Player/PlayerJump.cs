using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private PlayerBehaviour _playerBehaviour;
    [SerializeField] float jumpForce; 
    [SerializeField] internal float highJumpForce, lowJumpForce;
    [SerializeField] float rayDistance;
    public bool canJump;

    void Awake()
    {
        _playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
   
    private void Start(){
	setupJumpForce(lowJumpForce);
    }
    // Update is called once per frame
    internal void Jump(){
       if(canJump)
       	 _playerBehaviour.rb.AddForce(Vector2.up * jumpForce);
	print("pulou com essa força : " + jumpForce);
    }

    internal void setupJumpForce(float force){
	jumpForce = force;
    }


}
