using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.BaseClasses;
using UnityEngine.SceneManagement;
using Core.Events;
using Core.Scriptables.Level;
namespace Core {
public class Core : StaticObjectBase<Core>
{
   public bool isGameOver;
   public int currentLevel;
   public GameObject currentLevelObject;
   
   public LevelGroupSO levelGroup;

   private void Awake() {
      DontDestroyOnLoad(gameObject);
   }

   private void Start() {
          StartGame();
   }
   private void OnEnable() {
   }

   private void OnDisable() {
   }

   private void Hello(){
      Debug.Log("hello");
   }
   private void StartGame() {
      Debug.Log("startgame");
    currentLevel = 0;
   Events.Events.Core.GameStarted?.Invoke();

    //SceneManager.LoadSceneAsync("Main");
    // Events.Events.Core.Test?.Invoke(false);
    // Events.Events.Core.GameStarted?.Invoke();
    
    }

   public void StartLevel() {
    PlayerPrefs.SetInt("level", currentLevel);
    currentLevelObject = Instantiate(levelGroup.GetLevel(currentLevel));
   }

   public void EndLevel(bool isWin) {
    Destroy(currentLevelObject);
    isGameOver = true;
    if (isWin) {

    } else {

    }
   }

   public void NextLevel() {
    currentLevel++;
   }

   public void RestartLevel() {
    Destroy(currentLevelObject);
    StartLevel();
   }
}
}