// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlotLength.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Represents absolute or relative lengths in data or screen space.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot
{
    /// <summary>
    /// Represents absolute or relative lengths in data or screen space.
    /// </summary>
    public struct PlotLength
    {
        /// <summary>
        /// The unit type
        /// </summary>
        private readonly PlotLengthUnit unit;

        /// <summary>
        /// The value
        /// </summary>
        private readonly double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlotLength" /> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="unit">The unit.</param>
        public PlotLength(double value, PlotLengthUnit unit)
        {
            this.value = value;
            this.unit = unit;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        public double Value
        {
            get
            {
                return this.value;
            }
        }

        /// <summary>
        /// Gets the type of the unit.
        /// </summary>
        /// <value>The type of the unit.</value>
        public PlotLengthUnit Unit
        {
            get
            {
                return this.unit;
            }
        }

        public bool Equals(PlotLength other)
        {
            return unit == other.unit && value.Equals(other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is PlotLength && Equals((PlotLength) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) unit*397) ^ value.GetHashCode();
            }
        }
    }
}