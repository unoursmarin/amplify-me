using System;

namespace Isen.DotNet.Library
{
    public class Hello
    {
        /* 
        private static string _world = "Hello, World";
        public static string World
        {
            get {return _world;}
            set {_world = value;}
        }*/
        public static string World {get; set;}
        ="Hello, World";
        
        //Renvoie des salutations
        public static string Greet(string name)
        {
            var time = DateTime.Now.ToString("HH:mm:ss");
            // Utilisation de Token (version traditionnelle)
            var message = String.Format("Hello {0}, it is {1}", name,time);
            
            // string message ="Salut grosse salope de "+ name + " it is "+time +".";
             return message;
        }

        public static string GreetUpper(string name)
            => Greet(name.ToUpper());
            // var message = Greet(name.ToUpper());
            // return message;
        
    }
}
