using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class increandDecre : MonoBehaviour
{
    public Button increment, decrement;
    public TextMeshProUGUI number;
    public int count=0;
    public GameObject text;




    public void incrementt()
    {
        if(count < 10)
        {
            count++;
            number.text = count.ToString();
        }
    }
    public void decrementt() { 
        
    if(count > 0) { 
        count--;   
            number.text = count.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 10)
        {
            text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
        }
    }
}
