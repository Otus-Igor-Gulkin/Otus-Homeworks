using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Core.Types
{
    public interface IObservable<TObserver> where TObserver : IObserver
    {
        IEnumerable<TObserver> Observers { get; }
        void Add(TObserver observer);
        void Remove(TObserver observer);
    }
}
