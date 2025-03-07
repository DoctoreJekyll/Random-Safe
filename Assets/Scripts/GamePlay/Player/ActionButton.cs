using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace GamePlay.Player
{
    public class ActionButton : MonoBehaviour
    {
        private Button button;
        private PlayerInputController playerInputController;

        private void Awake()
        {
            button = GetComponent<Button>();
        }

        private void Start()
        {
            playerInputController = GameObject.FindWithTag("Player").GetComponent<PlayerInputController>();

            if (button != null && playerInputController != null)
            {
                button.clicked += () => playerInputController.JumpForce();
            }
        }
    }
}
