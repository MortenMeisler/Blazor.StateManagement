using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.StateManager.Services
{
    public class StateManager<T> : IStateManager<T> where T : class, new()
    {
        public T Model { get; set; }
        public StateManager()
        {
            //equivalent of doing new T(), but with improvements: See:
            //https://devblogs.microsoft.com/premier-developer/dissecting-the-new-constraint-in-c-a-perfect-example-of-a-leaky-abstraction/
            Model = Activator.CreateInstance<T>();
        }
    }
}
