﻿using System.ComponentModel;
using System.Configuration;
using UmbracoTestProject.Common.Extensions;

namespace UmbracoTestProject.Common
{
	/// <summary>
	/// Enables access to application settings, stored in App.config or Web.config 'appSettings' section.
	/// </summary>
	public static class AppSettings
	{
		public static bool DisableHttpCompression => Get<bool>("disableHttpCompression", false);
		public static string XMLSitemapRouteUrl => Get<string>("xmlSitemapRouteUrl", "xmlsitemap");

		/// <summary>
		/// Retrieves configuration value associated with given <paramref name="key"/>.
		/// </summary>
		/// <typeparam name="T">Configuration value type.</typeparam>
		/// <param name="key">Configuration key.</param>
		/// <returns>Configuration value associated with given <paramref name="key"/>.</returns>
		public static T Get<T>(string key)
		{
			string setting = ConfigurationManager.AppSettings[key];
			if (setting.IsNullOrWhiteSpace())
			{
				throw new ConfigurationErrorsException($"Key '{key}' not found in the configuration file!");
			}

			return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(setting);
		}

		/// <summary>
		/// Retrieves configuration value associated with given <paramref name="key"/>.
		/// If value for given <paramref name="key"/> is not found, <paramref name="defaultValue"/> is returned.
		/// </summary>
		/// <typeparam name="T">Configuration value type.</typeparam>
		/// <param name="key">Configuration key.</param>
		/// <param name="defaultValue">Default value.</param>
		/// <returns>Configuration value associated with given <paramref name="key"/>, or <paramref name="defaultValue"/> if given <paramref name="key"/> is not found.</returns>
		public static T Get<T>(string key, T defaultValue)
		{
			string setting = ConfigurationManager.AppSettings[key];
			if (setting.IsNullOrWhiteSpace())
			{
				return defaultValue;
			}

			return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromInvariantString(setting);
		}
	}
}
