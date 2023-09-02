using System.ComponentModel.DataAnnotations;

namespace Shero.Model
{
    public class showUsers
    {

        //data annotation to apply restrictions to ur input
        [Required(ErrorMessage = "sadasd")]
        [StringLength(1)]

        //proparty
        public string Name { get; set; }


        //data annotation to apply restrictions to ur input
        [Required(ErrorMessage = "sadasd")]
        [StringLength(1)]

        //proparty
        public string Age { get; set; }

        //required an empty constructor
        public showUsers()
        {

        }

        // create a constructor with the behavior 
        public showUsers(string name, string age)
        {
            Name = name;
            Age = age;
        }


    }
}
