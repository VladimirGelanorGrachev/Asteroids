using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Enemy : Unit, IMove

    {
        private readonly IMove _moveImplementation;
        
        public float Speed => _moveImplementation.Speed;

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveImplementation.Move(horizontal, vertical, deltaTime);
        }


    }
}
