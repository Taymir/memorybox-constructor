package
{
    import flash.events.Event;

    public class UserEvent extends Event
    {
        public function UserEvent(type:String, user: User = null) {
                // Call the constructor of the superclass.
                super(type);
                
                if(user != null)
                	this.user = user;
        }

        // Define a public variable to hold the state of the enable property.
        public var user:User;

        // Override the inherited clone() method.
        override public function clone():Event {
            return new UserEvent(type, user);
        }
    }
}