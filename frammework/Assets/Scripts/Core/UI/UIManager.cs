using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.BaseClasses;


namespace Core.UI {
public class UIManager : StaticObjectBase<UIManager> {
    public MainWindow mainWindow;
    public MenuWindow menuWindow;

   private void OnEnable() {
        Events.Events.Core.GameStarted += ShowMainWindow;
        Events.Events.Core.Test += Test;
        Events.Events.Core.ShowMenu += ShowMenuWindow;
   }

   private void OnDisable() {
        Events.Events.Core.GameStarted -= ShowMainWindow;
        Events.Events.Core.ShowMenu -= ShowMenuWindow;
        Events.Events.Core.Test -= Test;

   }

   private void ShowMainWindow() {
    Debug.Log("show main");
    mainWindow.Show();
    menuWindow.Hide();
   }

   private void ShowMenuWindow() {
    Debug.Log("show menu");
    mainWindow.Hide();
    menuWindow.Show();
   }

   private void Test(bool var) {
    Debug.Log(var);
   }
}
}