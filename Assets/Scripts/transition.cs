using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class transition : MonoBehaviour
{
    public Animator transitionAnimator;
    
    public void Transition(int SceneId)
    {
        transitionAnimator.SetBool("isTransition", true);
        StartCoroutine(ChangeScene(SceneId));
    }
    IEnumerator ChangeScene(int Scene_ID)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(Scene_ID);
    }
}
