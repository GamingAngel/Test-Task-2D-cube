using UnityEngine;
using TMPro;


[RequireComponent(typeof(TMP_Text))]
public class CoinText : MonoBehaviour
{
    private TMP_Text coinText;
    private int coinCount;
    void Start() => coinText = GetComponent<TMP_Text>();

    private void OnUpdateText()
    {
        coinCount++;
        coinText.text = coinCount.ToString();
    }


    private void OnEnable() => Coin.OnCoinsTouch += OnUpdateText;

    private void OnDisable() => Coin.OnCoinsTouch -= OnUpdateText;
}
