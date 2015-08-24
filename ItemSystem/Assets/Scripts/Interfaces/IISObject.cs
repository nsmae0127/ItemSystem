using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
    public interface IISObject
    {
        // name
        // value - gold value
        // icon
        // burden
        // qualitylevel
        string Name
        {
            get;
            set;
        }
        int Value
        {
            get;
            set;
        }
        Sprite Icon
        {
            get;
            set;
        }
        int Burden
        {
            set;
            get;
        }
        ISQuality Quality
        {
            get;
            set;
        }

        // these got to other item interfaces
        // equip
        // questItem flag
        // prefab
    }
}
