using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.Categories = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }
        public static bool CheckOff { get; set; }/* (int ItemId)
        {
            if (ItemId.checked == true)
            {   
                Hide(ItemId);
            }
        }*/
        public virtual ApplicationUser User { get; set; }

        public ICollection<CategoryItem> Categories { get;}

        
    }
}