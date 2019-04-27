using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinityScript;

public class InfectedSplash : BaseScript
{

    public override void OnPlayerDisconnect(Entity player)
    {
        int teamPlayers = GSCFunctions.GetTeamPlayersAlive("axis");
        if (player.SessionTeam == "axis" && teamPlayers == 0)
        {
            teamSplash("callout_deserted", player);
        }
    }
    public static void teamSplash(string splash, Entity player)
    {
        foreach (Entity players in Players)
        {
            if (!players.IsPlayer) continue;
            players.SetCardDisplaySlot(player, 5);
            players.ShowHudSplash(splash, 1);
        }
    }
}
