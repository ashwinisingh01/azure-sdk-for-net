// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Image model size. </summary>
    public readonly partial struct ModelSize : IEquatable<ModelSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SmallValue = "Small";
        private const string MediumValue = "Medium";
        private const string LargeValue = "Large";
        private const string ExtraLargeValue = "ExtraLarge";

        /// <summary> No value selected. </summary>
        public static ModelSize None { get; } = new ModelSize(NoneValue);
        /// <summary> Small size. </summary>
        public static ModelSize Small { get; } = new ModelSize(SmallValue);
        /// <summary> Medium size. </summary>
        public static ModelSize Medium { get; } = new ModelSize(MediumValue);
        /// <summary> Large size. </summary>
        public static ModelSize Large { get; } = new ModelSize(LargeValue);
        /// <summary> Extra large size. </summary>
        public static ModelSize ExtraLarge { get; } = new ModelSize(ExtraLargeValue);
        /// <summary> Determines if two <see cref="ModelSize"/> values are the same. </summary>
        public static bool operator ==(ModelSize left, ModelSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelSize"/> values are not the same. </summary>
        public static bool operator !=(ModelSize left, ModelSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelSize"/>. </summary>
        public static implicit operator ModelSize(string value) => new ModelSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
