using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCrouching : MonoBehaviour {
 bool isCrouching = false;

[SerializeField] private PlayerBehaviour _playerBehaviour;
    
	void Start(){
			_playerBehaviour.enabled = true;
			_playerBehaviour.enabled = false;
	}

	internal void Crouch(){
		if(!_playerBehaviour.baseMode) {
			if(isCrouching) {
				_playerBehaviour._movement.enabled = true;
				 _playerBehaviour.minorCollider.enabled = false;
				 _playerBehaviour.majorCollider.enabled = true;
				isCrouching = false;
			} else {
				_playerBehaviour.minorCollider.enabled = true;
				 _playerBehaviour.majorCollider.enabled = false;
				_playerBehaviour._movement.enabled = false;
				isCrouching = true;	
			}
			_playerBehaviour._animation.SetBolleans("isCrounch",isCrouching);
		}
	}
}
