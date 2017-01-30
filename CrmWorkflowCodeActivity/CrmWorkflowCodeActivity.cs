
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;

using DG.XrmFramework.BusinessDomain.ServiceContext;

namespace $rootnamespace$ {

    public sealed partial class $itemname$ : CodeActivity {

        protected override void Execute(CodeActivityContext executionContext) {
            var traceService = executionContext.GetExtension<ITracingService>()
                as ITracingService;
            var workflowExecutionContext =
                executionContext.GetExtension<IWorkflowContext>()
                as IWorkflowContext;
            var factory =
                executionContext.GetExtension<IOrganizationServiceFactory>()
                as IOrganizationServiceFactory;
            var orgService =
                factory.CreateOrganizationService(workflowExecutionContext.UserId)
                as IOrganizationService;
            var orgAdminService =
                factory.CreateOrganizationService(null)
                as IOrganizationService;


            var accountRef = this.AccountReference.Get(executionContext);

            this.SomeStringOutput.Set(executionContext, "It works!");

        }

        // Define Input/Output Arguments
        [RequiredArgument]
        [Input("Some input entity reference")]
        [ReferenceTarget(Account.EntityLogicalName)]
        public InArgument<EntityReference> AccountReference { get; set; }

        [Output("Some output")]
        public OutArgument<string> SomeStringOutput { get; set; }

    }
}
