using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerController : IExecute
    {
        private readonly Unit _player;
        private float horizontal;
        private float vertical;

        public PlayerController(Unit player)
        {
            _player = player;
        }

        public void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            _player.Move(horizontal, 0f, vertical);
        }
    }
}
