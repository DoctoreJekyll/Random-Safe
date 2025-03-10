using UnityEngine;

namespace GamePlay.Player
{
    public class PlayerId : MonoBehaviour
    {

        [SerializeField] private int id;

        public int GetId()
        {
            return id;
        }
        
    }
}
