using UnityEngine;


namespace SOArchitecture.Variables
{
    [CreateAssetMenu]
    public class BoolVariable : ScriptableObject
    {
        [SerializeField]
        private bool value = false;

        public bool Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }
}