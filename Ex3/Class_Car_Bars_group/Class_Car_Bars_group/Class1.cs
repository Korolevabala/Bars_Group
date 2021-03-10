using System;

namespace Class_Car_Bars_group
{
    public class Car
    {
        //атрибуты
        private Motor motor = null;
        private Body body = null;
        private Oil oil = null; 
        private Fabric fabric = null;
        void InitializationCar()
        {
            this.motor = new Motor();
            this.body = new Body();
            this.oil = new Oil();
            this.fabric = new Fabric();
        }
        //.ctor
        public Car(string name)
        {
            InitializationCar();
            this.fabric.Name = name;
        }
        //method
        public void Show()
        {
            this.body.Show();
            this.fabric.Show();
            this.motor.Show();
            this.oil.Show();
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Motor
        {
            set
            {
                this.motor.Content = value;
            }
        }

        public string Oil
        {
            set
            {
                this.oil.Content = value;
            }
        }
    }
    class Oil
    {
        private string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                {
                    return "sosi";
                }
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
    class Body
    {
        private string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                {
                    return "sosi";
                }
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Red;
        } 
    }
    class Motor
    {
        private string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                {
                    return "sosi";
                }
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.White;
        } 
    }
    class Fabric
    {
        private string name;

        public string Name
        {
            private get
            {
                if (name != null)
                    return name;
                else
                {
                    return "sosi";
                }
            }
            set
            {
                name = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Cyan;
        } 
    }
}