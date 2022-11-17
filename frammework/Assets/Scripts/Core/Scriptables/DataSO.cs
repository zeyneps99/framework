using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.DataTypes;

namespace Core.Scriptables {

[CreateAssetMenu(fileName = "DataSO", menuName = "Core/Data")]
public class DataSO : SO {

public PermanentData permData;
public TempData tempData;

}
}