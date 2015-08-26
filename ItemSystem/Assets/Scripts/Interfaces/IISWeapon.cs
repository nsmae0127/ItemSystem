using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
    public interface IISWeapon
    {
        int MinDamage
        {
            get;
            set;
        }

        int Attack();
    }
}