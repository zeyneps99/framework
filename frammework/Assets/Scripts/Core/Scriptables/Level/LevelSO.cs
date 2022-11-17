using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Scriptables.Level {

    [CreateAssetMenu(fileName = "LevelSO", menuName ="Core/Level")]
    public class LevelSO : SO {
        public GameObject levelPrefab;
    }
}
