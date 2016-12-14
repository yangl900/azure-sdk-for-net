// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resource.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Subscription list operation response.
    /// </summary>
    public partial class SubscriptionListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionListResultInner
        /// class.
        /// </summary>
        public SubscriptionListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the SubscriptionListResultInner
        /// class.
        /// </summary>
        /// <param name="nextLink">Gets or sets the URL to get the next set of
        /// results.</param>
        /// <param name="value">Gets or sets subscriptions.</param>
        public SubscriptionListResultInner(string nextLink, System.Collections.Generic.IList<SubscriptionInner> value = default(System.Collections.Generic.IList<SubscriptionInner>))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets subscriptions.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<SubscriptionInner> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to get the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NextLink == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "NextLink");
            }
        }
    }
}