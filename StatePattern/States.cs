using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class NewState : IState
    {
        public void HandleRequest()
        {
            Console.WriteLine("Create a new document");
        }
    }
    public class SubmittedState : IState
    {
        public void HandleRequest()
        {
            Console.WriteLine("Submitted");
        }
    }
    public class ApprovedState : IState
    {
        public void HandleRequest()
        {
            Console.WriteLine("Approved");
        }
    }
    public class RejectedState : IState
    {
        public void HandleRequest()
        {
            Console.WriteLine("Rejected");
        }
    }
}
