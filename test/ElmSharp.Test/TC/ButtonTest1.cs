using System;
using ElmSharp;

namespace ElmSharp.Test
{
    class ButtonTest1 : TestCaseBase
    {
        public override string TestName => "ButtonTest1";
        public override string TestDescription => "To test basic operation of Button";

        public override void Run(Window window)
        {
            Button button1 = new Button(window) {
                Text = "Button 1",
            };

            button1.SetPartColor("bg", Color.Red);

            button1.Clicked += (s, e) =>
            {
                Console.WriteLine("Button1 Clicked! : {0}", button1.ClassName);
                Console.WriteLine("Button1 Clicked! : {0}", button1.ClassName.ToLower());
                Console.WriteLine("Button1 Clicked! : {0}", button1.ClassName.ToLower().Replace("elm_",""));
                Console.WriteLine("Button1 Clicked! : {0}", button1.ClassName.ToLower().Replace("elm_", "")+ "/" + "bg");
            };

            button1.Pressed += (s, e) =>
            {
                Console.WriteLine("Button1 Pressed!");
            };

            button1.Released += (s, e) =>
            {
                Console.WriteLine("Button1 Released!");
            };

            button1.Repeated += (s, e) =>
            {
                Console.WriteLine("Button1 Repeated!");
            };

            button1.Show();
            button1.Resize(500, 100);
            button1.Move(0, 0);
        }

    }
}
