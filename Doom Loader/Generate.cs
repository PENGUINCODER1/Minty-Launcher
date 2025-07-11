﻿namespace Doom_Loader;

internal static class Generate
{
    internal static void Settings(string path)
    {
        File.WriteAllLines($"{path}{ApplicationVariables.SETTINGS_FILE}", 
        [ 
            ApplicationVariables.rpc.ToString(),
            ApplicationVariables.closeOnPlay.ToString(),
            ApplicationVariables.useSourcePortDirectory.ToString(),
            ApplicationVariables.useDefault.ToString(),
            ApplicationVariables.customPreset.ToString(),
            ApplicationVariables.rpcFilesShown.ToString(),
        ]);
    }

    internal static void PortDatabase(string path)
    {
        File.WriteAllText($"{path}{ApplicationVariables.PORTDATABASE_FILE}", 
            "crispy-doom.exe;Crispy Doom\n" +
            "chocolate-doom.exe;Chocolate Doom\n" +
            "minty-doom.exe;Minty Doom\n" +
            "rum-and-raisin-doom.exe;R&&R Doom\n" +
            "pooch.exe;Pooch\n" +
            "prboom.exe;PrBoom\n" +
            "glboom.exe;GLBoom\n" +
            "woof.exe;Woof!\n" +
            "dsda-doom.exe;DSDA-Doom\n" +
            "nugget-doom.exe;Nugget Doom\n" +
            "prboom-plus.exe;PrBoom+\n" +
            "nyan-doom.exe;Nyan Doom\n" +
            "doom.exe;KEX Port\n" +
            "zdoom.exe;ZDoom\n" +
            "gzdoom.exe;GZDoom\n" +
            "lzdoom.exe;LZDoom\n" +
            "vkdoom.exe;VKDoom\n" +
            "zandronum.exe;Zandronum\n" +
            "zdaemon.exe;ZDaemon\n" +
            "odamex.exe;Odamex\n" +
            "doomretro.exe;Doom Retro\n" +
            "EDGE.exe;3DGE/EDGE\n" +
            "Doomsday.exe;Doomsday Engine\n" +
            "eternity.exe;Eternity Engine\n" +
            "inter-doom.exe;International Doom\n" +
            "inter-heretic.exe;International Heretic\n" +
            "inter-hexen.exe;International Hexen" +
            "chocolate-heretic.exe;Chocolate Heretic\n" +
            "chocolate-hexen.exe;Chocolate Hexen\n" +
            "chocolate-strife.exe;Chocolate Strife\n" +
            "crispy-heretic.exe;Crispy Heretic\n" +
            "crispy-hexen.exe;Crispy Hexen\n" +
            "crispy-strife.exe;Crispy Strife");
    }

    internal static void Complevel(string path)
    {
        File.WriteAllText($"{path}{ApplicationVariables.COMPLEVEL_FILE}",
            "Doom v1.9;2\n" +
            "Ultimate Doom;3\n" +
            "Final Doom;4\n" +
            "Boom v2.02;9\n" +
            "MBF;11\n" +
            "MBF21;21\n"
        );
    }
}