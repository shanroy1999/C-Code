namespace C____Access_Modifiers
{

    // Composite Class -> Installer
    public class Installer{

        // declare a private field in the composite Class(Installer)
        private readonly Logger _logger;
        
        // Use the constructor of the Composite class(Installer) to initialize the private field (_logger)
        public Installer(Logger logger){
            _logger = logger;
        }

        public void Install(){
            _logger.Log("We are installing the application using Install method of Installer");
        }
            
    }
}
