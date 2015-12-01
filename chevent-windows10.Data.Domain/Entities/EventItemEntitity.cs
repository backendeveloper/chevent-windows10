using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace chevent_windows10.Data.Domain.Entities
{
    public class EventItemEntitity
    {
        #region Private Value
        private ObservableCollection<EventEntity> events;
        #endregion


        #region Public Value
        [Required]
        public ObservableCollection<EventEntity> Events
        {
            get { return events; }
            set { if (String.IsNullOrEmpty(value.ToString())) { throw new ArgumentNullException(nameof(value)); } events = value; }
        }
        #endregion
    }
}
