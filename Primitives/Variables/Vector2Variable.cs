using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOArchitecture.Variables
{
    [CreateAssetMenu]
    public class Vector2Variable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        public Vector2 Value;

        public void SetValue(Vector2 value) => Value = value;
        public void SetValue(Vector2Reference value) => Value = value.Value;

        public void ApplyChanges(Vector2 amount) => Value += amount;

        public void ApplyChanges(Vector2Reference amount) => Value += amount.Value;
    }
}
