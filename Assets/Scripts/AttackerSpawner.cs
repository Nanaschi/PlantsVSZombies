
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minimumSpawnValue = 1f;
    [SerializeField] float maximumSpawnValue = 5f;
    [SerializeField] Attacker attackerPrefab; //A VERY IMPORTANT WAY OF ASSIGNING THE GAMEOBJECT THROUGH THE PUBLIC SCRIPT THAT IS ATTACHED TO IT! 
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn) //turns Start to Update? 
        {
            yield return new WaitForSeconds(Random.Range(minimumSpawnValue, maximumSpawnValue));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation); // transform.rotation could be Quaternion.identity
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
