namespace 함수
{
    //Void == 공허
    internal class Program
    {
        static int Test(int Hamsu) //함수를 생성
        {

            Hamsu = Hamsu + 1;
           
            Console.WriteLine(Hamsu);
           
            return Hamsu;
        }

        static void Main()
        {
            int a = 99;

            Test(a);//함수를 호출
        }
    }
}
// 