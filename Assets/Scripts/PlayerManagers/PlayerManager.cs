using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerManagers
{
    public class PlayerManager : MonoBehaviour
    {

        [SerializeField] private List<GameObject> playerPrefabs = new List<GameObject>();
        private int playerIdActive;

        private void Start()
        {
            playerIdActive = PlayerPrefs.HasKey("PlayerIdActive") ? PlayerPrefs.GetInt("PlayerActiveId", 0) : 0;
            playerPrefabs[playerIdActive].SetActive(true);
        }
    }
}
