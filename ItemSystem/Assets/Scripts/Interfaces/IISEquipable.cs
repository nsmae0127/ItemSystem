using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public interface IISEquipable
	{
		ISEquipmentSlot EquipmentSlot { get; }

		// equipSlot
		bool Equip ();
	}
}
