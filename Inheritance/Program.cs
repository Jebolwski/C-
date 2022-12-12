using System;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            Youtube youtube = new Youtube();
            Video video = new Video();
            video.duration = 258;
            video.name = "Thats life - Frank Snitra";
            Youtube.PlayVideo(video);
            B b = new B();
            b.a = 10;
            b.d = 20;
        }
    }

    class Youtube
    {
        public static void PlayVideo(Video vid)
        {
            Console.WriteLine("Now playing the video {0}, time left for video to end is {1} seconds.", vid.name, vid.duration);
        }
    }

    class Video
    {
        public string name;
        public int duration;

    }

    class A
    {
        public int a;
        protected int b;
        private int c;

        public A()
        {

        }

        public A(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    class B : A
    {
        public int d;
        protected int e;

        public B():base()
        {
        }

        public B(int d,int e,int a) : base(a,d,e)
        {
            this.d = d;
            this.e = e;
        }
    }
}