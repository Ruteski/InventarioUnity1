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

}
