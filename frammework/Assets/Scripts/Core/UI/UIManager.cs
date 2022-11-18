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
        Events.Events.Core.ShowMenu += ShowMenuWindow;
   }

   private void OnDisable() {
        Events.Events.Core.GameStarted -= ShowMainWindow;
        Events.Events.Core.ShowMenu -= ShowMenuWindow;
   }

   private void ShowMainWindow() {
    menuWindow.Hide();
    mainWindow.Show();
   }

   private void ShowMenuWindow() {
    mainWindow.Hide();
    menuWindow.Show();
   }
}
}