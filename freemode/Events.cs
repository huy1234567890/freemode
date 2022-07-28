using System;
using GTANetworkAPI;

namespace freemode
{
    class Events : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        private void OnPlayerConnected(Player player)
        {
            player.SendChatMessage("Добро пожаловать на ∼c∼PidorasRP!");
        }

        [ServerEvent(Event.PlayerSpawn)]
        private void OnPlayerSpawn(Player player)
        {
            player.Health = 100;
            player.Armor = 0;
        }   
    }
}
