using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUps : MonoBehaviour {
 internal bool onMushroomMode, onFlowerMode, onStarMode;

 [SerializeField] private PlayerBehaviour _playerBehaviour;

 [Header("Flower Shooting")]
 [SerializeField] private GameObject fireProjectille;
 [SerializeField] private Transform shootPoint;
 [SerializeField] private float shootCooldown = 0.5f;
 [SerializeField] private bool canShoot = true;
 
 [Header("fire")]
 [SerializeField] private float horizontalForce;
 [SerializeField] private float lauchForce;

	internal void GivePowerUps(string powerupName){
		_playerBehaviour.baseMode = false;

		switch(powerupName){
			case "mushroom":
				ActiveMushroom();
				break;
			case "flower":
				ActiveFlower();
				break;
			case "star":
				//star coroutine
				break;
			default:
				//mushroom method
				break;
			}
	}

	internal void ActiveMushroom(){
		onMushroomMode = true;
		_playerBehaviour._playerLife.currentLife++;
		_playerBehaviour.majorCollider.enabled = true;
		_playerBehaviour._jump.setupJumpForce(_playerBehaviour._jump.highJumpForce);
		_playerBehaviour._animation.SetBolleans("isBigger",true);
	}

	internal void ActiveFlower(){
		onFlowerMode = true;
		_playerBehaviour._playerLife.currentLife++;
		_playerBehaviour.majorCollider.enabled = true;
		_playerBehaviour._jump.setupJumpForce(_playerBehaviour._jump.highJumpForce);
		_playerBehaviour._animation.SetBolleans("isWhite",true);
	}

	internal IEnumerator InstantiateFire(){
		if(canShoot && onFlowerMode) {
			canShoot = false;
			GameObject fireGameObject = Instantiate(fireProjectille, shootPoint.position, Quaternion.identity) as GameObject;
			Rigidbody2D fireRb = fireGameObject.GetComponent<Rigidbody2D>();
			fireRb.velocity = transform.right * horizontalForce * Time.deltaTime;
			yield return new WaitForSeconds(shootCooldown);
			canShoot = true;
		}
	}

	internal void ReturnToBaseForm(){
		_playerBehaviour.baseMode = true;
		_playerBehaviour.majorCollider.enabled = false;
		_playerBehaviour._jump.setupJumpForce(_playerBehaviour._jump.lowJumpForce);
		_playerBehaviour._animation.SetBolleans("isBigger",false);
		_playerBehaviour._animation.SetBolleans("isWhite",false);
	}
}
