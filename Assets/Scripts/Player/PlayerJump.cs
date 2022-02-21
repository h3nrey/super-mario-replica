using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private PlayerBehaviour _playerBehaviour;

    [Header("jumpingSettings")]
    [SerializeField] private float jumpForce; 
    [SerializeField] internal float highJumpForce, lowJumpForce;
    [SerializeField] private float jumpTime;
	[SerializeField] private float lowFallingMultiplier, fallMultiplier;
    private float jumpCounter;
    private bool isJumping;

    [Header("Ground Checking")]
    [SerializeField] private Transform groundChecker;
    private bool grounded;
    [SerializeField] private LayerMask groundMask;
    [Range(0.1f, 0.5f)][SerializeField] private float groundCheckerRange = 0.5f;
    public bool canJump;

	[Header("Gizmos")]
	[SerializeField] private Color32 corzinha;

    void Awake() {
        _playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
   
	private void Start(){
		setupJumpForce(lowJumpForce);
	}
    
	private void FixedUpdate() {
		grounded = Physics2D.OverlapCircle(groundChecker.position, groundCheckerRange, groundMask);
		if(_playerBehaviour.rb.velocity.y < 0)
		_playerBehaviour.rb.gravityScale = fallMultiplier;
		else if(_playerBehaviour.rb.velocity.y < 0){ 
			_playerBehaviour.rb.gravityScale = lowFallingMultiplier;	
		}
	}
	internal void Jump(){
		if(grounded) {
			// _playerBehaviour.rb.AddForce(Vector2.up * jumpForce);
			_playerBehaviour.rb.velocity = Vector2.up * jumpForce;
			isJumping = true;
			jumpCounter = jumpTime;
		}	
		else if(!grounded && isJumping){
			if(jumpCounter > 0) {
				// _playerBehaviour.rb.AddForce(Vector2.up * jumpForce);
				_playerBehaviour.rb.velocity = Vector2.up * jumpForce;
				jumpCounter -= Time.deltaTime;
			}
			else{
				isJumping = false;
			}
		}
	}

	internal void StoppingJumping(){
		isJumping = false;
	}	

	internal void setupJumpForce(float force){
		jumpForce = force;
	}

	void OnDrawGizmosSelected() {
		Gizmos.color = corzinha;
		Gizmos.DrawWireSphere(groundChecker.position, groundCheckerRange);
	}

}
