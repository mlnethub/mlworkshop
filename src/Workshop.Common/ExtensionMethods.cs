// This project is licensed under the MPL 2.0 license.
// See the LICENSE file in the project root for more information.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop.Common
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Provides an easy method to return all of properties in a class
        /// except the label.
        /// </summary>
        /// <typeparam name="T">class</typeparam>
        /// <param name="objType">object type</param>
        /// <param name="labelName">label name</param>
        /// <returns>list of names</returns>
        public static IEnumerator<string> ToPropertyList<T>(this Type objType, string labelName) => objType.GetProperties()
            .Where(a => a.Name != labelName)
            .Select(a => a.Name)
            .GetEnumerator();
    }
}
