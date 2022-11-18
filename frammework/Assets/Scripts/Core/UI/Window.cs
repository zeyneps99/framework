using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core.UI {
public abstract class Window : MonoBehaviour {
public static CanvasGroup canvasGroup;
public bool isVisible;

    private void Awake() {
        TryGetComponent(out canvasGroup);
    }

    public void Hide() {
        isVisible = false;
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }

    public void Show() {
        isVisible = true;
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;

    }
}
}