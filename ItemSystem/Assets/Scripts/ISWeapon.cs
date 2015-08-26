using UnityEditor;
using UnityEngine;
using System.Collections;
using System;

namespace BurgZergArcade.ItemSystem
{
	[System.Serializable]
	public class ISWeapon : ISObject, IISWeapon, IISDestructable, IISEquipable, IISGameObject
	{
		[SerializeField] int _minDamage;
		[SerializeField] int _durability;
		[SerializeField] int _maxDurability;
		[SerializeField] ISEquipmentSlot _equipmentSlot;
		[SerializeField] GameObject _prefab;

		public ISWeapon ()
		{
			_equipmentSlot = new ISEquipmentSlot ();
		}

		public ISWeapon (int durability, int maxDurability, ISEquipmentSlot equipmentSlot, GameObject prefab)
		{
			_durability = durability;
			_maxDurability = maxDurability;
			_equipmentSlot = equipmentSlot;
			_prefab = prefab;
		}

		public int Durability {
			get {
				return _durability;
			}
		}

		public int MaxDurability {
			get {
				return _maxDurability;
			}
		}

		public int MinDamage {
			get {
				return _minDamage;
			}
			set {
				_minDamage = value;
			}
		}

		public ISEquipmentSlot EquipmentSlot {
			get {
				return _equipmentSlot;
			}
		}

		public GameObject Prefab {
			get {
				return _prefab;
			}
		}

		public int Attack ()
		{
			throw new NotImplementedException ();
		}

		// reduce the durability to
		// not sure what to do with method
		public void Break ()
		{
			_durability = 0;
		}

		public void Repair ()
		{
			_maxDurability--;

			if (_maxDurability > 0)
				_durability = _maxDurability;
		}

		public void TakeDamage (int amount)
		{
			_durability -= amount;

			if (_durability < 0)
				_durability = 0;

			if (_durability == 0)
				Break ();
		}

		public bool Equip ()
		{
			throw new NotImplementedException ();
		}

		// This code will go to a new script later on
		public override void OnGUI ()
		{
			base.OnGUI ();

			_minDamage = System.Convert.ToInt32 (EditorGUILayout.TextField ("Damage", _minDamage.ToString ()));
			_durability = System.Convert.ToInt32 (EditorGUILayout.TextField ("Durability", _durability.ToString ()));
			_maxDurability = System.Convert.ToInt32 (EditorGUILayout.TextField ("Max Durability", _maxDurability.ToString ()));

			DisplayEquipmentSlot ();
			DisplayPrefab ();
		}

		public void DisplayEquipmentSlot ()
		{
			GUILayout.Label ("Equipment Slot");
		}

		public void DisplayPrefab ()
		{
			GUILayout.Label ("Prefab");
		}
	}
}