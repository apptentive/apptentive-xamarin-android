//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"apptentive/com/android/core",
						"apptentive/com/android/platform",
					},
					new Converter<string, Type>[]{
						lookup_apptentive_com_android_core_package,
						lookup_apptentive_com_android_platform_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_apptentive_com_android_core_mappings;
		static Type lookup_apptentive_com_android_core_package (string klass)
		{
			if (package_apptentive_com_android_core_mappings == null) {
				package_apptentive_com_android_core_mappings = new string[]{
					"apptentive/com/android/core/AndroidApplicationInfo:ApptentiveCore.AndroidApplicationInfo",
					"apptentive/com/android/core/AndroidExecutorFactoryProvider:ApptentiveCore.AndroidExecutorFactoryProvider",
					"apptentive/com/android/core/AndroidLoggerProvider:ApptentiveCore.AndroidLoggerProvider",
					"apptentive/com/android/core/BehaviorSubject:ApptentiveCore.BehaviorSubject",
					"apptentive/com/android/core/BuildConfig:ApptentiveCore.BuildConfig",
					"apptentive/com/android/core/DefaultTimeSource:ApptentiveCore.DefaultTimeSource",
					"apptentive/com/android/core/DependencyProvider:ApptentiveCore.DependencyProvider",
					"apptentive/com/android/core/ExecutorFactory$DefaultImpls:ApptentiveCore.ExecutorFactoryDefaultImpls",
					"apptentive/com/android/core/Observable:ApptentiveCore.Observable",
					"apptentive/com/android/core/TypeAliasesKt:ApptentiveCore.TypeAliasesKt",
				};
			}

			return Lookup (package_apptentive_com_android_core_mappings, klass);
		}

		static string[] package_apptentive_com_android_platform_mappings;
		static Type lookup_apptentive_com_android_platform_package (string klass)
		{
			if (package_apptentive_com_android_platform_mappings == null) {
				package_apptentive_com_android_platform_mappings = new string[]{
					"apptentive/com/android/platform/AndroidSharedPrefDataStore$DefaultImpls:Apptentive.Com.Android.Platform.AndroidSharedPrefDataStoreDefaultImpls",
				};
			}

			return Lookup (package_apptentive_com_android_platform_mappings, klass);
		}
	}
}
