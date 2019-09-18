using UnityEngine;

namespace Bonwerk.Injection
{
    public class ExampleClient : MonoBehaviour
    {
        private void Start()
        {
            Service = Presto.Provide<ExampleService>();
        }

        public ExampleService Service { get; private set; }
    }
}