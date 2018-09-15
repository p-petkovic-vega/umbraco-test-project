using System.Web.Mvc;
using UmbracoTestProject.Common.Extensions;

namespace UmbracoTestProject.Web.Extensions
{
	/// <summary>
	/// <see cref="string"/> extension methods.
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Returns <paramref name="controllerName"/> string after stripping "Controller" suffix from it.
		/// </summary>
		/// <param name="controllerName">The name of the controller class.</param>
		/// <returns>Name without "Controller" suffix.</returns>
		public static string RemoveControllerSuffix(this string controllerName)
		{
			return controllerName.RemoveSuffix(nameof(Controller));
		}
	}
}
