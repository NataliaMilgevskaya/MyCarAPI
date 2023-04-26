using System.ComponentModel.DataAnnotations;

namespace MVCFriends.Models
{
    public class Friend
    {
        [Required(ErrorMessage = "FrienId is a mandatory field. Please, fill in it.")]
        public int FriendId { get; set; }
        [Required(ErrorMessage = "Friend Name Empty Not Allowed")]
        public string? FriendName { get; set; }
        [StringLength(25, ErrorMessage = "Max lenhtg for this field is 25 characters")]
        public string? Place { get; set; }
        public DateTime DOB { get; set; }
        public string ?FavouriteColor { get; set; }
    }

    
}
