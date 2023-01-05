using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security;

namespace Algorithm_Basic_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A/B

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);
            //decimal ret = (decimal)a / b;
            //sw.WriteLine(ret);
            //sr.Close();
            //sw.Close();

            //단어의 개수 (공백의 개수로 착각함)

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string txt = sr.ReadLine();
            //int cnt = 0;

            //for (int i = 0; i < txt.Length; i++)
            //{
            //    if (txt[i].ToString() == " ")
            //    {
            //        cnt++;
            //    }
            //}
            //sw.WriteLine(cnt);

            //sr.Close();
            //sw.Close();

            //단어의 개수 

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string txt = sr.ReadLine();
            //int cnt = 0;
            //char a = txt[txt.Length-1];
            //if (txt[0].ToString() == " " && a.ToString() == " ")
            //{
            //    for (int i = 0; i < txt.Length; i++)
            //    {
            //        if (txt[i].ToString() == " ")
            //        {
            //            cnt++;
            //        }
            //    }
            //    sw.WriteLine(cnt - 1);
            //}else
            //if (txt[0].ToString()==" ")
            //{
            //    for (int i = 0; i < txt.Length; i++)
            //    {
            //        if (txt[i].ToString()==" ")
            //        {
            //            cnt++;
            //        }
            //    }
            //    sw.WriteLine(cnt);
            //}else if (a.ToString() == " ")
            //{
            //    for (int i = 0; i < txt.Length; i++)
            //    {
            //        if (txt[i].ToString() == " ")
            //        {
            //            cnt++;
            //        }
            //    }
            //    sw.WriteLine(cnt);
            //}
            //else if(txt[0].ToString() != " " && a.ToString() != " ")
            //{
            //    for (int i = 0; i < txt.Length; i++)
            //    {
            //        if (txt[i].ToString() == " ")
            //        {
            //            cnt++;
            //        }
            //    }
            //    sw.WriteLine(cnt+1);
            //}
            //sr.Close();
            //sw.Close();

            //팰린드롬수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text;
            //int cnt = 0;
            //    text = sr.ReadLine();

            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (text[i].ToString() == text[(text.Length - 1) - i].ToString())
            //        {
            //            cnt++;
            //        }
            //    }
            //    if (cnt == text.Length)
            //    {
            //        sw.WriteLine("yes");
            //    }
            //    else
            //    {
            //        sw.WriteLine("no");
            //    }

            //    //if (text.ToString() == "0")
            //    //{
            //    //    break;
            //    //}

            //sr.Close();
            //sw.Close();

            //string text;
            //int cnt = 0;
            //while (true)
            //{
            //    text = Console.ReadLine();

            //    if (text.ToString() == "0")
            //    {
            //        break;
            //        cnt = 0;
            //    }
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (text[i].ToString() == text[(text.Length - 1) - i].ToString())
            //        {
            //            cnt++;
            //        }
            //    }
            //    if (cnt == text.Length)
            //    {
            //        Console.WriteLine("yes");
            //        cnt = 0;
            //    }
            //    else
            //    {
            //        Console.WriteLine("no");
            //        cnt = 0;
            //    }
            //}

            //모음의 개수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //char[] v = { 'a', 'e', 'i', 'o', 'u','A','E','I','O','U' };
            //int cnt = 0;

            //while (true)
            //{
            //    string text = sr.ReadLine();

            //    if (text[0].ToString() == "#")
            //    {
            //        break;
            //    }
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        for (int j = 0; j < v.Length; j++)
            //        {
            //            if (text[i].ToString() == v[j].ToString())
            //            {
            //                cnt++;
            //            }

            //        }
            //    }
            //    sw.WriteLine(cnt);
            //    cnt = 0;
            //}
            //sr.Close();
            //sw.Close();

            //공

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string cup = null;
            //int [] location = { 0, 1, 2, 3 };

            //void Swap(int a, int b)
            //{
            //    int tmp = location[a];
            //    location[a] = location[b];
            //    location[b] = tmp;
            //}


            //for (int i = 0; i < num; i++)
            //{
            //    cup = sr.ReadLine();

            //    int a = int.Parse(cup.Split()[0]);
            //    int b = int.Parse(cup.Split()[1]);

            //    Swap(a, b);

            //}
            //sw.WriteLine(int.Parse(cup.Split()[0]));
            //sr.Close();
            //sw.Close();

            //새

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int cnt = 0;
            //int remain = 0;
            //for (int i = 0; ; i++)
            //{
            //    //sw.WriteLine("cnt "+cnt);
            //    //sw.WriteLine("num "+num);

            //    if (cnt>=num)
            //    {
            //        //sw.WriteLine("if cnt " + cnt);
            //        //sw.WriteLine("if num " + num);
            //        cnt = 0;               
            //    }else if (cnt < num)
            //    {
            //        cnt++;
            //        num = num - cnt;
            //        //sw.WriteLine("else cnt " + cnt);
            //        //sw.WriteLine("else num " + num);
            //        //이미 여기서 0이 되어버림..
            //        //이 아니라 루프가 4에서 끝나기 때문에 더 못하는거임
            //        remain++;
            //        if (num <= 0)
            //        {
            //            break;
            //        }
            //    }
            //}
            //sw.WriteLine(remain);
            //sr.Close();
            //sw.Close();

            //추론

            //등차수열 :어떤 수에 차례대로 일정한 수를 더해서 이루어지는 수열
            //등비수열 :어떤 수에서 시작해 차례로 같은 수를 곱하여 만든 수열

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //long number = 0; ;
            //long tmp = 0;
            //for (int i = 0; i < num; i++)
            //{

            //    number = long.Parse(sr.ReadLine());
            //    tmp = number;
            //    sw.WriteLine(number);
            //    sw.WriteLine(tmp);
            //    if(tmp%number == 0)
            //    {
            //        long ret = tmp / number;
            //        sw.WriteLine(number * tmp);
            //    }
            //}

            //sr.Close();
            //sw.Close();

            //문어
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            ////string[] chars = {"-",@"\","(","@","?",">","&","%" };

            ////Dictionary<string, int> dictionary = new Dictionary<string, int>() 
            ////{
            ////    {"-",-1},{@"\",0},{"(",1},{"@",2},{"?",3},{">",4},{"&",5},{"%",6}
            ////};
            //sr.Close();
            //sw.Close();

            //도비의 영어공부

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int cnt = 0;
            //string alphabet = null;
            //string a = null;
            //string b = null;
            //string b_lower = null;
            //while (true)
            //{
            //    alphabet = sr.ReadLine();
            //    a = alphabet.Split()[0];
            //    for (int i = 0; i < alphabet.Length-2; i++)
            //    {
            //        b = alphabet.Remove(0, 2);  //왜 이게 문제일까?
            //        b_lower = b.ToLower();

            //        if (b[i] == a[0] || b_lower[i] == a[0] )
            //        {
            //            cnt++;
            //        }
            //    }
            //    if (a[0].ToString() == "#")
            //    {
            //        break;
            //    }

            //    sw.WriteLine(a+" "+cnt);
            //    cnt= 0;
            //}
            //sr.Close();
            //sw.Close();

            //구구단
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 1; i <= 9 ; i++)
            //{
            //    sw.WriteLine(num + " * " + i + " = " + num * i);
            //}
            //sr.Close();
            //sw.Close();

            //별찍기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        sw.Write("*");
            //    }
            //    sw.WriteLine(" ");
            //}
            //sr.Close();
            //sw.Close();

            //단어 길이 재기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //int cnt = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    cnt++;
            //}
            //sw.WriteLine(cnt);
            //sr.Close();
            //sw.Close();

            //대소문자 바꾸기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //string upper = text.ToUpper();
            //string lower = text.ToLower();
            //string rand = null;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == lower[i])
            //    {
            //        rand = text[i].ToString().ToUpper();
            //    }
            //    else
            //    {
            //        rand = text[i].ToString().ToLower();
            //    }

            //    sw.Write(rand);
            //}
            //sr.Close();
            //sw.Close();

            //스네이크버드

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string first = sr.ReadLine();

            //int number = int.Parse(first.Split()[0]);
            //int snake_length = int.Parse(first.Split()[1]);
            //string amount = sr.ReadLine();
            //int a = 0;
            //int[] arr = new int[number];

            //for (int i = 0; i < number; i++)
            //{
            //    a = int.Parse(amount.Split()[i]);
            //    arr[i] = a;
            //}

            //Array.Sort(arr);    //오름차순으로 정렬했음

            //for (int i = 0; i < number; i++)
            //{
            //    if (snake_length >= arr[i])
            //    {
            //        snake_length++;
            //    }
            //}
            //sw.WriteLine(snake_length);
            //sr.Close();
            //sw.Close();

            //검증수
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);
            //int c = int.Parse(num.Split()[2]);
            //int d = int.Parse(num.Split()[3]);
            //int e = int.Parse(num.Split()[4]);

            //double aa = Math.Pow(a, 2);
            //double bb = Math.Pow(b, 2);
            //double cc = Math.Pow(c, 2);
            //double dd = Math.Pow(d, 2);
            //double ee = Math.Pow(e, 2);
            //int ret = (int)(aa + bb + cc + dd + ee) % 10;
            //sw.WriteLine(ret);
            //sr.Close();
            //sw.Close();

            //유학금지
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //char[] cambridge = { 'C', 'A', 'M', 'B', 'R', 'I', 'D', 'G', 'E' };
            //string text = sr.ReadLine();
            //string ex = "";
            //string tmp = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int j = 0; j < cambridge.Length; j++)
            //    {
            //        if (text[i].ToString() == cambridge[j].ToString())
            //        {
            //            //ex = text.Remove(i, 1);
            //            ex = text[i].ToString();
            //            sw.WriteLine("ex " + ex);
            //        }

            //    }
            //}
            ////sw.WriteLine(text);
            ////sw.WriteLine(ex);
            //sr.Close();
            //sw.Close();

            //점수계산
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num;
            //int[] number = new int[8];
            //int[] tmpnum = new int[5];
            //int[] tmp = new int[8];
            //for (int i = 0; i < 8; i++)
            //{
            //    num = int.Parse(sr.ReadLine());
            //    number[i] = num;    //잘 들어갔군
            //}
            //Array.Copy(number, tmp, 8); //들어간 초기값을 복사
            //Array.Sort(number); //오름차순 정렬
            //sw.WriteLine(number[7]+ number[6]+number[5]+number[4]+ number[3]);  //합

            ////내가 쓸 수 있는거 : 원래 값 tmp 랑 오름차순인 number
            ////근데 오름차순으로 비교하면 안되는게 원래 값이랑 number에 들어있는 값이랑 비교
            ////결국엔 tmp index를 가져와야 한다는 건데..

            ////for (int i = 0; i < tmpnum.Length; i++)
            ////{
            ////    for (int j = 7; j > 2; j--)
            ////    {

            ////        tmpnum[i] = number[j];
            ////        //sw.WriteLine(tmpnum[i]);
            ////    }
            ////}

            //tmpnum[0] = number[7];
            //tmpnum[1] = number[6];
            //tmpnum[2] = number[5];
            //tmpnum[3] = number[4];
            //tmpnum[4] = number[3];

            ////for (int i = 0; i < tmpnum.Length; i++)
            ////{
            ////    sw.WriteLine( tmpnum[i]);
            ////}

            //for (int i = 0; i < tmp.Length; i++)
            //{
            //    for (int j = 0; j < tmpnum.Length; j++)
            //    {
            //        if (tmp[i].ToString() == tmpnum[j].ToString())
            //        {
            //            sw.Write(i+1+" ");
            //        }
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //FBI
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string codeName;
            //string[] code = new string[5];
            //string a;
            //string b;
            //int cnt = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    codeName = sr.ReadLine();
            //    code[i] = codeName; //배열에 할당함

            //    if (code[i].ToString().Contains("FBI"))
            //    {
            //        sw.Write(i+1 +" ");
            //    }
            //}
            //if (!code[0].ToString().Contains("FBI")
            //        && !code[1].ToString().Contains("FBI")
            //        && !code[2].ToString().Contains("FBI")
            //        && !code[3].ToString().Contains("FBI")
            //        && !code[4].ToString().Contains("FBI"))
            //{
            //    sw.WriteLine("HE GOT AWAY!");
            //}

            //sr.Close();
            //sw.Close();

            //나는요리사다
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string number = null;
            //int[] grade = new int [20];
            //int[,] grades = new int[5,4];
            //int a = 0;
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    number = sr.ReadLine();

            //    for (int j = 0; j < 4; j++)
            //    {
            //        a = int.Parse(number.Split()[j]);
            //        //grade[i] = a;
            //        grades[i,j] = a;
            //        sum += grades[i, j];
            //    }
            //        grade[i] = sum;
            //        //sw.WriteLine(sum);
            //        //sw.WriteLine(i+1);
            //        sum = 0;

            //}

            ////sw.WriteLine(grade.Max());
            //int index =Array.FindIndex(grade, i => i == grade.Max());   //처음써본 람다식
            //sw.WriteLine(index+1+" "+grade.Max());

            //sr.Close();
            //sw.Close();

            //R2

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);

            //int number = b * 2;
            //sw.WriteLine(number - a);
            //sr.Close();
            //sw.Close();

            //성적
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string grade = sr.ReadLine();
            //switch (grade)
            //{
            //    case "A+": sw.Write("4.3");
            //        break;
            //    case "A0":
            //        sw.Write("4.0");
            //        break;
            //    case "A-":
            //        sw.Write("3.7");
            //        break;
            //    case "B+": sw.Write("3.3");
            //        break;
            //    case "B0":
            //        sw.Write("3.0");
            //        break;
            //    case "B-":
            //        sw.Write("2.7");
            //        break;
            //    case "C+": sw.Write("2.3");
            //        break;
            //    case "C0":
            //        sw.Write("2.0");
            //        break;
            //    case "C-":
            //        sw.Write("1.7");
            //        break;
            //    case "D+": sw.Write("1.3");
            //        break;
            //    case "D0":
            //        sw.Write("1.0");
            //        break;
            //    case "D-":
            //        sw.Write("0.7");
            //        break;
            //    default: sw.Write("0.0");
            //        break;
            //}
            //sr.Close();
            //sw.Close();

            //꿍의 우주여행
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int testCase = int.Parse(sr.ReadLine());
            //int cnt = 0;
            //for (int i = 0; i < testCase; i++)
            //{
            //    string num = sr.ReadLine();
            //    int a = int.Parse(num.Split()[0]);
            //    int b = int.Parse(num.Split()[1]);
            //    for (int j = 0; j < a; j++)
            //    {
            //        string number = sr.ReadLine();
            //        double aa = int.Parse(number.Split()[0]);
            //        double bb = int.Parse(number.Split()[1]);
            //        double cc = int.Parse(number.Split()[2]);

            //        if ( aa * (double)(bb / cc) >= b)
            //        {
            //            cnt++;
            //        }
            //    }
            //    sw.WriteLine(cnt);
            //    cnt = 0;
            //}
            //sr.Close();
            //sw.Close();

            //좋은놈 나쁜놈
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            
            int num = int.Parse(sr.ReadLine());
            int cnt_g = 0;
            int cnt_b = 0;
            for (int i = 0; i < num; i++)
            {
                string name = sr.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j].ToString().Contains("g")|| name[j].ToString().Contains("G"))
                    {
                        cnt_g++;
                    }else if(name[j].ToString().Contains("b") || name[j].ToString().Contains("B"))
                    {
                        cnt_b++;
                    }
                }
                sw.Write(name + " is");
                if (cnt_b < cnt_g)
                {
                    sw.Write(" GOOD"+"\n");

                }else if (cnt_b > cnt_g)
                {
                    sw.Write(" A BADDY" + "\n");
                }
                else if (cnt_b == cnt_g)
                {
                    sw.Write(" NEUTRAL" + "\n");
                }
                cnt_g = 0;
                cnt_b = 0;
            }
            sr.Close();
            sw.Close();










        }
    }
}
