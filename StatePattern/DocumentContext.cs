using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class DocumentContext
    {
        private IState state;
        public void SetState(IState state)
        {
            this.state = state;
        }
        public void ApplyState()
        {
            this.state.HandleRequest();
        }
    }
}
