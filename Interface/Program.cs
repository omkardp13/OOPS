using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {

        interface IShape
        {
            void Draw();
        }

        interface IResizable
        {
            void Resize();
        }

        class ResizableCircle : IShape, IResizable
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a resizable circle.");
            }

            public void Resize()
            {
                Console.WriteLine("Resizing the circle.");
            }
        }

        static void Main(string[] args)
        {
            ResizableCircle obj = new ResizableCircle();
            obj.Draw();
            obj.Resize();
            Console.Read();
        }
    }
}
