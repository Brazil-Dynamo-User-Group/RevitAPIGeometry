using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;

namespace RevitAPIGeometry
{
    /// <summary>
    /// GeometryUtils
    /// </summary>
    public static class GeometryUtils
    {
        /// <summary>
        /// HasGeometry on the <paramref name="element"/>
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool HasGeometry(this Element element)
        {
            return element.get_Geometry(new Options()) != null;
        }
    }
}