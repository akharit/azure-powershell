// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Properties for the task that validates the connection to and provides
    /// information about a MongoDB server
    /// </summary>
    [Newtonsoft.Json.JsonObject("Connect.MongoDb")]
    public partial class ConnectToMongoDbTaskProperties : ProjectTaskProperties
    {
        /// <summary>
        /// Initializes a new instance of the ConnectToMongoDbTaskProperties class.
        /// </summary>
        public ConnectToMongoDbTaskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectToMongoDbTaskProperties class.
        /// </summary>

        /// <param name="errors">Array of errors. This is ignored if submitted.
        /// </param>

        /// <param name="state">The state of the task. This is ignored if submitted.
        /// Possible values include: &#39;Unknown&#39;, &#39;Queued&#39;, &#39;Running&#39;, &#39;Canceled&#39;,
        /// &#39;Succeeded&#39;, &#39;Failed&#39;, &#39;FailedInputValidation&#39;, &#39;Faulted&#39;</param>

        /// <param name="commands">Array of command properties.
        /// </param>

        /// <param name="clientData">Key value pairs of client data to attach meta data information to task
        /// </param>

        /// <param name="input">Describes a connection to a MongoDB data source
        /// </param>

        /// <param name="output">An array containing a single MongoDbClusterInfo object
        /// </param>
        public ConnectToMongoDbTaskProperties(System.Collections.Generic.IList<ODataError> errors = default(System.Collections.Generic.IList<ODataError>), string state = default(string), System.Collections.Generic.IList<CommandProperties> commands = default(System.Collections.Generic.IList<CommandProperties>), System.Collections.Generic.IDictionary<string, string> clientData = default(System.Collections.Generic.IDictionary<string, string>), MongoDbConnectionInfo input = default(MongoDbConnectionInfo), System.Collections.Generic.IList<MongoDbClusterInfo> output = default(System.Collections.Generic.IList<MongoDbClusterInfo>))

        : base(errors, state, commands, clientData)
        {
            this.Input = input;
            this.Output = output;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets describes a connection to a MongoDB data source
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "input")]
        public MongoDbConnectionInfo Input {get; set; }

        /// <summary>
        /// Gets an array containing a single MongoDbClusterInfo object
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "output")]
        public System.Collections.Generic.IList<MongoDbClusterInfo> Output {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Input != null)
            {
                this.Input.Validate();
            }
            if (this.Output != null)
            {
                foreach (var element in this.Output)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}