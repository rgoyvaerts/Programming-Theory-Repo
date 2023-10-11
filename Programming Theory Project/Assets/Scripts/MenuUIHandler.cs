using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private string usernameInput;
    [SerializeField] private TMP_Text subtitle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InputFieldGrabber(string input)
    {
        usernameInput = input;
        SaveUsername();
        DisplayUsername();
    }

    public void SaveUsername()
    {
        DataManager.Instance.inputString = usernameInput;
        DataManager.Instance.SaveData();
    }

    public void DisplayUsername()
    {
        subtitle.text = "Welcome " + usernameInput + "!";
    }
}
