// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.NotificationHubs.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.NotificationHubs;
    using Microsoft.Azure.Management.NotificationHubs.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of a NotificationHub MpnsCredential.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MpnsCredential
    {
        /// <summary>
        /// Initializes a new instance of the MpnsCredential class.
        /// </summary>
        public MpnsCredential()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MpnsCredential class.
        /// </summary>
        /// <param name="mpnsCertificate">The MPNS certificate.</param>
        /// <param name="certificateKey">The certificate key for this
        /// credential.</param>
        /// <param name="thumbprint">The Mpns certificate Thumbprint</param>
        public MpnsCredential(string mpnsCertificate = default(string), string certificateKey = default(string), string thumbprint = default(string))
        {
            MpnsCertificate = mpnsCertificate;
            CertificateKey = certificateKey;
            Thumbprint = thumbprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the MPNS certificate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mpnsCertificate")]
        public string MpnsCertificate { get; set; }

        /// <summary>
        /// Gets or sets the certificate key for this credential.
        /// </summary>
        [JsonProperty(PropertyName = "properties.certificateKey")]
        public string CertificateKey { get; set; }

        /// <summary>
        /// Gets or sets the Mpns certificate Thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "properties.thumbprint")]
        public string Thumbprint { get; set; }

    }
}