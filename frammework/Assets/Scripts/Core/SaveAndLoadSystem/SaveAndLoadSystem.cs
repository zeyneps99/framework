using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.DataTypes;
using Core.Scriptables;
using Core.BaseClasses;


public class SaveAndLoadSystem : StaticObjectBase<SaveAndLoadSystem>
{

public DataSO data;
private void Awake() {
    LoadData();
}

public static void LoadData() {
    string savedData = PlayerPrefs.GetString(nameof(SaveAndLoadSystem)+nameof(PermanentData), "");
    if (string.IsNullOrEmpty(savedData)) {
       SetDefault();
    } else {
        Instance.data.permData = JsonUtility.FromJson<PermanentData>(savedData);
    }
}

public static void SaveData() {
    string newData = JsonUtility.ToJson(Instance.data.permData);
    PlayerPrefs.SetString(nameof(SaveAndLoadSystem)+nameof(PermanentData), newData);
}

public static void ResetData() {
    PlayerPrefs.DeleteAll();
    //can also delete individually for each key w/ delete key
}

public static void SetDefault() {
    Instance.data.permData.IsAudioOn = false;
    SaveData();

}


}
