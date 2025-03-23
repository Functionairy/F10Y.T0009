using System;

using F10Y.T0000;


namespace F10Y.T0009
{
    /// <summary>
    /// Attribute indicating an interface type is an IHasX type.
    /// IHasX interfaces should only have a single property with a only a getter, but with freedom to choose the property name.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of IHasX types.
    /// </remarks>
    /// <seealso cref="N001.HasXMarkerAttribute"/>
    [AttributeUsage(AttributeTargets.Interface, // HasX types are always interfaces (with a companion dummy implementation class).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
        )]
    [MarkerAttributeMarker]
    public class HasXMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* an IHasX type.
        /// This is useful for marking types that end up canonical IHasX type code file locations, but are not actually IHasX types.
        /// </summary>
        public bool IsIHasX { get; }


        public HasXMarkerAttribute(
            bool isIHasX = true)
        {
            this.IsIHasX = isIHasX;
        }
    }
}
