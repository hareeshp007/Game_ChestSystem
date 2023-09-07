using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace ChestSystem.Chest
{
    public interface IChestStates 
    {

        public void OnStateEnable();
        public void OnStateDisable();
        public ChestStates GetState();
        public void ChestButtonAction();

        public int GetRequiredGemsToUnlock();
    }
}

