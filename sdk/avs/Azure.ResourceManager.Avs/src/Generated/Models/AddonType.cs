// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The type of private cloud addon. </summary>
    internal readonly partial struct AddonType : IEquatable<AddonType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AddonType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AddonType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SRMValue = "SRM";
        private const string VRValue = "VR";
        private const string HCXValue = "HCX";

        /// <summary> SRM. </summary>
        public static AddonType SRM { get; } = new AddonType(SRMValue);
        /// <summary> VR. </summary>
        public static AddonType VR { get; } = new AddonType(VRValue);
        /// <summary> HCX. </summary>
        public static AddonType HCX { get; } = new AddonType(HCXValue);
        /// <summary> Determines if two <see cref="AddonType"/> values are the same. </summary>
        public static bool operator ==(AddonType left, AddonType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AddonType"/> values are not the same. </summary>
        public static bool operator !=(AddonType left, AddonType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AddonType"/>. </summary>
        public static implicit operator AddonType(string value) => new AddonType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AddonType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AddonType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
