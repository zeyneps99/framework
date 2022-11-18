using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.SceneManagement;

namespace Core.UI {
public class MainWindow : Window {
    
    public void OnButtonClicked() {
        SceneManager.LoadSceneAsync("Menu");
        }
    }


}

