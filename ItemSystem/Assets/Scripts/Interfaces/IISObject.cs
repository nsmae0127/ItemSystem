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
        string ISName
        {
            get;
            set;
        }
        int ISValue
        {
            get;
            set;
        }
        Sprite ISIcon
        {
            get;
            set;
        }
        int ISBurden
        {
            set;
            get;
        }
        ISQuality ISQuality
        {
            get;
            set;
        }

        // these got to other item interfaces
        // equip
        //questItem flag
        // durability
        // takedamage
        // prefab
    }
}
