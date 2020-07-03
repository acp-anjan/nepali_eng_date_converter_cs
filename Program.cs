using System;


namespace nepdate
{
    class Program
    {
        static void Main(string[] args)
        {
            NepDate daate = new NepDate();
            daate.setNepDate(2075, 05, 25);

            NepDateConverter conv = new NepDateConverter();
            DateTime  a = NepDateConverter.NepToEng(2076, 5, 30);
            Console.WriteLine("DateConversion:::::");
            Console.WriteLine(a);

            var b = NepDateConverter.EngToNep(2019, 7, 16);
            b.ToLongDateString();
            Console.WriteLine("DateConversion:::::");
            Console.WriteLine(b.ToLongsDateString());

            Console.WriteLine(b.Year);
            Console.WriteLine(b.Month);
            Console.WriteLine(b.Day);
            

            //if (b.Month < 4)
            //{
            //    Console.WriteLine("FisalYear :"+(b.Year - 1)+"/"+ b.Year);
            //}
            //else
            //{
            //    Console.WriteLine("FisalYear :" + (b.Year) + "/" + (b.Year+1));
            //}

        }
    }
}
