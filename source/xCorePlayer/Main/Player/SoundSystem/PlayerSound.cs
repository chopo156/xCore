﻿using System;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using Newtonsoft.Json;
using xCorePlayer;

namespace xCoreClient.Main.Player.SoundSystem
{
    public class PlayerSound : BaseScript
    {
        public static void Distance(string name_, int distance_)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "distance",
                name = name_,
                distance = distance_,
            });
            API.SendNuiMessage(json);
        }

        public static void PLayUrl(string name_, string url_, float volume_)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "url",
                name = name_,
                url = url_,
                x = 0,
                y = 0,
                z = 0,
                dynamic = false,
                volume = volume_,
            });
            API.SendNuiMessage(json);
        }

        public static void PLayUrl(string name_,string url_, float volume_, Vector3 pos)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "url",
                name = name_,
                url = url_,
                x = pos.X,
                y = pos.Y,
                z = pos.Z,
                dynamic = true,
                volume = volume_,
            });
            API.SendNuiMessage(json);
        }

        public static void Play(string name_, float volume_, Vector3 pos)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "play",
                name = name_,
                x = pos.X,
                y = pos.Y,
                z = pos.Z,
                dynamic = true,
                volume = volume_,
            });
            API.SendNuiMessage(json);
        }

        public static void Play(string name_,float volume_)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "play",
                name = name_,
                x = 0,
                y = 0,
                z = 0,
                dynamic = false,
                volume = volume_,
            });
            API.SendNuiMessage(json);
        }

        public static void Position(string name_, Vector3 pos)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "soundPosition",
                name = name_,
                x = pos.X,
                y = pos.Y,
                z = pos.Z,
            });
            API.SendNuiMessage(json);
        }

        public static void Stop(string name_)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "delete",
                name = name_
            });
            API.SendNuiMessage(json);
        }

        public static void Resume(string name_)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "resume",
                name = name_,
            });
            API.SendNuiMessage(json);
        }

        public static void Pause(string name_)
        {
            string json = JsonConvert.SerializeObject(new
            {
                status = "pause",
                name = name_,
            });
            API.SendNuiMessage(json);
        }
    }
}
