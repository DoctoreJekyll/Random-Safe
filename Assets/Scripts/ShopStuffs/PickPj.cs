using UnityEngine;

namespace ShopStuffs
{
    public class PickPj : MonoBehaviour
    {
        private readonly string playerSelectableKey = "PlayerIdActive";


        public void SetPlayerActive(int playerId)
        {
            PlayerPrefs.SetInt(playerSelectableKey, playerId);
        }

    }
}
