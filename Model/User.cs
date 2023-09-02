using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Model
{
    public class User
    {

        //data annotation to apply restrictions to ur input
        [Required(ErrorMessage ="sadasd")]
        [StringLength(1)]

        //proparty
        public string Name { get; set; }


        //data annotation to apply restrictions to ur input
        [Required(ErrorMessage = "sadasd")]
        [StringLength(1)]

        //proparty
        public string Age { get; set; }

        //required an empty constructor
        public User() 
        { 
        
        }

        // create a constructor with the behavior 
        public User(string name, string age)
        {
            Name = name;
            Age = age;
            
        }

      
    }

    
}

