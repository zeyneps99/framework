using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.SceneManagement;

namespace Core.UI {
public class MenuWindow : Window {
    
    public void OnButtonPressed() {
        Events.Events.Core.LevelSelected?.Invoke();
        SceneManager.LoadSceneAsync("Game");
        }
    }
}

