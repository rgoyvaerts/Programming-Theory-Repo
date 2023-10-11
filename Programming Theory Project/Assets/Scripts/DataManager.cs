using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    public string inputString;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadData();
    }

    [System.Serializable]

    class WriteData
    {
        public string inputString;
    }

    public void SaveData()
    {
        WriteData data = new WriteData();
        data.inputString = inputString;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "savedata.json", json);
        Debug.Log("Data Saved to: " + Application.persistentDataPath + "savedata.json");
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "savedata.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            WriteData data = JsonUtility.FromJson<WriteData>(json);
            inputString = data.inputString;
        }
    }
}
