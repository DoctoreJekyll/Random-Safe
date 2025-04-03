using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace GamePlay.Player
{
    public class ActionButton : MonoBehaviour
    {
        private Button button;
        [SerializeField] private PlayerInputController playerInputController;

        private bool isNotSet = false;

        private void Awake()
        {
            button = GetComponent<Button>();
        }

        public void SetButtonBehaviour()
        {
            if (isNotSet == false)
            {
                playerInputController = GameObject.FindWithTag("Player").GetComponent<PlayerInputController>();

                if (button != null && playerInputController != null)
                {
                    button.onClick.AddListener(playerInputController.JumpForce);
                    Debug.Log("Listener add on buttton");
                }
                
                isNotSet = true;
            }
        }
    }
}
