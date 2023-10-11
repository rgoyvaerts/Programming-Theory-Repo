using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private string usernameInput;
    [SerializeField] private TMP_Text subtitle;

    [SerializeField] private GameObject GoStartingTimer;
    [SerializeField] private TMP_Text startingTimer;

    private float timeLeft = 5.0f;
    private bool startTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        {
            timeLeft -= Time.deltaTime;
            startingTimer.text = "Starting in " + timeLeft.ToString("0") + " sec...";
        }

        if (timeLeft <= 0)
        {
            startTimer = false;
            SceneManager.LoadScene(1);  
        }
    }

    public void InputFieldGrabber(string input)
    {
        usernameInput = input;
        SaveUsername();
        DisplayUsername();
        NextScene();
    }

    //ABSTRACTION
    public void SaveUsername()
    {
        DataManager.Instance.inputString = usernameInput;
        DataManager.Instance.SaveData();
    }

    //ABSTRACTION
    public void DisplayUsername()
    {
        subtitle.text = "Welcome " + usernameInput + "!";
    }

    //ABSTRACTION
    public void NextScene()
    {
        GoStartingTimer.SetActive(true);
        startTimer = true;
    }


}
