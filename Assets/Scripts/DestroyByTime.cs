using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {

    public float duration = 5;

	void Update () {
        duration -= Time.deltaTime;
        if (duration < 0)
        {
            Destroy(this.gameObject);
        }
	}
}
