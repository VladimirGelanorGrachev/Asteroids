using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids.Abstract_Factory
{
    internal sealed class ConsoleInput : IInput
    {
      public string Name => nameof(ConsoleInput);
    }
}
