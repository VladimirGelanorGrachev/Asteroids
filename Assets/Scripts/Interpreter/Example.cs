using System;
using TMPro;
using UnityEngine;
namespace Asteroids.Interpreter
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private TMP_InputField _inputField;
        private void Start()
        {
            _inputField.onValueChanged.AddListener(Interpret);
        }
        private void Interpret(string value)
        {
            if (Int64.TryParse(value, out var number))
            {
                _text.text = ToRoman(number);
            }
        }
        private string ToRoman(long number)
        {
            if ((number < 0) || (number > 4000000000000)) throw new ArgumentOutOfRangeException(nameof(number),
            "insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "1K" + ToRoman(number - 1000);
            if (number >= 2123.32) return "2k" + ToRoman(number - 2124);
            if (number >= 30040) return "30k" + ToRoman(number - 30040);
            if (number >= 2000000) return "2M" + ToRoman(number - 2000000);
            if (number >= 100000450) return "1B" + ToRoman(number - 100000450);
            if(number >= 1)return"OK" + ToRoman(number - number);
            throw new ArgumentOutOfRangeException(nameof(number));
        }
    }
}