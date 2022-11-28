using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AlgorithmTest
{
    internal class BJ1000
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1번문제");
            //string? str = Console.ReadLine();
            //int a = int.Parse(str.Split(' ')[0]);
            //int b = int.Parse(str.Split(' ')[1]);
            //Console.WriteLine(a + b);

            //Console.WriteLine("2번문제");
            //string? str1 = Console.ReadLine();
            //int c = int.Parse(str1.Split(' ')[0]);
            //int d = int.Parse(str1.Split(' ')[1]);
            //Console.WriteLine(c - d);

            /*
             첫째 줄에 다음 세 가지 중 하나를 출력한다.

             A가 B보다 큰 경우에는 '>'를 출력한다.
             A가 B보다 작은 경우에는 '<'를 출력한다.
             A와 B가 같은 경우에는 '=='를 출력한다.
             */

            //string? str = Console.ReadLine();
            //int a = int.Parse(str.Split(' ')[0]);
            //int b = int.Parse(str.Split(' ')[1]);
            //if (a > b)
            //{
            //    Console.WriteLine(">");
            //}else if (a < b)
            //{
            //    Console.WriteLine("<");
            //}
            //else
            //{
            //    Console.WriteLine("==");
            //}

            /*
             첫째 줄에 16진수 수가 주어진다. 
            이 수의 최대 길이는 6글자이다. 
            16진수 수는 0~9와 A~F로 이루어져 있고, 
            A~F는 10~15를 뜻한다. 
            또, 이 수는 음이 아닌 정수이다.

            16진수 수를 입력받아서 10진수로 출력하는 프로그램을 작성하시오.
             */

            //string? str = Console.ReadLine();
            //Console.WriteLine(Convert.ToInt64(str,16));

            //Console.WriteLine("Hello World!");

            //string? a = Console.ReadLine();
            //int c = int.Parse(a);
            //string? b = Console.ReadLine();
            //int d = int.Parse(b);
            //Console.WriteLine(c+d);

            /*자연수 N이 주어졌을 때, 
             * 1부터 N까지 한 줄에 하나씩 출력하는 프로그램을 작성하시오.

            입력
            첫째 줄에 100,000보다 작거나 같은 자연수 N이 주어진다.*/

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int N = int.Parse(sr.ReadLine());
            //for (int i = 0; i < N; i++)
            //{
            //    string input = sr.ReadLine();
            //    sw.WriteLine(Convert.ToInt32(input, 2));
            //}
            //sr.Close();
            //sw.Close();
            //string? str = Console.ReadLine();
            //???

            //StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));     
            //int a = int.Parse(sr.ReadLine());
            //for (int i = 1; i <= a; i++)
            //{
            //    sw.WriteLine(Convert.ToInt32(i));
            //    //sw.WriteLine(i);
            //    //Console.WriteLine(i);
            //}
            //sr.Close();
            //sw.Close();

            //StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int a = int.Parse(sr.ReadLine());
            //for (int i = a; i >0 ; i--)
            //{
            //    sw.WriteLine(Convert.ToInt32(i));
            //    //sw.WriteLine(i);
            //    //Console.WriteLine(i);
            //}
            //sr.Close();
            //sw.Close();


            //string? str = Console.ReadLine();
            //int a = int.Parse(str);
            //for (int i = a; i > 0 ; i--)
            //{
            //    Console.WriteLine(i);
            //}

            /*
             동규는 세수를 하다가 정렬이 하고싶어졌다.

            숫자 세 개를 생각한 뒤에, 
            이를 오름차순으로 정렬하고 싶어 졌다.

            숫자 세 개가 주어졌을 때, 
            가장 작은 수, 그 다음 수, 
            가장 큰 수를 출력하는 프로그램을 작성하시오.

            입력
            숫자 세 개가 주어진다. 
            이 숫자는 1보다 크거나 같고, 
            1,000,000보다 작거나 같다. 이 숫자는 모두 다르다.*/

            //동규는 왜 세수를 하다가 정렬이 하고 싶어졌니? 개새끼

            //string? str = Console.ReadLine();
            //int a = int.Parse(str.Split(' ')[0]);
            //int b = int.Parse(str.Split(' ')[1]);
            //int c = int.Parse(str.Split(' ')[2]);


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int N = int.Parse(sr.ReadLine());
            //for (int i = 0; i < N; ++i)
            //{
            //    string input = sr.ReadLine();
            //    sw.WriteLine(Convert.ToInt32(input, 2));
            //}
            //sr.Close();
            //sw.Close();

            //윤년

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int year = int.Parse(sr.ReadLine());
            //if (year%4==0&&year%100!=0||year%400==0)
            //{
            //    sw.Write("1");
            //}
            //else
            //{
            //    sw.Write("0");
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //while (true)
            //{
            //    string? num = sr.ReadLine();
            //    int a = int.Parse(num.Split(' ')[0]);
            //    int b = int.Parse(num.Split(' ')[1]);

            //    if (a == 0 || b == 0)
            //        break;

            //    if (a > b)
            //    {
            //        //sw.WriteLine("Yes");
            //        Console.WriteLine("Yes");
            //    }
            //    else if (a < b || a == b)
            //    {
            //        //sw.WriteLine("No");
            //        Console.WriteLine("No");
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //Console.WriteLine(".  .   .");
            //Console.WriteLine("|  | _ | _. _ ._ _  _");
            //Console.WriteLine("|/\\|(/.|(_.(_)[ | )(/.");

            //Console.WriteLine("       _.-;;-._");
            //Console.WriteLine("'-..-'|   ||   |");
            //Console.WriteLine("'-..-'|_.-;;-._|");
            //Console.WriteLine("'-..-'|   ||   |");
            //Console.WriteLine("'-..-'|_.-''-._|");

            //Console.WriteLine("     /~\\");
            //Console.WriteLine("    ( oo|");
            //Console.WriteLine("    _\\=/_");
            //Console.WriteLine("   /  _  \\");
            //Console.WriteLine("  //|/.\\|\\\\");
            //Console.WriteLine(" ||  \\ /  ||");
            //Console.WriteLine("============");
            //Console.WriteLine("|          |");
            //Console.WriteLine("|          |");
            //Console.WriteLine("|          |");


            //카드게임
            //int number=0;
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //for (int i = 0; i < 5; i++)
            //{
            //    string? num = sr.ReadLine();
            //    int a = int.Parse(num);
            //    //sw.WriteLine(a);
            //    number += a;
            //}
            //    sw.WriteLine(number);
            //    sr.Close();
            //    sw.Close();


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string? num1 = sr.ReadLine();
            //int a = int.Parse(num1);
            //string? num2 = sr.ReadLine();
            //int b = int.Parse(num2);
            //int c = b - a;
            //sw.WriteLine(b+c);
            //sr.Close();
            //sw.Close();

            //외계인
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            ////string? antenna = sr.ReadLine();
            ////int antennaNum = int.Parse(antenna);
            ////string? eyes = sr.ReadLine();
            ////int eyesNum = int.Parse(eyes);

            //int antennaNum = Convert.ToInt32(Console.ReadLine());
            //int eyesNum = Convert.ToInt32(Console.ReadLine());

            //if (antennaNum >= 3 && eyesNum <= 4)
            //{
            //    //sw.WriteLine("TroyMartian");
            //    Console.WriteLine("TroyMartian");
            //}
            //if (antennaNum <= 6 && eyesNum >= 2)
            //{
            //    //sw.WriteLine("VladSaturnian");
            //    Console.WriteLine("VladSaturnian");
            //}
            //if (antennaNum <= 2 && eyesNum <= 3)
            //{
            //    //sw.WriteLine("GrameMercurian");
            //    Console.WriteLine("GraemeMercurian");
            //}







            //------------------------------can u add this?


            //예제입력이 14 8 이런식으로 나올 때 작동하세 변경

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cntt = int.Parse((sr.ReadLine()));
            //for (int i = 0; i < cntt; i++)
            //{
            //    //string? str = sr.ReadLine();
            //    //int count = int.Parse(str);
            //    string? str1 = sr.ReadLine();
            //    long a = long.Parse(str1.Split(' ')[0]);
            //    long b = long.Parse(str1.Split(' ')[1]);
            //    sw.WriteLine(a + b);
            //}
            //    sw.Close();
            //    sr.Close();


            //------------------------------------비행기 좌석

            //int n1, n2, k1, k2;
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string? str = sr.ReadLine();
            ////int seatNum = int.Parse(str);
            //n1 = int.Parse(str.Split(' ')[0]);
            //n2 = int.Parse(str.Split(' ')[1]);
            //k1 = int.Parse(str.Split(' ')[2]);
            //k2 = int.Parse(str.Split(' ')[3]);

            //sw.WriteLine(n1 * n2 + k1 * k2);

            //sr.Close();
            //sw.Close();

            //--------------------------------------합


            //int number = Convert.ToInt32(Console.ReadLine());
            //int cnt=0;
            //for (int i = number; i >= 0; i--)
            //{
            //    //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //    //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //    //string? str = sr.ReadLine();
            //    //int num = int.Parse(str);

            //    //Console.WriteLine(i);
            //    cnt += i;
            //}
            //    Console.WriteLine(cnt);

            //--------------------------------Hello Judge

            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine($"Hello World, Judge {i}!");
            //}

            //--------------------------------
            //            Console.WriteLine(@"    8888888888  888    88888
            //   88     88   88 88   88  88
            //    8888  88  88   88  88888
            //       88 88 888888888 88   88
            //88888888  88 88     88 88    888888

            //88  88  88   888    88888    888888
            //88  88  88  88 88   88  88  88
            //88 8888 88 88   88  88888    8888
            // 888  888 888888888 88  88      88
            //  88  88  88     88 88   88888888");

            //-------------------------------------------------
            //            Console.WriteLine(@"SHIP NAME      CLASS          DEPLOYMENT IN SERVICE
            //N2 Bomber      Heavy Fighter  Limited    21        
            //J-Type 327     Light Combat   Unlimited  1         
            //NX Cruiser     Medium Fighter Limited    18        
            //N1 Starfighter Medium Fighter Unlimited  25        
            //Royal Cruiser  Light Combat   Limited    4   ");

            //--------------------------------------------------

            //int n1,n2,cnt;
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string? str = sr.ReadLine();
            //n1 = int.Parse(str.Split(' ')[0]);
            //n2 = int.Parse(str.Split(' ')[1]);
            //cnt = 0;
            //for (int i = n1+1; i < n2; i++)
            //{
            //    cnt++;
            //}
            //sw.WriteLine(cnt);  
            //for (int i = n1+1; i < n2; i++)
            //{
            //    sw.Write($"{i} ");
            //}
            //sr.Close();
            //sw.Close();

            //            Console.WriteLine(@"NFC West       W   L  T
            //-----------------------
            //Seattle        13  3  0
            //San Francisco  12  4  0
            //Arizona        10  6  0
            //St. Louis      7   9  0

            //NFC North      W   L  T
            //-----------------------
            //Green Bay      8   7  1
            //Chicago        8   8  0
            //Detroit        7   9  0
            //Minnesota      5  10  1");

            //Console.WriteLine(@"\    /\
            // )  ( ')
            //(  /  )
            // \(__)|");

            //Console.WriteLine("|\\_/|");
            //Console.WriteLine("|q p|   /}");
            //Console.WriteLine("( 0 )\"\"\"\\");
            //Console.WriteLine("|\"^\"`    |");
            //Console.WriteLine("||_/=\\\\__|");

            //Console.WriteLine(@"|\_/|
            //|q p|   /}
            //( 0 )"""\
            //| "" ^ ""`    |
            //|| _ /=\\__ | ");

            //Console.WriteLine("강한친구 대한육군");
            //Console.WriteLine("강한친구 대한육군");

            //---------------------------------------------------중간값
            //int n1, n2, n3;
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string? str = sr.ReadLine();
            //n1 = int.Parse(str.Split(' ')[0]);
            //n2 = int.Parse(str.Split(' ')[1]);
            //n3 = int.Parse(str.Split(' ')[2]);
            //if (n1 >= n2)
            //{
            //    if (n1 >= n3)
            //    {
            //        if (n2 >= n3)
            //        {
            //            sw.WriteLine(n2);
            //        }
            //        else
            //        {
            //            sw.WriteLine(n3);
            //        }
            //    }
            //    else if (n1 <= n3)
            //    {
            //        sw.WriteLine(n1);
            //    }
            //}
            //else if (n1 <= n2)
            //{
            //    if (n2 <= n3) 
            //    { 
            //        sw.WriteLine(n2);
            //    }
            //    else if (n2 >= n3)
            //    {

            //        if (n3 > n1) 
            //        { 
            //            sw.WriteLine(n3);
            //        }
            //        else
            //        {
            //            sw.WriteLine(n1);
            //        }
            //    }
            //}
            //sr.Close();
            //sw.Close();



            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string? str = sr.ReadLine();
            //sw.WriteLine(str + "??!");
            //sr.Close();
            //sw.Close();


            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //    var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //    string? str = sr.ReadLine();

            //    if(str.)
            //}

            //int cnt1 = Convert.ToInt32(Console.ReadLine());
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cnt = int.Parse(sr.ReadLine());

            //for (int i = 0; i < cnt; i++)
            //{
            //    string? str = sr.ReadLine();
            //    string name = str.Split(' ')[0];
            //    int score = int.Parse(str.Split(' ')[1]);

            //    if (score >= 97 && score <= 100)
            //    {
            //        sw.WriteLine(name + " A+");
            //    }
            //    else if (score >= 90 && score <= 96)
            //    {
            //        sw.WriteLine(name + " A");
            //    }
            //    else if (score >= 87 && score <= 89)
            //    {
            //        sw.WriteLine(name + " B+");
            //    }
            //    else if (score >= 80 && score <= 86)
            //    {
            //        sw.WriteLine(name + " B");
            //    }
            //    else if (score >= 77 && score <= 79)
            //    {
            //        sw.WriteLine(name + " C+");
            //    }
            //    else if (score <= 79 && score >= 70)
            //    {
            //        sw.WriteLine(name + " C");
            //    }
            //    else if (score >= 67 && score <= 69)
            //    {
            //        sw.WriteLine(name + " D+");
            //    }
            //    else if (score >= 60 && score <= 66)
            //    {
            //        sw.WriteLine(name + " D");
            //    }
            //    else
            //    {
            //        sw.WriteLine(name + " F");
            //    }
            //}
            //    sr.Close();
            //sw.Close();






            // brain
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //for (int i = 0; i < 4; i++)
            //{
            //    string? num = sr.ReadLine();
            //    int a = int.Parse(num.Split(' ')[0]);
            //    int b = int.Parse(num.Split(' ')[1]);
            //    if (a == 3)
            //    {
            //        sw.WriteLine("NO BRAIN");
            //    }
            //    else
            //    {
            //        sw.WriteLine("MMM BRAIN");
            //    }
            //    sr.Close();
            //    sw.Close();
            //}

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));



            //switch (n1 % 2)
            //{
            //    case 0: n2 =n1 / 2;
            //        break;
            //    case 1: n2 =(n1 +1)/2;
            //        break;
            //}

            //------------------------------------숫자게임?

            //int cnt=1;
            //while (true)
            //{
            //    //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //    //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //    //string? num = sr.ReadLine();
            //    //int n1 = int.Parse(num);

            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2, n3, n4;
            //    if (n1 == 0)
            //    {
            //        break;
            //    }
            //    n1 = n1 * 3;

            //    if (n1 % 2 == 0)
            //    {
            //        n2 = n1 / 2;
            //        //string even = "even ";
            //        n3 = n2 * 3;
            //        n4 = n3 / 9;
            //        //Console.WriteLine(even + n4);
            //        Console.WriteLine($"{cnt++}. " + "even " + n4);
            //    }
            //    else 
            //    {
            //        n2 = (n1 + 1) / 2;
            //        //string odd = "odd ";
            //        n3 = n2 * 3;
            //        n4 = n3 / 9;
            //        //Console.WriteLine(odd + n4);
            //        Console.WriteLine($"{cnt++}. " + "odd " + n4);
            //    }
            //}
            //n3 = n2 * 3;
            //n4 = n3 / 9;
            //switch (n4 % 2)
            //{
            //    case 0:
            //        Console.WriteLine( + n4);
            //        break;
            //    case 1:
            //        Console.WriteLine("odd " + n4);
            //        break;
            //}
            //sr.Close();
            //sw.Close();

            //연세대학교

            //string eng = "YONSEI";
            //string slogan = "Leading the Way to the Future";
            //int num = int.Parse(Console.ReadLine());
            //if(num == 0)
            //{
            //    Console.WriteLine(eng);
            //}
            //else
            //{
            //    Console.WriteLine(slogan);
            //}


            //int K, D, A;
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string? str = sr.ReadLine();
            //K = int.Parse(str.Split('/')[0]);
            //D = int.Parse(str.Split('/')[1]);
            //A = int.Parse(str.Split('/')[2]);

            //if (K + A < D || D == 0)
            //{
            //    Console.WriteLine("hasu");
            //}else
            //{
            //    Console.WriteLine("gosu");
            //}


            //            Console.WriteLine(@"NFC West       W   L  T
            //-----------------------
            //Seattle        13  3  0
            //San Francisco  12  4  0
            //Arizona        10  6  0
            //St. Louis      7   9  0

            //NFC North      W   L  T
            //-----------------------
            //Green Bay      8   7  1
            //Chicago        8   8  0
            //Detroit        7   9  0
            //Minnesota      5  10  1");

            //Console.WriteLine("I'm Sexy");

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //if(num1 >0 && num2 > 0)
            //{
            //    Console.WriteLine("1");
            //}else if (num1 < 0 && num2 > 0)
            //{
            //    Console.WriteLine("2");
            //}else if (num1 < 0 && num2 < 0)
            //{
            //    Console.WriteLine("3");
            //}
            //else
            //{
            //    Console.WriteLine("4");
            //}

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cnt = int.Parse(sr.ReadLine());
            //int num=0;
            //int num2=0;

            //for (int i = 1; i < cnt+1; i++)
            //{

            //    num = int.Parse(sr.ReadLine());

            //    num2 = i * i;

            //    sw.WriteLine(num2);
            //}
            //sr.Close();
            //sw.Close();


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cnt = int.Parse(sr.ReadLine());
            //int num = 0;
            //int num2 = 0;
            //for (int i = 1; i < cnt + 1; i++)
            //{
            //    num = int.Parse(sr.ReadLine());

            //    num2 += num;
            //    sw.WriteLine(num2);
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cnt = int.Parse(sr.ReadLine());
            //int sum1 = 0;
            //int sum2 = 0;
            //for (int i = 0; i < cnt; i++)
            //{
            //    int num = int.Parse(sr.ReadLine());
            //    if (num % 2 == 1)
            //    {
            //        for (int j = num; j > 0; j = j - 2)
            //        {
            //            sw.WriteLine(j);
            //            sum1 += j;
            //        }
            //    }
            //    sw.WriteLine(sum1);
            //    sum1 = 0;
            //}
            //sr.Close();
            //sw.Close();


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cnt = int.Parse(sr.ReadLine());
            //for (int i = 0; i < cnt; i++)
            //{
            //    string? num = sr.ReadLine();

            //    sw.WriteLine(Convert.ToInt32(num,10));
            //}
            //sr.Close();
            //sw.Close();


            //자음 모음
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cnt = int.Parse(sr.ReadLine());
            //char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            //int consonant = 0;
            //int vowel = 0;
            //for (int i = 0; i < cnt; i++)
            //{
            //    string? sentence = sr.ReadLine();
            //    for (int j = 0; j < sentence.Length; j++)
            //    {
            //        if (sentence[j] != ' ')
            //        {
            //            bool isVowels = false;
            //            for (int k = 0; k < vowels.Length; k++)
            //            {
            //                if (sentence[j] == vowels[k])
            //                {
            //                    isVowels=true;
            //                    break;  
            //                }
            //            }
            //            if (isVowels)
            //            {
            //                vowel++;
            //            }
            //            else
            //            {
            //            consonant++;
            //            }
            //        }
            //    }
            //    sw.WriteLine(consonant + " " + vowel);
            //    consonant = 0;
            //    vowel = 0;
            //}
            //sr.Close();
            //sw.Close();

            //char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            //string str = "You a aabb";   // 총 갯수 = 10, str.length = 10, i=0부터 9까지

            //int cnt모음 = 0;
            //int cnt자음 = 0;
            //int cnt공백 = 0;
            //// 1. str안에 a가 몇 개있는지 어떻게 알 수 있나요?
            //// 실제 모음과 자음의 갯수는 3, 5
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'a' || str[i] == 'e' || str[i]=='i' || 
            //        str[i] == 'o'|| str[i] == 'u'&& str[i] != ' ')
            //    {
            //        cnt모음++;

            //    }                
            //    else
            //    {
            //        cnt자음++;
            //    }
            //}

            //Console.WriteLine("모음"+cnt모음);
            //Console.WriteLine("자음"+cnt자음);



            //int n1, n2, cnt;
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string? str = sr.ReadLine();
            //n1 = int.Parse(str.Split(' ')[0]);
            //n2 = int.Parse(str.Split(' ')[1]);
            //cnt = 0;
            //if (n1 < n2)
            //{
            //    for (int i = n1 + 1; i < n2; i++)
            //    {
            //        cnt++;
            //    }
            //    sw.WriteLine(cnt);
            //    for (int i = n1 + 1; i < n2; i++)
            //    {
            //        sw.Write(i + " ");
            //    }
            //}
            //else
            //{
            //    for (int i = n2 + 1; i < n1; i++)
            //    {
            //        cnt++;
            //    }
            //    sw.WriteLine(cnt);
            //    for (int i = n2 + 1; i < n1; i++)
            //    {
            //        sw.Write(i+" ");
            //    }
            //}
            //sr.Close();
            //sw.Close();



            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int cnt = int.Parse(sr.ReadLine());
            //for (int i = 0; i < cnt; i++)
            //{
            //    int num = int.Parse( sr.ReadLine());
            //    for (int j = 0; j < num; j++)
            //    {
            //        sw.Write("=");
            //    }
            //    sw.WriteLine(' ');
            //}
            //    sr.Close();
            //    sw.Close();


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cnt1 = 0;
            //int cnt2 = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    string? ret = sr.ReadLine();

            //    if (ret.Equals("W"))
            //    {
            //        cnt1++;

            //    }
            //}
            //    if (cnt1 > 4)
            //    {
            //        sw.WriteLine(1);
            //    }else if(cnt1 ==3 || cnt1==4)
            //    {
            //        sw.WriteLine(2);
            //    }else if(cnt1 == 1 || cnt1 == 2)
            //    {
            //        sw.WriteLine(3);
            //    }
            //    else
            //    {
            //        sw.WriteLine(-1);
            //    }
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string str = sr.ReadLine();
            //sw.WriteLine(str.ToUpper());
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string str = sr.ReadLine();


            //if (str == "baekjoon")
            //{
            //    sw.WriteLine(0);
            //}
            //else
            //{
            //    sw.WriteLine(1);
            //}

            ////------------------------------------------------
            ////Random rand = new Random();
            ////int a = rand.Next();
            //////sw.WriteLine(a);
            ////if (a % 2 == 0)
            ////{
            ////    sw.WriteLine(0);
            ////}
            ////else
            ////{
            ////    sw.WriteLine(1);
            ////}
            //sr.Close();
            //sw.Close();

            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            string? str = sr.ReadLine();
            int num1 = int.Parse(str.Split()[0]);
            int num2 = int.Parse(str.Split()[1]);
            int tileNum = num1 * num2;
            
            sr.Close();
            sw.Close();
            
           






            //1.
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int n1 = 0;//?
            //int cnt = 0;

            //string num2 = sr.ReadLine();

            //int[] array = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);


            //for (int i = 0; i < 5; i++)
            //{
            //    if (array[i] == num)
            //    {
            //        cnt++;
            //    }
            //}
            //sw.WriteLine(cnt);

            //sr.Close();
            //sw.Close();

            //2.
            //string a = sr.ReadLine();
            //sw.WriteLine((int)a[0]);
            //sr.Close();
            //sw.Close();

            //3.
            //string? str = sr.ReadLine();
            //int n1 = int.Parse(str.Split(' ')[0]);
            //int n2 = int.Parse(str.Split(' ')[1]);

            //if (n1 > n2)
            //{
            //    sw.WriteLine(n1);
            //}
            //else
            //{
            //    sw.WriteLine(n2);
            //}
            //sr.Close();
            //sw.Close();






        }
    }
}

