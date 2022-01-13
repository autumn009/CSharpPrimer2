    var x = new Sample();
    x.SubPublic();   // 呼べる
    //x.SubPrivate();  // 呼べない

    public class Sample
    {
        public void SubPublic()
        {
            Console.WriteLine("pubic method");
            SubPrivate();   // 呼べる
        }
        private void SubPrivate()
        {
            Console.WriteLine("private method");
        }
    }
