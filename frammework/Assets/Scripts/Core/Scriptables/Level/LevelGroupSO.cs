using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core.Scriptables.Level {
[CreateAssetMenu(fileName = "LevelGroupSO", menuName ="Core/LevelGroup")]
    public class LevelGroupSO : SO {
        public List <LevelSO> levels;

        public GameObject GetLevel(int index) {
            int netIndex = index % levels.Count;
            return levels[netIndex].levelPrefab;
        }
    }
}