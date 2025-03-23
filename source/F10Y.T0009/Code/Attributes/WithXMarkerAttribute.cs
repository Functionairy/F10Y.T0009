using System;

using F10Y.T0000;


namespace F10Y.T0009
{
    /// <summary>
    /// Attribute indicating an interface type is an IWithX type.
    /// IWithX interfaces should only have a single property with both a getter and setter, and inherit from a complementary IHasX interface type.
    /// The property of the IWithX interface should have the same name as the property of the complementary IHaxX interface,
    /// and thus should be declared with the "new" modifier.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of IWithX types.
    /// </remarks>
    /// <seealso cref="N001.WithXMarkerAttribute"/>
    [AttributeUsage(AttributeTargets.Interface, // HasX types are always interfaces (with a companion dummy implementation class).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class WithXMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* an IWithX type.
        /// This is useful for marking types that end up canonical IWithX type code file locations, but are not actually IWithX types.
        /// </summary>
        public bool IsIWithX { get; }


        public WithXMarkerAttribute(
            bool isIWithX = true)
        {
            this.IsIWithX = isIWithX;
        }
    }
}
