namespace WebApplication2.Service.UserService
{
    public class UserService
    {
        //bring the type of the user class 
        public Model.User User { get; set; }

        //create constructor for the user service 
        public UserService() { } 

        //a method to create a method that is used in the razor page as on post(for now)
        public void create (Model.User user)
        {
            user = new Model.User();
        }

    }
}
