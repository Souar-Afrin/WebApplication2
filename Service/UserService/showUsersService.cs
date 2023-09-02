namespace Shero.Service.UserService
{
    public class showUsersService
    {
        //bring the type of the user class 
        public Model.showUsers User { get; set; }

        //create constructor for the user service 
        public showUsersService() { }

        //a method to create a method that is used in the razor page as on post(for now)
        public void create(Model.showUsers user)
        {
            user = new Model.showUsers();
        }

    }
}
