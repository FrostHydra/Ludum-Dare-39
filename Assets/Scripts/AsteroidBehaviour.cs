using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {

    public float minRotationSpeed = -80;
    public float maxRotationSpeed =  80;

    private float rotationspeed;

    public GameObject deathParticles;

    void Start()
    {
        rotationspeed = Random.Range(minRotationSpeed, maxRotationSpeed);
    }
    
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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("SpaceShuttle"))
        {
            Instantiate(deathParticles, this.transform.position, this.transform.rotation);
            ShipStats.Instance.GetDamage(1);
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name.Contains("Bullet"))
        {
            Instantiate(deathParticles, this.transform.position, this.transform.rotation);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
