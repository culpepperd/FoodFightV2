using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WristWatch : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI watchText;



    void Update()
    {
        watchText.text = System.DateTime.Now.ToShortTimeString();
    }
}
