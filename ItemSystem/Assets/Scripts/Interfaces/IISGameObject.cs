using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
    public interface ISGameObject
    {
        ISGameObject Prefab
        {
            get;
            set;
        }
    }
}