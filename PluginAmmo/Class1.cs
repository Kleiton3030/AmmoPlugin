using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Features.Items;
using Exiled.API.Interfaces;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using InventorySystem.Items.Armor;
using Exiled.API.Structs;
using System.Linq;
using System.Data;
using Exiled.CustomItems.API.Features;
using InventorySystem.Items;
using Exiled.Permissions.Commands.Permissions;
using YamlDotNet.Core;
namespace AmmoPlugin
{
    public class Plugin : Plugin<Config>
    {
    


        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Spawned += OnPlayerSpawned;
            Log.Info("AmmoPlugin está habilitado.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= OnPlayerSpawned;
            Log.Info("AmmoPlugin está deshabilitado.");
            base.OnDisabled();
        }
        private void OnPlayerSpawned(SpawnedEventArgs ev)
        {
            //Agrega municiones a las clases
            if (ev.Player.Role.Type == RoleTypeId.ClassD) 
            {
                ev.Player.AddAmmo(AmmoType.Nato9, 20);
            }
            else if (ev.Player.Role.Type == RoleTypeId.Scientist)
            {
                ev.Player.AddAmmo(AmmoType.Nato9, 20);
            }
            else if (ev.Player.Role.Type == RoleTypeId.FacilityGuard)
            {
                ev.Player.AddAmmo(AmmoType.Nato9, 30);
            }
            else if (ev.Player.Role.Type == RoleTypeId.NtfCaptain)
            {
                ev.Player.AddAmmo(AmmoType.Nato556, 35);
            }
            else if (ev.Player.Role.Type == RoleTypeId.NtfSergeant)
            {
                ev.Player.AddAmmo(AmmoType.Nato556, 35);
            }
            else if (ev.Player.Role.Type == RoleTypeId.NtfPrivate)
            {
                ev.Player.AddAmmo(AmmoType.Nato9, 30);
            }
            else if (ev.Player.Role.Type == RoleTypeId.NtfSpecialist)
            {
                ev.Player.AddAmmo(AmmoType.Nato556, 35);
            }
            else if (ev.Player.Role.Type == RoleTypeId.ChaosRifleman)
            {
                ev.Player.AddAmmo(AmmoType.Nato762, 35);
                ev.Player.AddAmmo(AmmoType.Ammo44Cal, 12);
            }
            else if (ev.Player.Role.Type == RoleTypeId.ChaosRepressor)
            {
                ev.Player.AddAmmo(AmmoType.Nato762, 35);
                ev.Player.AddAmmo(AmmoType.Ammo44Cal, 12);
            }
            else if (ev.Player.Role.Type == RoleTypeId.ChaosMarauder)
            {
                ev.Player.AddAmmo(AmmoType.Ammo44Cal, 12);
                ev.Player.AddAmmo(AmmoType.Ammo12Gauge, 12);
            }
            else if (ev.Player.Role.Type == RoleTypeId.ChaosConscript)
            {
                ev.Player.AddAmmo(AmmoType.Nato762, 30);
                ev.Player.AddAmmo(AmmoType.Ammo44Cal, 12);
            }
         

            
        }
        

   }


}


public class Config : IConfig
{
    public bool IsEnabled { get; set; } = true;
    public bool Debug { get; set; } = false;
}

