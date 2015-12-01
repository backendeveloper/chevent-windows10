using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace chevent_windows10.Data.Domain.Entities
{
    public class EventEntity
    {
        #region Private Value
        private string name;
        private string date;
        private string dateDetails;
        private string classes;
        private string cost;
        private string image;
        private string url;
        #endregion

        #region Public Value
        [Required]
        public string Name
        {
            get { return name; }
            set { if (String.IsNullOrEmpty(value)) { throw new ArgumentNullException(nameof(value)); } name = value?.Any().ToString(); }
        }

        [Required]
        public string Date
        {
            get { return date; }
            set { if (String.IsNullOrEmpty(value)) { throw new ArgumentNullException(nameof(value)); } date = value?.Any().ToString(); }
        }

        [Required]
        public string DateDetails
        {
            get { return dateDetails; }
            set { if (String.IsNullOrEmpty(value)) { throw new ArgumentNullException(nameof(value)); } dateDetails = value?.Any().ToString(); }
        }

        [Required]
        public string Classes
        {
            get { return classes; }
            set { if (String.IsNullOrEmpty(value)) { throw new ArgumentNullException(nameof(value)); } classes = value?.Any().ToString(); }
        }

        [Required]
        public string Cost
        {
            get { return cost; }
            set { if (String.IsNullOrEmpty(value)) { throw new ArgumentNullException(nameof(value)); } cost = value?.Any().ToString(); }
        }

        [Required]
        public string Image
        {
            get { return image; }
            set { if (String.IsNullOrEmpty(value)) { throw new ArgumentNullException(nameof(value)); } image = value?.Any().ToString(); }
        }

        [Required]
        public string Url
        {
            get { return url; }
            set { if (String.IsNullOrEmpty(value)) { throw new ArgumentNullException(nameof(value)); } url = value?.Any().ToString(); }
        }
        #endregion
    }
}
