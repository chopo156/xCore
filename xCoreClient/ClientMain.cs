﻿using CitizenFX.Core;
using System;
using xCoreClient.main.events;
using xCoreClient.events;

namespace xCoreClient
{
    class ClientMain : BaseScript
    {      
        public ClientMain()
        {          
            EventHandlers["xCore:client:LoadJob"]  += new Action<string, string>(PlayerJobLoaded.playerJobLoaded);
            EventHandlers["xCore:client:keyEvent"] += new Action<int>(playerPushKey.playerKeyEvent);
            EventHandlers["playerSpawned"]         += new Action<dynamic>(playerSpawn.playerSpawned);

            EventHandlers["xCore:client:keyEvent"] += new Action<int>(playerPushKey.playerKeyEvent);          
        }
    }
}