using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string PlayerName;
    public int Score;
    // Start is called before the first frame update
    private void Awake() {

        LoadData();

        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    // [System.Serializabe]
    [System.Serializable]
    class PlayerData
    {
        public string PlayerName;
        public int Score;

    }
    public void SaveData()
    {
        PlayerData data = new PlayerData();
        data.PlayerName = PlayerName;
        data.Score = Score;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            PlayerName = data.PlayerName;
            Score = data.Score;
        }
    }
}
