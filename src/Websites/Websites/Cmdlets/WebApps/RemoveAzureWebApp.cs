﻿
// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Management.Automation;
using Microsoft.Azure.Commands.WebApps.Properties;

namespace Microsoft.Azure.Commands.WebApps.Cmdlets.WebApps
{
    /// <summary>
    /// this commandlet will let you delete an Azure web app
    /// </summary>
    [Cmdlet("Remove", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "WebApp", SupportsShouldProcess = true), OutputType(typeof(void))]
    public class RemoveAzureWebAppCmdlet : WebAppBaseCmdlet
    {

        //always delete the slots, 
        private bool deleteSlotsByDefault = true;        

        //always delete the metrics
        private bool deleteMetricsByDefault = true;

        [Parameter(Mandatory = false, HelpMessage = "If this is the last app in the App Service plan. Delete this App Service plan to prevent unexpected charges.")]
        public SwitchParameter DeleteAppServicePlan { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Forces the command to run without asking for user confirmation.")]
        public SwitchParameter Force { get; set; }

         [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.RemoveWebsiteWarning, Name),
                Properties.Resources.RemoveWebsiteMessage,
                Name,
                () =>
                {
                    WebsitesClient.RemoveWebApp(ResourceGroupName, Name, null, DeleteAppServicePlan, deleteMetricsByDefault, deleteSlotsByDefault);
                });

        }
    }
}
