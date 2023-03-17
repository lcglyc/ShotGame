using UnityEngine;
using System.Collections;

public class JG_enemy : Enemy {
	public GameObject jiguang;
	
	
	// Update is called once per frame
	new void  Update () {
		base.Update ();
	}
	public override void EnemyDestory()
	{
		Instantiate (Resources.Load<GameObject> ("Hited/Destoryed"),transform.position,Quaternion.identity);
		if (jiguang != null) {
			Destroy(jiguang);
		}
		Destroy (gameObject);
	}
}
