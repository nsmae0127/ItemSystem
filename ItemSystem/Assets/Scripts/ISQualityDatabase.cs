using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace BurgZergArcade.ItemSystem
{
    public class ISQualityDatabase : ScriptableObject
    {
        // [SerializeField]
        public List<ISQuality> database = new List<ISQuality>();
    }
}
