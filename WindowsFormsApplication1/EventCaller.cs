using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
    {
    class EventCaller
        {

            public delegate void OnAppStartEventHandler(object source, EventArgs args);

            public event OnAppStartEventHandler AppStarted;

            protected virtual void OnAppStarted()
            {
                if (AppStarted != null)
                    AppStarted(this, EventArgs.Empty);
            }

            public  void CallEventHandler()
            {
                OnAppStarted();
            }
             
        }
    }
