using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    [System.Serializable] class ShopItem
    {
        public Sprite Image;
        public int Price;
        public bool isPurchased = false;
    }
    [SerializeField] List<ShopItem> ShopItemsList;
    [SerializeField] Animator NoCoinsAnim;
    [SerializeField] Text coinstext;
    GameObject ItemTemplate;
    GameObject g;
    [SerializeField] Transform ShopScrollView;
    Button buyBtn;


    private void Start()
    {
        ItemTemplate = ShopScrollView.GetChild(0).gameObject;
        int len = ShopItemsList.Count;
        for(int i = 0; i < len; i++)
        {
            g = Instantiate(ItemTemplate, ShopScrollView);
            g.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemsList[i].Image;
            g.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = ShopItemsList[i].Price.ToString();
            buyBtn = g.transform.GetChild(2).GetComponent<Button>();
            buyBtn.interactable = !ShopItemsList[i].isPurchased;
            buyBtn.AddEventListener(i, OnShopItemBtnClicked);
        }
        Destroy(ItemTemplate);
        SetCoinsUI();
    }
    void OnShopItemBtnClicked(int itemInex)
    {
            if(Game.Instance.HasEnoughCoins(ShopItemsList[itemInex].Price)){
                Game.Instance.UseCoins(ShopItemsList[itemInex].Price);
                 ShopItemsList[itemInex].isPurchased = true;
            buyBtn = ShopScrollView.GetChild(itemInex).GetChild(2).GetComponent<Button>();
            buyBtn.interactable = false;
            buyBtn.transform.GetChild(0).GetComponent<Text>().fontSize = 24;
            buyBtn.transform.GetChild(0).GetComponent<Text>().text = "PURCHASED";
        
SetCoinsUI();
            } else{
            NoCoinsAnim.SetTrigger("NoCoins");
                Debug.Log("U dont have enough money :shy:");
            }
           
    }
    void SetCoinsUI(){
        coinstext.text = Game.Instance.Coins.ToString();
    }
}
