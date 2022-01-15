using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private PlayerBehaviour _playerBehaviour;
    private void Awake() {
        _playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
		switch(other.gameObject.tag){
		case "coin" :
			_playerBehaviour.playerCoins++;
			other.gameObject.GetComponent<SelfDestruction>().DestroyMe();
			break;
		case "mushroom":
			_playerBehaviour._powerups.GivePowerUps("mushroom");
			other.gameObject.GetComponent<SelfDestruction>().DestroyMe();
			break;
		}
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "floor") {
            _playerBehaviour._jump.canJump = true;
            _playerBehaviour._animation.SetBolleans(_playerBehaviour._animation.groundParam, true);
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "floor") {
            _playerBehaviour._jump.canJump = false;
            _playerBehaviour._animation.SetBolleans(_playerBehaviour._animation.groundParam, false);
        }
    }
    
}
