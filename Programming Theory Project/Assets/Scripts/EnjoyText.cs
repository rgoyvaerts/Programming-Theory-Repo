using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnjoyText : MonoBehaviour
{
    [SerializeField] private TMP_Text Go;

    // Start is called before the first frame update
    void Start()
    {
        Go.text = "Click the shapes, " + DataManager.Instance.inputString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
