using System.ComponentModel.DataAnnotations;

namespace ClassDemo.Models {
    public class ThingType {
        #region Private Fields

        private int _ID;
        private string _Name;
        private bool _CanShare;

        #endregion

        #region Properties

        [Key]
        public int ID {
            get => _ID;
            set => _ID = value;
        }

        [StringLength(30)]
        [Display(Name = "Name")]
        public string Name {
            get => _Name;
            set => _Name = value;
        }

        [Display(Name = "Can Share")]
        public bool CanShare {
            get => _CanShare;
            set => _CanShare = value;
        }

        #endregion
    }
}