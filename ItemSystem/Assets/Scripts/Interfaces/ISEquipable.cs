using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
    public interface ISEquipable
    {
        ISEquipmentSlot EquipmentSlot
        {
            get;
        }
        bool Equip();
    }
}
