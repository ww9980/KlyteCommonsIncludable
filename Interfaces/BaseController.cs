﻿using ColossalFramework.UI;
using UnityEngine;

namespace Klyte.Commons.Interfaces
{
    public class BaseController<U, C> : MonoBehaviour
        where U : BasicIUserModSimplified<U, C>, new()
        where C : BaseController<U, C>
    {
        public void Start()
        {
            StartActions();
            BasicIUserModSimplified<U, C>.Instance.ShowVersionInfoPopup();
            BasicIUserModSimplified<U, C>.Instance.SearchIncompatibilitiesModal();
        }

        protected virtual void StartActions() { }
    }
}