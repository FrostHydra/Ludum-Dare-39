using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTurret : MonoBehaviour {

    [Range(-10, 10)]
    public float depth;

    public float minAngle = -90f, maxAngle = 90f;

    private bool isPowered;
    private Quaternion targetRot;

    private void Start()
    {
        targetRot = transform.rotation;
    }

    void Update () {
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, 0.5f);

        if (!isPowered) { return; }



        Vector3 v3 = Input.mousePosition;
        v3.z = depth;
        v3 = Camera.main.ScreenToWorldPoint(v3) - transform.position;
        v3.Normalize();

        float rot_z = Mathf.Atan2(v3.y, v3.x) * Mathf.Rad2Deg;
        
        if (minAngle > maxAngle)
        {
            if (rot_z > maxAngle && rot_z < minAngle)
            {
                rot_z = minAngle;
            }

        } else
        {
            rot_z = Mathf.Clamp(rot_z, minAngle, maxAngle);
        }
        

        targetRot = Quaternion.Euler(0f,0f,rot_z - 90);
        
	}

    public void powerSystem(bool power)
    {
        isPowered = power;
    }
}
