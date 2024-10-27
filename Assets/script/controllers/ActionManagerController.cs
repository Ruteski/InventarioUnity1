using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManagerController : MonoBehaviour
{
   #region Declaration

   [SerializeField]
   private List<GenericActionScriptable> currentActionList;

   #endregion

   #region Methods

   private void OnEnable() {
      ActionManagerEvent.SendActionListEvent += ReceiveActionList;
   }

   private void OnDisable() {
      ActionManagerEvent.SendActionListEvent -= ReceiveActionList;
   }

   private void ReceiveActionList(List<GenericActionScriptable> actionListReceived) { 
      if (actionListReceived.Count > 0) { 
         currentActionList.AddRange(actionListReceived);

         try {
            while(currentActionList.Count > 0) {
               StopCoroutine(currentActionList[0].Execute());
               StartCoroutine(currentActionList[0].Execute());
               currentActionList.Remove(currentActionList[0]);
            }
         } catch(System.Exception) {

            Debug.LogError("The Action List is empty or missing some action");
         }
      } else {
         Debug.LogWarning("There is NO ACTION inside current Action List");
      }
   }

   #endregion
}
