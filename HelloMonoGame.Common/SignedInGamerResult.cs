using System;
using System.Threading;

namespace HelloMonoGame.Common
{
    public class SignedInGamerResult : IAsyncResult
    {
        #region IAsyncResult implementation

        object IAsyncResult.AsyncState
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        WaitHandle IAsyncResult.AsyncWaitHandle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IAsyncResult.CompletedSynchronously
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IAsyncResult.IsCompleted
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

    }
}

