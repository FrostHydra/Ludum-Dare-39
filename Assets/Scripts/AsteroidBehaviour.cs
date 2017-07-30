using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {
    
    public float rotationspeed;
    
    void Update () {
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * rotationspeed));


        if(IsOutOfScreen(this.gameObject, Camera.main) ) {
            Destroy(gameObject);
        }
        


    }


    public bool IsOutOfScreen(GameObject o, Camera cam = null)
    {
        bool result = false;
        Renderer ren = o.GetComponent<Renderer>();
        if (ren)
        {
            if (cam == null) cam = Camera.main;
            Vector2 sdim = SpriteScreenSize(o, cam);
            Vector2 pos = cam.WorldToScreenPoint(o.transform.position);
            Vector2 min = pos - sdim;
            Vector2 max = pos + sdim;
            if (min.x > Screen.width || max.x < 0f ||
                min.y > Screen.height || max.y < 0f)
            {
                result = true;
            }
        }
        else
        {
            //TODO: throw exception or something
        }
        return result;
    }

    public Vector2 SpriteScreenSize(GameObject o, Camera cam = null)
    {
        if (cam == null) cam = Camera.main;
        Vector2 sdim = new Vector2();
        Renderer ren = o.GetComponent<Renderer>() as Renderer;
        if (ren)
        {
            sdim = cam.WorldToScreenPoint(ren.bounds.max) -
                cam.WorldToScreenPoint(ren.bounds.min);
        }
        return sdim;
    }
}
