using System;
using UnityEngine;

namespace Core.Events {

public static partial class Events {

    public static class Core 
    {
        //list core game events here
        public static Action StartGame;
        public static Action<bool> EndLevel;
        public static Action StartLevel;
        public static Action RestartLevel;
        public static Action NextLevel;
        public static Action MenuButtonPressed;
        public static Action LevelSelected;

    }
}
}