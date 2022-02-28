using System.ComponentModel.DataAnnotations;

namespace ClassDemo.Models
{
    public class ThingType
    {

        #region Private Fields
        private int _ID;
        private string _Name;
        private bool _CanShare;
        #endregion

        #region Properties
        [Key]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        [StringLength(30)]
        [Display(Name = "Name")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [Display(Name = "Can Share")]
        public bool CanShare
        {
            get { return _CanShare; }
            set { _CanShare = value; }
        }
        #endregion

    }
}