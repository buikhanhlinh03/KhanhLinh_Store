﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhLinh_Store.UseCase.PluginInterface.StateStore
{
    public interface IStateStore
    {
        void AddStateChangeListeners(Action listeners);
        void RemoveSateChangeListeners(Action listeners);
        void BroadCastStateChange();
    }
}
