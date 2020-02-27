using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DXSample.Data;

namespace DXSample.ViewModels {
    public class SchedulingViewModel : ViewModelBase {
        public SchedulingViewModel() {
            SportChannelsDataHelper data = new SportChannelsDataHelper(2);
            SportEvents = data.Events;
            SportChannels = data.Channels;
            SportGroups = data.Groups;
        }
        public ObservableCollection<SportEvent> SportEvents {
            get { return GetValue<ObservableCollection<SportEvent>>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<SportChannel> SportChannels {
            get { return GetValue<ObservableCollection<SportChannel>>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<SportGroup> SportGroups {
            get { return GetValue<ObservableCollection<SportGroup>>(); }
            set { SetValue(value); }
        }
    }
}