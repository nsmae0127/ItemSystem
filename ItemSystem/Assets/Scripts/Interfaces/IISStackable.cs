using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem
{
	public interface IISStackable
	{
		int MaxStack {
			get;
		}

		int StackSize (int amount);
		// default value of 0
	}
}
