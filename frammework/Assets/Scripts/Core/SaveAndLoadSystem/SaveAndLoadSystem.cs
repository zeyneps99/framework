using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.DataTypes;
using Core.Scriptables;
using Core.BaseClasses;
using UnityEngine.Networking;


public class SaveAndLoadSystem : StaticObjectBase<SaveAndLoadSystem>
{

public DataSO data;
private void Awake() {
    LoadData(false);
}

public static void LoadData(bool isOnline) {
    if (!isOnline) {
    string savedData = PlayerPrefs.GetString(nameof(SaveAndLoadSystem)+nameof(PermanentData), "");
    if (string.IsNullOrEmpty(savedData)) {
        SetDefault(isOnline);
    } else {
        Instance.data.permData = JsonUtility.FromJson<PermanentData>(savedData);
    }
    } else {
        LoadDataOnline();
    }
   
}

public static void SaveData(bool isOnline) {
    if (isOnline) {
        SaveDataOnline();
    } else {
        string newData = JsonUtility.ToJson(Instance.data.permData);
        PlayerPrefs.SetString(nameof(SaveAndLoadSystem)+nameof(PermanentData), newData);
    }
    
}

public static void ResetData(bool isOnline) {
    if (isOnline) {

    } else {
        PlayerPrefs.DeleteAll();
    }
    //can also delete individually for each key w/ delete key
}

public static void SetDefault(bool isOnline) {
    if (isOnline) {

    } else {
        Instance.data.permData.IsAudioOn = false;
    }
    SaveData(isOnline);



}

public IEnumerator LoadDataOnline() {
    UnityWebRequest www = UnityWebRequest.
    
    Get("https://www.my-server.com");
    yield return www.SendWebRequest();
    if (www.result != UnityWebRequest.Result.Success) {
            Debug.Log(www.error);
        }
        else {
             // Show results as text
            Debug.Log(www.downloadHandler.text);
 
            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
}



public static void SaveDataOnline() {
    string newData = JsonUtility.ToJson(Instance.data.permData);
    PlayerPrefs.SetString(nameof(SaveAndLoadSystem)+nameof(PermanentData), newData);
}


}
