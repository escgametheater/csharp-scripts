using UnityEngine;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;

namespace Esc {

	internal class ControllerInterface_mobile : System.Object {

		[DllImport ("__Internal")]
		public static extern int accessWindow ( StringBuilder id, uint idCapacity );

		[DllImport ("__Internal", CharSet = CharSet.Ansi)]
		public static extern int startDocentInterface ( string hostname );

		[DllImport ("__Internal", CharSet = CharSet.Ansi)]
		public static extern int startClientInterface ( string hostname );

		[DllImport ("__Internal")]
		public static extern int stopInterface ();

		[DllImport ("__Internal")]
		public static extern bool isConnected ();
		
		[DllImport ("__Internal")]
		public static extern bool hasMoreEvents ();
		
		// TODO: update this in the plugin to include the StringBuilder buffer capacity input
		[DllImport ("__Internal", CharSet = CharSet.Ansi)]
		public static extern int getNextEvent ( StringBuilder username, uint usernameCapacity, StringBuilder message, uint messageCapacity );
		
		[DllImport ("__Internal")]
		public static extern bool hasMorePresenceEvents ();

		// TODO: update this in the plugin to include the StringBuilder buffer capacity input
		[DllImport ("__Internal", CharSet = CharSet.Ansi)]
		public static extern int getNextPresenceEvent ( StringBuilder username, uint usernameCapacity, out int presence );
		
		[DllImport ("__Internal")]
		public static extern bool hasMoreStatusChanges ();
		
		[DllImport ("__Internal")]
		public static extern int getNextStatusChange ( out int status );

		[DllImport ("__Internal", CharSet = CharSet.Ansi)]
		public static extern int dispatchEvent ( string username, string message );

		[DllImport ("__Internal", CharSet = CharSet.Ansi)]
		public static extern int getUniqueDeviceIdenifier ( StringBuilder id, uint idCapacity );

		[DllImport ("__Internal")]
		public static extern bool isDeviceCharging ();

		[DllImport ("__Internal")]
		public static extern bool isDeviceWifiConnected ();

		[DllImport ("__Internal")]
		public static extern bool dimScreen ();

		[DllImport ("__Internal")]
		public static extern bool brightenScreen ();
	}

}