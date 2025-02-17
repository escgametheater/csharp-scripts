﻿using UnityEngine;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;

namespace Esc {

	internal class ControllerInterface_desktop : System.Object {

		[DllImport ("ESC-Unity-Plugin")]
		public static extern int accessWindow ( StringBuilder id, uint idCapacity );

		[DllImport ("ESC-Unity-Plugin", CharSet = CharSet.Ansi)]
		public static extern int startDocentInterface ( string hostname );
		
		[DllImport ("ESC-Unity-Plugin", CharSet = CharSet.Ansi)]
		public static extern int startClientInterface ( string hostname );
		
		[DllImport ("ESC-Unity-Plugin")]
		public static extern int stopInterface ();
		
		[DllImport ("ESC-Unity-Plugin")]
		public static extern bool isConnected ();
		
		[DllImport ("ESC-Unity-Plugin")]
		public static extern bool hasMoreEvents ();

		// TODO: update this in the plugin to include the StringBuilder buffer capacity input
		[DllImport ("ESC-Unity-Plugin", CharSet = CharSet.Ansi)]
		public static extern int getNextEvent ( StringBuilder username, uint usernameCapacity, StringBuilder message, uint messageCapacity );
		
		[DllImport ("ESC-Unity-Plugin")]
		public static extern bool hasMorePresenceEvents ();

		// TODO: update this in the plugin to include the StringBuilder buffer capacity input
		[DllImport ("ESC-Unity-Plugin", CharSet = CharSet.Ansi)]
		public static extern int getNextPresenceEvent ( StringBuilder username, uint usernameCapacity, out int presence );
		
		[DllImport ("ESC-Unity-Plugin")]
		public static extern bool hasMoreStatusChanges ();
		
		[DllImport ("ESC-Unity-Plugin")]
		public static extern int getNextStatusChange ( out int status );

		[DllImport ("ESC-Unity-Plugin", CharSet = CharSet.Ansi)]
		public static extern int dispatchEvent ( string username, string message );

		[DllImport ("ESC-Unity-Plugin")]
		public static extern int getUniqueDeviceIdenifier ( StringBuilder id, uint idCapacity );
	}

}