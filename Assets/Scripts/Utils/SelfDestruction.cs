using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
	public void DestroyMe(){
		Destroy(this.gameObject);
	}
}
