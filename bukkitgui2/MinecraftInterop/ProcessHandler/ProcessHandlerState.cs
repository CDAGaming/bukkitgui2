﻿using System;

namespace Bukkitgui2.MinecraftInterop.ProcessHandler
{
	internal static class ProcessHandlerState
	{
		public static MinecraftServers.IMinecraftServer CurrentServer;
		public static Boolean IsRunning = false;
		public static IProcessHandler ProcessHandler ;
	}
}