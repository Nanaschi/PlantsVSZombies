using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    TextMeshProUGUI starText;
     // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }
    public void AddStars (int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public void SpendStars (int amount)
    {
        if (stars >= 0)
        {
            stars -= amount;
            UpdateDisplay();
        }
    }

   
}
