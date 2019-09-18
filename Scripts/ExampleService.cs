using System;
using UnityEngine;

namespace Bonwerk.Injection
{
    public class ExampleService : MonoBehaviour, IProvider
    {
        private void Awake()
        {
            Presto.Bind<ExampleService>(this);
        }
        
        public object Provide()
        {
            return this;
        }
    }
}