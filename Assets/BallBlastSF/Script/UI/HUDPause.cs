using UnityEngine;
using UnityEngine.Events;

namespace Blasta
{
    public class HUDPause : MonoBehaviour
    {
        public UnityEvent Enter;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                Enter.Invoke();
                FindObjectsOfType<Stone>(enabled = false);
            }
        }
    }
}