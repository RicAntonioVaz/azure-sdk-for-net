// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> LedgerRole associated with the Security Principal of Ledger. </summary>
    public readonly partial struct ConfidentialLedgerRoleName : IEquatable<ConfidentialLedgerRoleName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfidentialLedgerRoleName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfidentialLedgerRoleName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReaderValue = "Reader";
        private const string ContributorValue = "Contributor";
        private const string AdministratorValue = "Administrator";

        /// <summary> Reader. </summary>
        public static ConfidentialLedgerRoleName Reader { get; } = new ConfidentialLedgerRoleName(ReaderValue);
        /// <summary> Contributor. </summary>
        public static ConfidentialLedgerRoleName Contributor { get; } = new ConfidentialLedgerRoleName(ContributorValue);
        /// <summary> Administrator. </summary>
        public static ConfidentialLedgerRoleName Administrator { get; } = new ConfidentialLedgerRoleName(AdministratorValue);
        /// <summary> Determines if two <see cref="ConfidentialLedgerRoleName"/> values are the same. </summary>
        public static bool operator ==(ConfidentialLedgerRoleName left, ConfidentialLedgerRoleName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfidentialLedgerRoleName"/> values are not the same. </summary>
        public static bool operator !=(ConfidentialLedgerRoleName left, ConfidentialLedgerRoleName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConfidentialLedgerRoleName"/>. </summary>
        public static implicit operator ConfidentialLedgerRoleName(string value) => new ConfidentialLedgerRoleName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfidentialLedgerRoleName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfidentialLedgerRoleName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
