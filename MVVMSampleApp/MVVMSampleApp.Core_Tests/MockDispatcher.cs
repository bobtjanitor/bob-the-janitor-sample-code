using System;
using System.Collections.Generic;
using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Views;

namespace MVVMSampleApp.Core_Tests
{
    public class MockDispatcher : MvxMainThreadDispatcher, IMvxViewDispatcher
    {
        public readonly List<MvxViewModelRequest> ViewModelRequests = new List<MvxViewModelRequest>();
        public readonly List<MvxPresentationHint> PresentationHint = new List<MvxPresentationHint>();

        public bool RequestMainThreadAction(Action action)
        {
            action();
            return true;
        }

        public bool ShowViewModel(MvxViewModelRequest request)
        {
            ViewModelRequests.Add(request);
            return true;

        }

        public bool ChangePresentation(MvxPresentationHint hint)
        {
            PresentationHint.Add(hint);
            return true;
        }
    }
}