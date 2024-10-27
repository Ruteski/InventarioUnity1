using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericItemScriptable : ScriptableObject
{
   #region Declarations
   [SerializeField]
   private int id;

   [SerializeField]
   private Sprite icon;

   [SerializeField]
   private bool isDroppable;

   [SerializeField]
   private bool removeWhenNumberisZero;

   [SerializeField]
   private bool isOnlyItem; // define se o item no inventario var ser unico ou pode ter mais dele ali no slot

   [SerializeField]
   private string label;

   [SerializeField]
   [TextArea]
   private string description;

   [SerializeField]
   private int currentNumber;

   [SerializeField]
   private int limitedNumber;

   [SerializeField]
   private int slotSize = 1;

   [SerializeField]
   private float weigthPerItem;

   [SerializeField]
   private float totalWeigthPerItem;

   /*
   [SerializeField]
   private ActionManagerEvent actionManagerEvent;

   protected ActionManagerEvent actionManagerEvent;
   */
   #endregion

   #region Getters and Setters

   public int Id { get => id; }

   public Sprite Icon { get => icon; }

   public bool IsDroppable { get => isDroppable; }

   public bool RemoveWhenNumberisZero { get => removeWhenNumberisZero; }

   public bool IsOnlyItem { get => isOnlyItem; }

   public string Label { get => label; }

   public string Description { get => description; }

   public int CurrentNumber { get => currentNumber; }

   public int LimitedNumber { get => limitedNumber; }

   public int SlotSize { get => slotSize; }

   public float WeigthPerItem { get => weigthPerItem; }

   public float TotalWeigthPerItem { 
      get {
         UpdateWeigth();
         return totalWeigthPerItem;
      }
   }

   #endregion

   #region Methods

   private void UpdateWeigth() {
      totalWeigthPerItem = weigthPerItem * currentNumber;
   }

   #endregion
}
