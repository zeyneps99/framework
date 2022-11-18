using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core.UI {
public abstract class Window : MonoBehaviour {
    
[SerializeField]
public static CanvasGroup canvasGroup;
[SerializeField]
public bool isVisible;

    private void Awake() {
        isVisible = false;
        if (!TryGetComponent(out canvasGroup)) {
            Debug.Log("Canvas group of the given window cannot be found.");
            }
    }

    public void Hide() {
        isVisible = false;
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
    }

    public void Show() {
        isVisible = true;
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
    }
}
}