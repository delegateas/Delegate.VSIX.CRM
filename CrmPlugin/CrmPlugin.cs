using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DG.XrmFramework.BusinessLogic;
using DG.XrmFramework.BusinessLogic.Managers;
using DG.XrmFramework.BusinessDomain.ServiceContext;

namespace $rootnamespace$
{
    public class $itemname$ : Plugin
    {

        // Register when/how to execute
        public $itemname$() : base(typeof($itemname$))
        {
            
            RegisterPluginStep<Account>(
                EventOperation.Create, 
                ExecutionStage.PostOperation, 
                Execute);
            
        }

        // Execute plugin logic
        protected void Execute(LocalPluginContext context) {
        
            // Insert logic here
        
        }
    }
}
