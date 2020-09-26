using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] bool isLeft = false;
    [SerializeField] [Range(0,10)] float projectileSpeed=1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProjectileMovement();
    }

    public void ProjectileMovement()
    {
        if (!isLeft)
        {
            transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed);
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime * projectileSpeed);
        }
    }


}
