using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SynopsisController : MonoBehaviour
{
    public GameObject synposisPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideSynopsisPanel()
    {
        synposisPanel.SetActive(false);
    }
}
