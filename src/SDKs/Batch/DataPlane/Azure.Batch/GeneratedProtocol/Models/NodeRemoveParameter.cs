// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Options for removing compute nodes from a pool.
    /// </summary>
    public partial class NodeRemoveParameter
    {
        /// <summary>
        /// Initializes a new instance of the NodeRemoveParameter class.
        /// </summary>
        public NodeRemoveParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeRemoveParameter class.
        /// </summary>
        /// <param name="nodeList">A list containing the IDs of the compute
        /// nodes to be removed from the specified pool.</param>
        /// <param name="resizeTimeout">The timeout for removal of compute
        /// nodes to the pool.</param>
        /// <param name="nodeDeallocationOption">Determines what to do with a
        /// node and its running task(s) after it has been selected for
        /// deallocation.</param>
        public NodeRemoveParameter(IList<string> nodeList, System.TimeSpan? resizeTimeout = default(System.TimeSpan?), ComputeNodeDeallocationOption? nodeDeallocationOption = default(ComputeNodeDeallocationOption?))
        {
            NodeList = nodeList;
            ResizeTimeout = resizeTimeout;
            NodeDeallocationOption = nodeDeallocationOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list containing the IDs of the compute nodes to be
        /// removed from the specified pool.
        /// </summary>
        [JsonProperty(PropertyName = "nodeList")]
        public IList<string> NodeList { get; set; }

        /// <summary>
        /// Gets or sets the timeout for removal of compute nodes to the pool.
        /// </summary>
        /// <remarks>
        /// The default value is 15 minutes. The minimum value is 5 minutes. If
        /// you specify a value less than 5 minutes, the Batch service returns
        /// an error; if you are calling the REST API directly, the HTTP status
        /// code is 400 (Bad Request).
        /// </remarks>
        [JsonProperty(PropertyName = "resizeTimeout")]
        public System.TimeSpan? ResizeTimeout { get; set; }

        /// <summary>
        /// Gets or sets determines what to do with a node and its running
        /// task(s) after it has been selected for deallocation.
        /// </summary>
        /// <remarks>
        /// The default value is requeue. Possible values include: 'requeue',
        /// 'terminate', 'taskCompletion', 'retainedData'
        /// </remarks>
        [JsonProperty(PropertyName = "nodeDeallocationOption")]
        public ComputeNodeDeallocationOption? NodeDeallocationOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NodeList == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NodeList");
            }
            if (NodeList != null)
            {
                if (NodeList.Count > 100)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "NodeList", 100);
                }
            }
        }
    }
}