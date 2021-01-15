using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int startingHealth = 200;
    [SerializeField] GameObject deathVFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DealDamage(int damage)  //method which allows to change parameters in another script (should be public)
    {
        startingHealth -= damage;
        if (startingHealth <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);

        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }
        var destroyingVFX = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(destroyingVFX, 1f);
    }
}
