using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.SceneManagement;

namespace Core.UI {
public class MainWindow : Window {
    public void OnButtonClicked() {
        Events.Events.Core.MenuButtonPressed?.Invoke();
        SceneManager.LoadSceneAsync("Menu");
        }
    }


}

