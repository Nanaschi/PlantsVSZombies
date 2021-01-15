using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    [Range(0, 100)]
    [SerializeField] float startSpeed = 1f;
    [SerializeField] float startRotation = 1f;
    [SerializeField] int damage = 100;
   
    private void Start()
    {
      
    }
    private void Update()
    {
        transform.Translate(Vector2.right * startSpeed * Time.deltaTime, Space.World); // Space World makes the game object independent and
        transform.Rotate(0, 0, startRotation); // allows the rotation work only along the line
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();
        if (attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
        
    }
}
