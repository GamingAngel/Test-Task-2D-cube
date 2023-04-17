using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Coin : MonoBehaviour
{
    public static Action OnCoinsTouch;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnCoinsTouch?.Invoke();
        Destroy(gameObject);
    }
}
