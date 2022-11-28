using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core.UI {
[RequireComponent(typeof(CanvasGroup))]
public abstract class Window : MonoBehaviour {
public static CanvasGroup canvasGroup;
public bool isVisible;

    private void Awake() {
        isVisible = false;
    }

    public void Hide() {
        Debug.Log("hide");
        isVisible = false;
        TryGetComponent(out canvasGroup);
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }

    public void Show() {
        Debug.Log("show");
        TryGetComponent(out canvasGroup);
        isVisible = true;
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

}
}