﻿using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
#if UNITY_EDITOR
using UnityEditor;
#endif // UNITY_EDITOR

namespace Ist
{
    public abstract class IAndReceiver : GroupedInstanceSet<IAndReceiver>
    {
        void OnWillRenderObject()
        {
            Singleton<AndRenderer>.GetInstance()._OnWillRenderObject();
        }

        void OnPostRender()
        {
            Singleton<AndRenderer>.GetInstance()._OnPostRender();
        }

        public abstract void IssueDrawCall_FrontDepth(AndRenderer br, CommandBuffer cb);
        public abstract void IssueDrawCall_BackDepth(AndRenderer br, CommandBuffer cb);
    }
}