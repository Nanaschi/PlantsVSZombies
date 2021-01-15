using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : MonoBehaviour
{
    Defender defender; //
 public void SetSelectedDefender (Defender defenderToSelect) //
    {
        defender = defenderToSelect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked()); //gives the Vector2 coordinate stored in the GetSquareClicked Method

    }
     
    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);  
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos); 
        Vector2 gridPos = SnapToGrid(worldPos); 
        return gridPos; //returns the clicked Vector2
    }
    private Vector2 SnapToGrid (Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x); //this rounds up an int
        float newY = Mathf.RoundToInt(rawWorldPos.y); //this rounds up an int
        return new Vector2(newX, newY);  //returns rounded up Vector2 
    }

    private void SpawnDefender(Vector2 gridPos)   //asks for Vector2 coordinate (gridPos) to instantiate 
    {

        var newShooter = Instantiate(defender, gridPos, transform.rotation);
        
    }
}
