using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab; //here you assign prefab manually
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(58, 58, 58, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white; 
        FindObjectOfType<GameArea>().SetSelectedDefender(defenderPrefab);
    }
}
