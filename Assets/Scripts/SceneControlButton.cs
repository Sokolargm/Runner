using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SceneControlButton : MonoBehaviour
{
    enum TargetScene
    {
        Next,
        Previous,
        MainScene
    }
    [SerializeField] TargetScene targetScene;
    Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        switch (targetScene)
        {
            case TargetScene.MainScene:
                button.onClick.AddListener(() => SceneController.LoadMainScene());
                break;
            case TargetScene.Next:
                button.onClick.AddListener(() => SceneController.LoadNextScene());
                break;
            case TargetScene.Previous:
                button.onClick.AddListener(() => SceneController.LoadPreviousScene());
                break;
        }
    }
}
