using CommandSystem.Commands.RemoteAdmin.Decontamination;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using Exiled.Loader;
using Exiled.Events;
using MoreCandies;
using Player = Exiled.Events.Handlers.Player;
using Exiled.Events;
using Exiled.Events.Handlers;
#pragma warning disable CS8618

internal class Plugin : Plugin<Config>
{

    public override string Author => "Tiliboyy";
    public override string Name => "MoreCandies";

    public override string Prefix => "MoreCandies";
    public override Version Version => new(1, 0, 0);
    public override Version RequiredExiledVersion => new(5, 0, 0, 0);

    public EventHandlers EventHandler;

    public static Plugin Instance;

    public override void OnEnabled()
    {
        Instance = this;
        EventHandler = new EventHandlers();
        Scp330.InteractingScp330 += EventHandlers.OnTakingCandie;
    }




    public override void OnDisabled()
    {
        Instance = null;
        Scp330.InteractingScp330 -= EventHandlers.OnTakingCandie;

    }

}
