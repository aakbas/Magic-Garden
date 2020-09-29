using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    [SerializeField] int baseHealth=3;
    [SerializeField] Text healthText;


    private void Start()
    {
        updateHealth();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BaseHit(collision);
        updateHealth();
    }

    private void BaseHit(Collider2D collision)
    {
        baseHealth -= 1;
        if (baseHealth <= 0)
        {
            Debug.Log("Game Over");
        }
        Destroy(collision.gameObject);
    }

    private void updateHealth()
    {
        healthText.text = baseHealth.ToString();
    }



}
