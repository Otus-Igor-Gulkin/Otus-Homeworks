using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Core.Types
{
    public interface IObservable<T> where T : IObserver
    {
        IEnumerable<T> Observers { get; }
        void Add(T observer);
        void Remove(T observer);
    }
}
