using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameScript : MonoBehaviour
{
    public Animator transitionOutAnimator;
    public GameObject firstGameUI;
    public GameObject secondGameUI;
    public GameObject shopPanel;

    void Start()
    {
        transitionOutAnimator.SetBool("isOutTransition", true);
        StartCoroutine(setOutTransitBool());
    }
    IEnumerator setOutTransitBool()
    {
        yield return new WaitForSeconds(1f);
        transitionOutAnimator.SetBool("isOutTransition", false);
    }
    public void startGame()
    {
        firstGameUI.SetActive(false);
        secondGameUI.SetActive(true);
        GameObject.Find("Player").GetComponent<PlayerController>().isGameStarted = true;
        GameObject.Find("Player").GetComponentInChildren<Animator>().SetBool("isRunning", true);
    }
    public void ShowShopPanel()
    {
        shopPanel.SetActive(true);
    }
    public void HideShopPanel()
    {
        shopPanel.SetActive(false);
    }
}
