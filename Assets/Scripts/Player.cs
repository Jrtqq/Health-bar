using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerCollisionManager))]

public class Player : MonoBehaviour
{
    private int _coins = 0;
    private PlayerCollisionManager _collisionManager;
    public UnityAction CoinAdded;

    private void Awake()
    {
        _collisionManager = GetComponent<PlayerCollisionManager>();
    }

    private void OnEnable()
    {
        CoinAdded += AddCoin;
    }

    private void OnDisable()
    {
        CoinAdded -= AddCoin;
    }

    private void AddCoin()
    {
        _coins++;
        Debug.Log("Coins - " + _coins);
    }

    public void AddCoinEvent()
    {
        CoinAdded?.Invoke();
    }
}
