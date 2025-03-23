using System;

using F10Y.T0000;


namespace F10Y.T0009.N001
{
    /// <summary>
    /// <inheritdoc cref="T0009.HasXMarkerAttribute" path="/summary"/>
    /// <para>
    /// But, in cases where there are multiple attribtues, this attribute allows specifying both the name and type of X property.
    /// </para>
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="T0009.HasXMarkerAttribute" path="/remarks"/>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // HasX types are always interfaces (with a companion dummy implementation class).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class HasXMarkerAttribute : Attribute
    {
        /// <inheritdoc cref="T0009.HasXMarkerAttribute.IsIHasX"/>
        public bool IsIHasX { get; }

        public Type TypeOfX { get; }

        public string NameOfX { get; }


        public HasXMarkerAttribute(
            Type typeOfX,
            string nameOfX,
            bool isIHasX = true)
        {
            this.TypeOfX = typeOfX;
            this.NameOfX = nameOfX;
            this.IsIHasX = isIHasX;
        }
    }
}
