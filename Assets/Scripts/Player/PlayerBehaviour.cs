using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBehaviour : MonoBehaviour
{
 public Rigidbody2D rb;
    [SerializeField] internal Collider2D minorCollider; // collider of mario in base form
    [SerializeField] internal Collider2D majorCollider; // collider of mario in mashroom and flower form or when crouching
    [SerializeField] internal SpriteRenderer playerSprite;
    [SerializeField] internal Transform graphicChild;
    
    [Header("PlayerStats")]
    public int playerCoins = 0;
    public int playerLife = 3;
    public int playerTime = 400;
    public bool baseMode = true;
    
    [Header("PlayerScritps")]
    [SerializeField] internal PlayerInput _input;
    [SerializeField] internal PlayerAnimation _animation;
    public PlayerJump _jump;
    public PlayerMovement _movement;
    [SerializeField] internal PlayerCrouching _crouch;
    [SerializeField] internal PlayerPowerUps _powerups;
	
    void Awake()
    {
	_jump = GetComponent<PlayerJump>();	
	_movement = GetComponent<PlayerMovement>();
    }

}