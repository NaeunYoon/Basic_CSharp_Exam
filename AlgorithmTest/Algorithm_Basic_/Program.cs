using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections.Generic;
using System.Security;
using Microsoft.Win32;
using System.Globalization;
using System.Net.Sockets;
using System.IO.IsolatedStorage;
using System.Net.Security;
using System.Net.Http.Headers;
using System.Xml.Linq;
using System.Runtime.ExceptionServices;
using System.Web;
using System.Data.SqlTypes;
using System.Deployment.Internal;
using System.Runtime.InteropServices;
using System.Numerics;

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
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int num = int.Parse(sr.ReadLine());
            //int cnt_g = 0;
            //int cnt_b = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    string name = sr.ReadLine();
            //    for (int j = 0; j < name.Length; j++)
            //    {
            //        if (name[j].ToString().Contains("g")|| name[j].ToString().Contains("G"))
            //        {
            //            cnt_g++;
            //        }else if(name[j].ToString().Contains("b") || name[j].ToString().Contains("B"))
            //        {
            //            cnt_b++;
            //        }
            //    }
            //    sw.Write(name + " is");
            //    if (cnt_b < cnt_g)
            //    {
            //        sw.Write(" GOOD"+"\n");

            //    }else if (cnt_b > cnt_g)
            //    {
            //        sw.Write(" A BADDY" + "\n");
            //    }
            //    else if (cnt_b == cnt_g)
            //    {
            //        sw.Write(" NEUTRAL" + "\n");
            //    }
            //    cnt_g = 0;
            //    cnt_b = 0;
            //}
            //sr.Close();
            //sw.Close();

            //게산기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            ////string[] sign = new string[5];
            //int num1 = 0;
            //int num2 = 0;
            //string sign="";
            //int ret = 0;
            //num1 = int.Parse(sr.ReadLine());
            //while (true)
            //{
            //    sign = sr.ReadLine();
            //    if(sign == "=")
            //    {
            //        break;
            //    }
            //    num2= int.Parse(sr.ReadLine());
            //    switch (sign)
            //    {
            //        case "+": num1+=num2;
            //            break;

            //        case "-":
            //            num1 -= num2;
            //            break;

            //        case "*": num1 *= num2; 
            //            break;

            //        case "/": num1 /= num2;
            //            break;
            //    }
            //}
            //sw.WriteLine(num1);

            //sr.Close();
            //sw.Close();

            //평균 중앙값 문제

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);

            //sr.Close();
            //sw.Close();

            //나머지

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);
            //int c = int.Parse(num.Split()[2]);
            //if(a>=2 && a<=100000 && b >= 2 && b <= 100000 && c >= 2 && c <= 100000)
            //{
            //    sw.WriteLine((a+b)%c);
            //    sw.WriteLine(((a%c)+(b%c))%c);
            //    sw.WriteLine((a*b)%c);
            //    sw.WriteLine(((a%c)*(b%c))%c);
            //}
            //sr.Close();
            //sw.Close();

            //과제 안 내신 분?

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[] number = new int[30];
            ////for (int i = 0; i < 30; i++)
            ////{
            ////    number[i] = i+1;
            ////    //sw.Write(number[i]);
            ////}
            //for (int i = 0; i < 30; i++)
            //{
            //    int a = int.Parse(sr.ReadLine());
            //    number[i] = i + 1;
            //    for (int j = 0; j < 30; j++)
            //    {
            //        if (a != number[j])
            //        {
            //            sw.WriteLine(number[j]);
            //        }
            //    }
            //}


            //sr.Close();
            //sw.Close();

            //A+B
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string number;
            //int a;
            //int b;
            //int sum;
            //for (int i = 1; i <= num; i++)
            //{
            //    number= sr.ReadLine();
            //    a = int.Parse(number.Split()[0]);
            //    b = int.Parse(number.Split()[1]);
            //    sum = a + b;
            //    sw.WriteLine("Case #"+i+": "+sum);
            //}

            //sr.Close();
            //sw.Close();

            //상근이의 친구들

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num;
            //int a;
            //int b;
            //int sum;
            //while (true)
            //{
            //    num = sr.ReadLine();
            //    a = int.Parse(num.Split()[0]);
            //    b = int.Parse(num.Split()[1]);
            //    sum = a + b;
            //    if(a == 0 && b ==0)
            //    {
            //        break;
            //    }
            //    sw.WriteLine(sum);
            //    sum = 0;
            //}
            //sr.Close();
            //sw.Close();

            //와이버스 부릉부릉

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);
            //for (int i = 0; i < a; i++)
            //{
            //    string number = sr.ReadLine();
            //    int aa = int.Parse(number.Split()[0]);
            //    int bb = int.Parse(number.Split()[1]);
            //}
            //Console.WriteLine("비와이");
            //sr.Close();
            //sw.Close();

            //모음의 개수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())); 
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string text = sr.ReadLine();
            //char[] chars = new char [5] { 'a', 'e', 'i', 'o', 'u' };
            //int cnt = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int j = 0; j < chars.Length; j++)
            //    {
            //        if (text[i].ToString() == chars[j].ToString())
            //        {
            //            cnt++;
            //        }
            //    }
            //}
            //sw.WriteLine(cnt);
            //sr.Close();
            //sw.Close();

            //a+b

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string number = sr.ReadLine();
            //    int a = int.Parse(number.Split()[0]);
            //    int b = int.Parse(number.Split()[1]);
            //    sw.WriteLine(a+b);
            //}
            //sr.Close();
            //sw.Close();

            //치킨댄스를 추는 곰곰이를 본 임스

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int chicken = int.Parse(sr.ReadLine());
            //string beverage = sr.ReadLine();
            //int coke = int.Parse(beverage.Split()[0]);
            //int beer = int.Parse(beverage.Split()[1]);
            //int cnt = 0;
            //for (int i = 0; i < coke/2; i++)
            //{
            //    cnt++;
            //}
            //for (int i = 0; i < beer; i++)
            //{
            //    cnt++;
            //}
            //if (cnt >= chicken)
            //{
            //    sw.WriteLine(chicken);
            //}else if (cnt < chicken)
            //{
            //    sw.WriteLine(cnt);
            //}
            //sr.Close();
            //sw.Close();


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    string number = sr.ReadLine();
            //    int a = int.Parse(number.Split()[0]);
            //    int b = int.Parse(number.Split()[1]);
            //    sum = a+b;
            //    sw.WriteLine("Case #" + i + ": " + a+ " + " + b + " = " + sum);
            //    sum = 0;
            //}
            //sr.Close();
            //sw.Close();

            //X보다 작은 수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //uint a = UInt16.Parse(num.Split()[0]);
            //uint b = UInt16.Parse(num.Split()[1]);
            //string number = sr.ReadLine();
            //for (int i = 0; i < a; i++)
            //{
            //    uint aa = UInt16.Parse(number.Split()[i]);

            //    if(aa < b ) 
            //    {
            //        sw.Write(aa+" ");
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //폰노이만

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int number = int.Parse(sr.ReadLine());
            //for (int i = 0; i < number; i++)
            //{
            //    string str = sr.ReadLine(); 
            //    float n = float.Parse(str.Split()[0]);
            //    float d = float.Parse(str.Split()[1]);
            //    float a = float.Parse(str.Split()[2]);
            //    float b = float.Parse(str.Split()[3]);
            //    float f = float.Parse(str.Split()[4]);
            //    float ret = (float)d/(a + b) * f;
            //    sw.WriteLine($"{n} {ret}");
            //}
            //sr.Close();
            //sw.Close();

            //윷놀이
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int number = 0;
            //int cnt = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    string num = sr.ReadLine();

            //    for (int j = 0; j < 4; j++)
            //    {
            //        int a = int.Parse(num.Split()[j]);
            //        if (number == a)
            //        {
            //            cnt++;
            //        }
            //    }
            //        switch (cnt)
            //        {
            //            case 0: sw.WriteLine("E");
            //                break;
            //            case 1:
            //                sw.WriteLine("A");
            //                break;
            //            case 2:
            //                sw.WriteLine("B");
            //                break;
            //            case 3:
            //                sw.WriteLine("C");
            //                break;
            //            case 4:
            //                sw.WriteLine("D");
            //                break;
            //        }
            //    cnt= 0;

            //}
            //sr.Close();
            //sw.Close();

            //소수/팰린드롬

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());

            //for (int i = 1; i<=100; i++)
            //{
            //    num++;


            //}
            //sr.Close();
            //sw.Close();

            //나이계산하기

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string num1 =sr.ReadLine();
            //int a1 = int.Parse(num1.Split()[0]);
            //int b1 = int.Parse(num1.Split()[1]);
            //int c1 = int.Parse(num1.Split()[2]);

            //string num2 = sr.ReadLine();
            //int a2 = int.Parse(num1.Split()[0]);
            //int b2 = int.Parse(num1.Split()[1]);
            //int c2 = int.Parse(num1.Split()[2]);
            ////만나이
            //if (b1 < b2)
            //{
            //    sw.WriteLine(a2 - a1);
            //}else if(b2 == b1)
            //{
            //    if (c2 <= c1)
            //    {
            //        sw.WriteLine(a2 - a1);
            //    }
            //    else
            //    {
            //        sw.WriteLine((a2-a1)-1);
            //    }
            //}
            //else
            //{
            //    sw.WriteLine((a2 - a1) - 1);
            //}
            ////세는나이
            //if()



            //sr.Close();
            //sw.Close();

            //홀수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int sum = 0;
            //int cnt = 0;
            //int[] number = new int[7];
            //List<int> numberList = new List<int>();
            //numberList.Clear();
            ////7개의 숫자들을 배열에 담는다
            //for (int i = 0; i < 7; i++)
            //{
            //    int num = int.Parse(sr.ReadLine());
            //    number[i] = num;
            //}
            ////짝수의 수를 구하기
            //for (int i = 0; i < 7; i++)
            //{
            //    if (number[i] % 2 == 0)
            //    {
            //        cnt++;
            //    }
            //}
            //for (int i = 0; i < 7; i++)
            //{
            //    if (number[i] % 2 == 1)
            //    {
            //        numberList.Add(number[i]);
            //        sum += number[i];
            //    }
            //}
            //if (cnt >= 7)
            //{
            //    sw.WriteLine("-1");
            //}
            //else
            //{
            //    sw.WriteLine(sum);
            //    sw.WriteLine(numberList.Min());
            //}

            //sr.Close();
            //sw.Close();

            //검증수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int[] number = new int[5];
            //int tmp = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    int a = int.Parse(num.Split()[i]);
            //    number[i] = a*a;
            //    tmp += number[i];
            //}
            //int ret = tmp % 10;
            //sw.Write(ret);

            //sr.Close();
            //sw.Close();

            //줄번호

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 1; i <= 5; i++)
            //{
            //    string text = sr.ReadLine();
            //    sw.WriteLine(i+". "+text);
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int sum = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //    sum *= i;
            //}
            //sw.WriteLine(sum);
            //sr.Close();
            //sw.Close();

            //홀수일까 짝수일까 : 값이 커서 정수로 못받는다

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int[] a = new int[num+1];
            //for (int i = 0; i < num; i++)
            //{
            //    string text = sr.ReadLine();
            //    int number = int.Parse(text.Substring(text.Length - 1));
            //    if (number % 2 == 0)
            //    {
            //        sw.WriteLine("even");
            //    }
            //    else
            //    {
            //        sw.WriteLine("odd");
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //다음 수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //while (true)
            //{
            //    string num = sr.ReadLine();
            //    string[] t = num.Split();
            //    int a = int.Parse(t[0]);
            //    int b = int.Parse(t[1]);
            //    int c = int.Parse(t[2]);

            //    if (a == 0 && b == 0 && c == 0)
            //    {
            //        break;
            //    }

            //    int ap1 = c - b;
            //    int ap2 = b - a;
            //    int gp1 = c / b;
            //    int gp2 = b / a;

            //    if(ap1 == ap2)
            //    {
            //        sw.WriteLine("AP "+ (c + ap1));
            //    }
            //    else if(gp1== gp2) 
            //    {
            //        sw.WriteLine("GP "+ (c * gp1));
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //TGN
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string money = sr.ReadLine();
            //    string[] ad = money.Split();
            //    long r = long.Parse(ad[0]);
            //    long d = long.Parse(ad[1]);
            //    long c = long.Parse(ad[2]);

            //    if ((d - c) > r)
            //    {
            //        sw.WriteLine("advertise");
            //    }else if ((d - c) == r)
            //    {
            //        sw.WriteLine("does not matter");
            //    }
            //    else
            //    {
            //        sw.WriteLine("do not advertise");
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //사칙연산

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);
            //sw.WriteLine(a + b);
            //sw.WriteLine(a - b);
            //sw.WriteLine(a * b);
            //sw.WriteLine(a / b);
            //sw.WriteLine(a % b);
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int num = int.Parse(sr.ReadLine());
            //while (true)
            //{
            //    int number = int.Parse(sr.ReadLine());
            //    if (number == 0)
            //    {
            //        break;
            //    }

            //    if (number % num == 0)
            //    {
            //        sw.WriteLine($"{number} is a multiple of {num}.");
            //    }
            //    else
            //    {
            //        sw.WriteLine($"{number} is NOT a multiple of {num}.");
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //삼각형
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int a = int.Parse(sr.ReadLine());
            //int b = int.Parse(sr.ReadLine());
            //int c = int.Parse(sr.ReadLine());

            //int sum = a + b + c;

            //if(sum != 180)
            //{
            //    sw.WriteLine("Error");
            //}else if( sum == 180 && a!=b && b!=c&& a!=c) 
            //{
            //    sw.WriteLine("Scalene");
            //}else if (a == 60 && b == 60 && c == 60)
            //{
            //    sw.WriteLine("Equilateral");
            //}else if(sum == 180 && a == b || a == c || b == c)
            //{
            //    sw.WriteLine("Isosceles");
            //}
            //sr.Close();
            //sw.Close();

            //가위바위보

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int cnt = 0;
            //int count = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    int number = int.Parse(sr.ReadLine()) ;
            //    for (int j = 0; j < number; j++)
            //    {
            //        string test = sr.ReadLine();
            //        string[] t = test.Split();
            //        string p1 = t[0];
            //        string p2 = t[1];

            //        //P1이 주먹만 낼 경우
            //        if (p1 == "R" && p2 == "P")
            //        {
            //            count++;
            //            cnt--;
            //        }else if(p1== "R" && p2 == "S")
            //        {
            //            cnt++;
            //            count--;
            //        }
            //        //P1이 가위만 낼 경우
            //        if (p1 == "S" && p2 == "R")
            //        {
            //            count++;
            //            cnt--;
            //        }else if(p1== "S" && p2 == "P")
            //        {
            //            cnt++;
            //            count--;
            //        }
            //        //P1이 보자기만 낼 경우
            //        if (p1=="P"&&p2== "S") 
            //        { 
            //            count++;
            //            cnt--;
            //        }else if(p1== "P" && p2 == "R")
            //        {
            //            cnt++;
            //            count--;
            //        }

            //    }
            //        if (cnt == count)
            //        {
            //            sw.WriteLine("TIE");
            //        }else if (cnt > count)
            //        {
            //            sw.WriteLine("Player 1");
            //        }
            //        else if(cnt<count) 
            //        {
            //            sw.WriteLine("Player 2");
            //        }
            //        count = 0;
            //        cnt= 0;
            //}
            //sr.Close();
            //sw.Close();

            //수빈이와 수열

            //var sr=new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw=new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int e = 0;
            //string number = sr.ReadLine();
            //string[] t = number.Split();
            //for (int i = 1; i <= num; i++)
            //{
            //    int a = int.Parse(t[i-1]);
            //    e += a;


            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string smile = ":-)";
            //int cnt_s = 0;
            //string sad = ":-(";
            //int count_s = 0;
            //int blank = 0;
            //string text = sr.ReadLine();
            //sr.Close();
            //sw.Close();

            //스트릿코딩파이터

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string score = sr.ReadLine();
            //int num = 0;
            //int number = 0;
            //int times = int.Parse(sr.ReadLine());
            //int[] team= new int[times];
            //for (int i = 0; i < times; i++)
            //{
            //    for (int k = 0; k < 3; k++)
            //    {
            //        string difficulty = sr.ReadLine();

            //        for (int j = 0; j < 3; j++)
            //        {
            //            int a = int.Parse(score.Split()[j]);
            //            //sw.WriteLine("a" +a);
            //            int aa = int.Parse(difficulty.Split()[j]);
            //            //sw.WriteLine("aa "+aa);

            //            num = aa * a;
            //            sw.WriteLine("num " +num);
            //            number += num;
            //            sw.WriteLine("number "+number);
            //        }
            //    }
            //    sw.WriteLine(number);
            //    team[i]= number;
            //    num = 0;
            //}

            ////sw.WriteLine(team.Max());
            //sr.Close();
            //sw.Close();


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //for (int i = 0; i < 5; i++)
            //{
            //    string num = sr.ReadLine();
            //    int a = int.Parse(num.Split()[0]);
            //    int b = int.Parse(num.Split()[1]);
            //    sw.WriteLine(a + b);
            //}
            //sr.Close();
            //sw.Close();

            //            Console.WriteLine(@" _________
            // \_     _/
            //   \   /
            //    | |
            //   /   \
            //  /     \
            // |       |
            ///---------\
            //| \-/ \-/ |
            //\---------/
            // \_______/");

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string[] I_Array = new string[] { "i", "I" };
            //string[] E_Array = new string[] { "e", "E" };
            //string text = sr.ReadLine();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i].ToString() == I_Array[0])
            //    {
            //    }
            //}

            //sr.Close();
            //sw.Close();

            // var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            // var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            // int num = int.Parse(sr.ReadLine());
            // int ret = 1;
            // for (int i = num; i > 0; i--)
            // {
            //     ret *= i;
            // }
            //// sw.WriteLine(ret);
            // string c = ret.ToString();
            // sw.WriteLine(c[c.Length-1]);
            // sr.Close();
            // sw.Close();

            //럭비 클럽

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //while (true)
            //{
            //    string info = sr.ReadLine();
            //    string[] t = info.Split();
            //    string name = t[0];
            //    int age = int.Parse(t[1]);
            //    int weight = int.Parse(t[2]);

            //    if( name =="#"&& age == 0 && weight == 0)
            //    {
            //        break;
            //    }

            //    if(age>17 || weight >= 80)
            //    {
            //        sw.WriteLine(name + " " + "Senior");
            //    }
            //    else
            //    {
            //        sw.WriteLine(name + " " + "Junior");
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num =sr.ReadLine();
            //long a = long.Parse(num.Split()[0]);
            //long b = long.Parse(num.Split()[1]);
            //long sum = 0;
            //for (long i = a; i <= b; i++)
            //{
            //    sum += i;
            //}
            //sw.WriteLine(sum);
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    string square = sr.ReadLine();

            //    int a = int.Parse(square.Split()[0]);
            //    int b = int.Parse(square.Split()[1]);
            //    int c = int.Parse(square.Split()[2]);

            //    if (a == b && a==c && b==c)
            //    {
            //        sum = 10000 + (a * 1000);
            //    }else if(a==b || a==c || b == c)
            //    {
            //        sum = 1000+()
            //    }

            //}

            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int a = int.Parse(sr.ReadLine());
            //int b = int.Parse(sr.ReadLine());
            //if (a != 01 && b != 01)
            //{
            //    sw.WriteLine(a + b);
            //    sw.WriteLine(a - b);
            //    sw.WriteLine(a * b);
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //long a = long.Parse(num.Split()[0]);
            //long b = long.Parse(num.Split()[1]);
            //long sum = a - b;
            //double aa = Math.Abs(sum);
            //sw.WriteLine(aa);
            //sr.Close();
            //sw.Close();

            //점수집계
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[] standard = new int[5];

            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string score = sr.ReadLine();
            //    string[] scoreSplit = score.Split();
            //    for (int j = 0; j < 5; j++)
            //    {
            //        int a = int.Parse(scoreSplit[j]);
            //        standard[j] = a;
            //    }

            //    Array.Sort(standard);
            //    int minus = standard[3] - standard[1];
            //    if(minus >=4)
            //    {
            //        sw.WriteLine("KIN");
            //    }
            //    else
            //    {
            //        int plus = standard[1] + standard[2] + standard[3];
            //        sw.WriteLine(plus);
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //첫글자를 대문자로

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string text = sr.ReadLine();
            //    string left = text.Substring(1, text.Length-1);
            //    string f = text.Substring(0, 1).ToUpper();
            //    sw.WriteLine(f+left);
            //    //string first = text[0].ToString().ToUpper();
            //}
            //sr.Close();
            //sw.Close();

            //나는 친구가 적다

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string[] number = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //string text = sr.ReadLine();
            //string[] tArr = new string[text.Length];
            //for (int i = 0; i < text.Length; i++)
            //{
            //    tArr[i] = text[i].ToString();
            //    //sw.Write(tArr[i]);
            //}
            //string keyword = sr.ReadLine();
            //string[] kArr = new string[keyword.Length];
            //for (int i = 0; i < keyword.Length; i++)
            //{
            //    kArr[i] = keyword[i].ToString();
            //    //sw.Write(kArr[i]);
            //}

            ////배열에 다 들어갔음
            //string[] tmp = new string[tArr.Length];
            //Array.Copy(tArr, tmp, tArr.Length);

            //for (int i = 0; i < tmp.Length; i++)
            //{
            //    for (int j = 0; j < number.Length; j++)
            //    {
            //        if (tmp[i].ToString() == number[j])
            //        {
            //            text = text.Remove(i, 1);
            //        }
            //    }
            //}
            //sw.WriteLine(text);




            //if (text.Contains(keyword))
            //{
            //    sw.WriteLine("1");
            //}
            //else
            //{
            //    sw.WriteLine("0");
            //}
            //sr.Close();
            //sw.Close();

            //개표

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());

            //string p = sr.ReadLine();
            //string[] ret = new string[num];
            //int cnt = 0;
            //int count = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    ret[i] = p[i].ToString();
            //    if (ret[i] == "A")
            //    {
            //        cnt++;
            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}

            //if (cnt > count)
            //{
            //    sw.WriteLine("A");
            //}else if (cnt < count)
            //{
            //    sw.WriteLine("B");
            //}
            //else
            //{
            //    sw.WriteLine("Tie");
            //}
            //sr.Close();
            //sw.Close();

            //남욱이의 닭장

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string chicken = sr.ReadLine();
            //    //닭 다리의 수
            //    int sumoflegs = int.Parse(chicken.Split()[0]);
            //    //닭의 수
            //    int sumofchicken = int.Parse(chicken.Split()[1]);
            //}
            //sr.Close();
            //sw.Close();

            //블랙잭
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int count = int.Parse(num.Split()[0]);
            //int number = int.Parse(num.Split()[1]);

            //string numbers = sr.ReadLine();
            //int[] intArr = new int[number];
            //for (int i = 0; i < count; i++)
            //{
            //    int a = int.Parse(numbers.Split()[i]);
            //    intArr[i] = a;
            //}

            //for (int i = 0; i < intArr.Length; i++)
            //{

            //}
            //sr.Close();
            //sw.Close();

            //나무조각

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string num = sr.ReadLine();
            //string [] numT = num.Split();

            //int[] intArr = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    int a = int.Parse(numT[i]);
            //    intArr[i] = a;
            //}

            //while (true)
            //{
            //    if (intArr[0]==1 && intArr[1] == 2 && intArr[2] == 3 && intArr[3] == 4 && intArr[4] == 5)
            //    {
            //        break;
            //    }

            //    //조건1
            //    if (intArr[0] >= intArr[1]) 
            //    {
            //        int tmp = intArr[0];
            //        intArr[0] = intArr[1];
            //        intArr[1] = tmp;
            //        for (int i = 0; i < 5; i++)
            //        {
            //            sw.Write(intArr[i]+" ");
            //        }
            //        sw.WriteLine();
            //    }

            //    //조건2
            //    if (intArr[1] >= intArr[2])
            //    {
            //        int tmp = intArr[1];
            //        intArr[1] = intArr[2];
            //        intArr[2] = tmp;
            //        for (int i = 0; i < 5; i++)
            //        {
            //            sw.Write(intArr[i] + " ");
            //        }
            //        sw.WriteLine();
            //    }
            //    //조건3
            //    if (intArr[2] >= intArr[3])
            //    {
            //        int tmp = intArr[2];
            //        intArr[2] = intArr[3];
            //        intArr[3] = tmp;
            //        for (int i = 0; i < 5; i++)
            //        {
            //            sw.Write(intArr[i] + " ");
            //        }
            //        sw.WriteLine();
            //    }

            //    //조건4
            //    if (intArr[3] >= intArr[4])
            //    {
            //        int tmp = intArr[3];
            //        intArr[3] = intArr[4];
            //        intArr[4] = tmp;
            //        for (int i = 0; i < 5; i++)
            //        {
            //            sw.Write(intArr[i] + " ");
            //        }
            //        sw.WriteLine();
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //e 계산

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //sw.WriteLine("n e");
            //sw.WriteLine("- -----------");


            //for (int i = 0; i < 9; i++)
            //{

            //}

            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);
            //sw.WriteLine(a * b);
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            //long a = long.Parse(num.Split()[0]);
            //long b = long.Parse(num.Split()[1]);
            //long c = long.Parse(num.Split()[2]);
            //sw.WriteLine(a + b + c);
            //sr.Close();
            //sw.Close();

            //서버
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string number = sr.ReadLine();
            //int a = int.Parse(number.Split()[0]);
            //int b = int.Parse(number.Split()[1]);
            //string cnt = sr.ReadLine();
            //int sum = 0;
            //int count = 0;
            //for (int i = 0; i < a; i++)
            //{
            //    int aa = int.Parse(cnt.Split()[i]);
            //    sum += aa;
            //    if (sum > b)
            //    {
            //        break;
            //    }
            //    count++;
            //}
            //sw.WriteLine(count);
            //sr.Close();
            //sw.Close();

            //최댓값

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[] numbers = new int[9];
            //for (int i = 0; i < 9; i++)
            //{
            //    int num = int.Parse(sr.ReadLine());
            //    numbers[i] = num;
            //}

            //int max = numbers.Max();
            //int index = Array.FindIndex(numbers, x => x == max);
            //sw.WriteLine(max);
            //sw.WriteLine(index+1);

            //sr.Close();
            //sw.Close();

            //탄산음료
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string coke = sr.ReadLine();
            //int e = int.Parse(coke.Split()[0]);
            //int f = int.Parse(coke.Split()[1]);
            //int c = int.Parse(coke.Split()[2]);
            ////빈 병들의 합
            //int emptyBottle = e + f;
            ////sw.WriteLine(emptyBottle);
            ////빈병을 c 로 나눔 => 새로운 새 콜라 탄생
            //int reusableBottle = emptyBottle / c;
            //int reusable = emptyBottle % c;
            ////sw.WriteLine(reusableBottle);
            ////카운트 셀 변수
            //int cnt = 0;
            ////초기 빈병을 c 로 나눈걸 따로 변수에 저장
            //int tmp = reusableBottle+reusable;
            //int temp = 0;
            //while (true)
            //{
            //    //0 = 5 / 2
            //    // temp = 2
            //    temp = tmp / c;
            //    //sw.WriteLine("temp "+temp);
            //    //나머지수니까 1이 찍힘
            //    int teemp = tmp % c;
            //    //sw.WriteLine("teemp " + teemp);
            //    cnt += temp;    //2저장//1저장
            //   // sw.WriteLine("cnt " + cnt);
            //    tmp = temp+teemp; //3
            //    //sw.WriteLine("tmp "+tmp);
            //    temp = 0;

            //    if (tmp < c)
            //    {
            //        break;
            //    }
            //}
            //sw.WriteLine(reusableBottle+cnt);
            //sr.Close();
            //sw.Close();

            //

            //나머지와 몫이 같은 수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //long sum = 0;
            //long cnt = 0;
            //while (true)
            //{
            //    cnt++;
            //    long number1 = cnt / num;
            //    long number2 = cnt % num;
            //    if (number1 == number2)
            //    {
            //        sum += cnt;
            //    }
            //    if (cnt >= 2_000_000)
            //    {
            //        break;
            //    }
            //}
            //sw.WriteLine(sum);

            //sr.Close();
            //sw.Close();

            //엄청난 부자

            ////var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            ////var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = Console.ReadLine();
            //int [] number = new int[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    number[i] = int.Parse(num.Split()[i]);    
            //}
            //long ret = number[0] / number[1];
            //Console.WriteLine(ret);
            //long left = number[0] % number[1];
            //Console.WriteLine(left);
            ////sr.Close();
            ////sw.Close();
            ///

            //행렬덧셈
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);

            //int[,] array = new int[a,b];
            //for (int k = 0; k < 2; k++)
            //{
            //    for (int i = 0; i < a; i++)
            //    {
            //        string number = sr.ReadLine();
            //        for (int j = 0; j < b; j++)
            //        {
            //            int aa = int.Parse(number.Split()[0]);
            //            int bb = int.Parse(number.Split()[i + 1]);
            //            array[i, j] = array[aa, bb];
            //            sw.WriteLine(array[i, j]);
            //        }
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //과제안내신분
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[] number = new int[30];
            //int[] numbers = new int[30];
            //for (int i = 0; i < 28; i++)
            //{
            //    int num = int.Parse(sr.ReadLine());
            //    number[i] = num;
            //}

            ////정렬함
            //Array.Sort(number);
            ////sw.WriteLine("dddd"+number[3]);

            //for (int i = 0; i <= 30; i++)
            //{
            //    if (number[i + 1] - number[i] != 1)
            //    {
            //        sw.WriteLine(number[i + 1] - number[i]);
            //    }
            //}

            //sr.Close();
            //sw.Close();

            //열개씩 끊어 출력하기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string text = sr.ReadLine();
            //string[] arr = new string[text.Length];
            //int cnt = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    arr[i] = text[i].ToString();
            //    sw.Write(arr[i]);
            //    cnt++;
            //   if(cnt % 10 == 0)
            //    {
            //        sw.WriteLine("");
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //찍기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            ////문제수
            //int num = int.Parse(sr.ReadLine());
            ////답을 받아서
            //string answer = sr.ReadLine();
            ////배열로 저장
            //string[] answer_ = new string[num];
            ////답을 답 배열에 저장함
            //for (int i = 0; i < num; i++)
            //{
            //    answer_[i] = answer[i].ToString();
            //}
            ////세 명의 리스트 만듬 (저장공간이 유연하기 때문에 > 메모리부담 큼)
            //List<string> adrian_ = new List<string>();
            //List<string> bruno_ = new List<string>();
            //List<string> goran_ = new List<string>();
            ////세 명의 답 배열
            //string[] ABC = new string[] { "A", "B", "C"};
            //string[] BABC = new string[] { "B", "A", "B", "C"};
            //string[] CCAABB = new string[] { "C", "C", "A", "A","B","B"};
            ////배열에 있는 값을 리스트에 루프로 돌려 넣어준다
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < ABC.Length; j++)
            //    {
            //        adrian_.Add(ABC[j]);
            //    }

            //    for (int h = 0; h < BABC.Length; h++)
            //    {
            //        bruno_.Add(BABC[h]);
            //    }

            //    for (int k = 0; k < CCAABB.Length; k++)
            //    {
            //        goran_.Add(CCAABB[k]);
            //    }
            //}
            //int a_cnt = 0;
            //int b_cnt = 0;
            //int c_cnt = 0;

            //for (int i = 0; i < num; i++)
            //{
            //    if (answer_[i] == adrian_[i])
            //    {
            //        a_cnt++;
            //    }
            //    if (answer_[i] == bruno_[i])
            //    {
            //        b_cnt++;
            //    }
            //    if (answer_[i] == goran_[i])
            //    {
            //        c_cnt++;
            //    }
            //}
            //if(a_cnt>b_cnt && a_cnt>c_cnt)
            //{
            //    sw.WriteLine(a_cnt);
            //    sw.WriteLine("Adrian");
            //}
            //if(b_cnt>a_cnt&& b_cnt>c_cnt)
            //{
            //    sw.WriteLine(b_cnt);
            //    sw.WriteLine("Bruno");
            //}
            //if(c_cnt>a_cnt&&c_cnt>b_cnt)
            //{
            //    sw.WriteLine(c_cnt);
            //    sw.WriteLine("Goran");
            //}
            //sr.Close();
            //sw.Close();

            //추론

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //ulong num = ulong.Parse(sr.ReadLine());
            //ulong[] arr = new ulong[num];
            //for (ulong i = 0; i < num; i++)
            //{
            //    ulong aa = ulong.Parse(sr.ReadLine());
            //    arr[i] = aa;
            //}
            //if (arr[1] - arr[0] == arr[2] - arr[1])
            //{
            //    ulong tmp = arr[1] - arr[0];
            //    ulong temp = arr[num - 1] + tmp;
            //    sw.WriteLine(temp);
            //}
            //if (arr[1] / arr[0] == arr[2] / arr[1])
            //{
            //    ulong tmp = arr[1] / arr[0];
            //    ulong temp = arr[num - 1] * tmp;
            //    sw.WriteLine(temp);
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //Dictionary<string, int> dictionary = new Dictionary<string, int>();
            //int num = int.Parse(sr.ReadLine());
            //int[] arr = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    string example = sr.ReadLine();

            //    string name = example.Split()[0];
            //    int difficulty = int.Parse(example.Split()[1]);
            //    arr[i]=difficulty;
            //    dictionary.Add(name, difficulty);
            //}
            //Array.Sort(arr);
            //foreach (var item in dictionary)
            //{
            //    if (item.Value == arr[0])
            //    {
            //        Console.WriteLine(item.Key);
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //남욱이의 닭장
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int cnt = 0;
            //int normal = 0;
            //int abnormal = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    string chicken = sr.ReadLine();
            //    //닭다리수
            //    int a = int.Parse(chicken.Split()[0]);
            //    //닭의수
            //    int b = int.Parse(chicken.Split()[1]);

            //    //다리가 잘린 닭의 수 : 
            //    //멀쩡한 닭의 수 :
            //}
            //sr.Close();
            //sw.Close();


            //지영공주님의 마법거울

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            ////각각의 인덱스를 num마다 잘라서 보관할 배열
            //string[] change = new string[num];
            ////1차원 배열로는 좌우반전이 안되니까 2차원 배열로 해야함 또는 리스트
            ////각각의 요소를 담음
            //char[,] secondArr = new char[num, num];
            //char text = char.Parse(sr.ReadLine());

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        char aa = text;
            //        secondArr[i, j] = aa;
            //    }
            //    sw.WriteLine("");
            //}



            //for (int i = 0; i < num; i++)
            //{
            //    string text = sr.ReadLine();

            //    change[i] = text;
            //}

            //int ret = int.Parse(sr.ReadLine());

            //if (ret == 1)
            //{
            //    for (int i = 0; i < num; i++)
            //    {
            //        sw.WriteLine(change[i]);
            //    }
            //}
            //else if (ret == 2)
            //{
            //    for (int i = 0; i < num; i++)
            //    {
            //        change[i] = change[change.Length];
            //    }
            //}
            //else if (ret == 3)
            //{
            //    Array.Reverse(change);
            //    for (int i = 0; i < num; i++)
            //    {
            //        sw.WriteLine(change[i]);
            //    }
            //}

            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //if(num >= 90)
            //{
            //    sw.WriteLine("A");
            //}else if(num >=80 && num < 90)
            //{
            //    sw.WriteLine("B");
            //}else if (num >= 70 && num < 80)
            //{
            //    sw.WriteLine("C");
            //}else if(num>=60 && num < 70)
            //{
            //    sw.WriteLine("D");
            //}
            //else
            //{
            //    sw.WriteLine("F");
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //while (true)
            //{
            //    string num = sr.ReadLine();
            //    int a = int.Parse(num.Split()[0]);
            //    int b = int.Parse(num.Split()[1]);
            //    //if (a == 0 && b == 0)
            //    //{
            //    //    break;
            //    //}
            //    sw.WriteLine(a + b);
            //}
            //sr.Close();
            //sw.Close();

            //while (true)
            //{
            //    try
            //    {
            //        string text = Console.ReadLine();
            //        int a = Convert.ToInt32(text.Split()[0]);
            //        int b = Convert.ToInt32(text.Split()[1]);
            //        Console.WriteLine(a + b);

            //    }
            //    catch (Exception)
            //    {

            //        break;
            //    }
            //}

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string text = sr.ReadLine();
            //    int a = int.Parse(text.Split()[0]);
            //    int b = int.Parse(text.Split()[1]);
            //    sw.WriteLine(a+b);
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string text = sr.ReadLine();
            //int [] arr = new int[num];
            //int cnt = 0;
            //int ask = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    int a = int.Parse(text.Split()[i]);
            //    if(a==ask)
            //    {
            //        cnt++;
            //    }
            //}
            //sw.WriteLine(cnt);
            //sr.Close();
            //sw.Close();

            //var sr= new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[,] arr = new int[9,9];
            //for (int i = 0; i < 9; i++)
            //{
            //    string num = sr.ReadLine();
            //    for (int j = 0; j < 9; j++)
            //    {
            //        int a = int.Parse(num.Split()[j]);
            //        arr[i, j] = a;
            //    }
            //}

            //int max = arr.Cast<int>().Max();
            //sw.WriteLine(max);
            //for (int i = 0; i < 9; i++)
            //{
            //    for (int j = 0; j < 9; j++)
            //    {
            //        if (arr[i, j] == max)
            //        {
            //            sw.WriteLine((i+1)+" "+(j+1));
            //        }
            //    }
            //}
            //sr.Close();
            //sw.Close();
            //주사위게임
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int[] arr = new int[num];
            //int [] max = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    string number = sr.ReadLine();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        int a = int.Parse(number.Split()[j]);
            //        arr[j] = a;
            //    }
            //    if (arr[0] == arr[1] && arr[1] == arr[2] && arr[0] == arr[2])
            //    {
            //        max[i] =10000 + (arr[0] * 1000);
            //    }
            //    if (arr[0] == arr[1] && arr[0] != arr[2])
            //    {
            //        max[i] = 1000 + (arr[0] * 100);
            //    }else if (arr[0] == arr[2] && arr[0] != arr[1])
            //    {
            //        max[i] = 1000 + (arr[0] * 100);
            //    }
            //    else if (arr[1] == arr[2] && arr[1] != arr[0])
            //    {
            //        max[i] = 1000 + (arr[0] * 100);
            //    }
            //    if (arr[0] != arr[1] && arr[0] != arr[2] && arr[1] != arr[2])
            //    {
            //        int maximum = arr.Max(x => x);
            //        max[i] = maximum * 100;
            //    }
            //}
            //sw.WriteLine(max.Max(x => x));
            //sr.Close();
            //sw.Close();

            //바구니뒤집기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string num = sr.ReadLine();
            ////바구니갯수
            //int a = int.Parse(num.Split()[0]);
            //int[] basket= new int[a];
            //int[] tmp = new int[2];
            ////몇 번 바꿀건지
            //int b = int.Parse(num.Split()[1]);
            //for (int i = 0; i < b; i++)
            //{
            //    string change = sr.ReadLine();
            //    for (int j = 0; j < 2; j++)
            //    {
            //        int aa = int.Parse(change.Split()[i]);
            //        tmp[j] = aa;
            //    }



            //}
            //sr.Close();
            //sw.Close();

            //지각
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int cnt = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    int a = int.Parse(sr.ReadLine());
            //    for (int j = 1; j < a; j++)
            //    {
            //        double time = Math.Pow(j, 2);
            //        sw.WriteLine("t "+time);
            //        if(time+cnt>=a)
            //        {
            //            break;
            //        }
            //        cnt++;
            //        sw.WriteLine("cnt " + cnt);
            //    }
            //    sw.WriteLine(cnt);
            //    cnt = 0;
            //}
            //sr.Close();
            //sw.Close();

            //3대측정
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string standard = sr.ReadLine();
            //int times = int.Parse(standard.Split()[0]);
            //int sum = int.Parse(standard.Split()[1]);
            //int individual = int.Parse(standard.Split()[2]);

            //int[] print = new int[3];
            //int cnt = 0;
            //int total = 0;
            //List<int> list = new List<int>();

            //for (int i = 0; i < times; i++)
            //{
            //    string teams = sr.ReadLine();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        int score = int.Parse(teams.Split()[j]);
            //        print[j] = score;
            //        total += print[j];
            //    }
            //    //sw.WriteLine(total);

            //    if (total >= sum && 
            //        print[0] >= individual && 
            //        print[1] >= individual && 
            //        print[2] >= individual)
            //    {
            //        cnt++;
            //        list.Add(print[0]);
            //        list.Add(print[1]);
            //        list.Add(print[2]);
            //    }
            //    total = 0;
            //}

            //sw.WriteLine(cnt);
            //for (int i = 0; i < cnt*3; i++)
            //{
            //    sw.Write(list[i]+" ");
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string str = sr.ReadLine();
            //sw.WriteLine(":fan::fan::fan:");
            //sw.WriteLine(":fan::"+str+"::fan:");
            //sw.WriteLine(":fan::fan::fan:");
            //sr.Close();
            //sw.Close();

            //명장남정훈
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string people = sr.ReadLine();
            //int left = int.Parse(people.Split()[0]);
            //int right = int.Parse(people.Split()[1]);
            //int both = int.Parse(people.Split()[2]);
            //int minus = 0;
            //int ret = 0;
            //if(left==right)
            //{
            //    int div = both / 2;
            //    sw.WriteLine((left + div)+(right+div));
            //}else if(left<right)
            //{
            //    minus = right - left;
            //    if(minus > both) 
            //    {
            //        left += both;
            //        if(left>right)
            //        {
            //            sw.WriteLine(right*2);
            //        }
            //        else
            //        {
            //            sw.WriteLine(left*2);
            //        }
            //    }else if(minus < both) 
            //    {
            //        left += minus;
            //        both -= minus;
            //        ret = both / 2;
            //        sw.WriteLine((left + ret) + (right + ret));
            //    }
            //}else if(left>right)
            //{
            //    minus = left- right;
            //    if (minus > both)
            //    {
            //        right += both;
            //        if (left < right)
            //        {
            //            sw.WriteLine(left*2);
            //        }
            //        else
            //        {
            //            sw.WriteLine(right*2);
            //        }
            //    }
            //    else if (minus < both)
            //    {
            //        right += minus;
            //        both -= minus;
            //        ret = both / 2;
            //        sw.WriteLine((left + ret) + (right + ret));
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //팬그램
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string[] alphabet = new string[] { "a","b","c","d","e","f","g",
            //                                   "h","i","j","k","l","m","n",
            //                                    "o","p","q","r","s","t","u",
            //                                    "v","w","x","y","z"};
            //int cnt = 0;
            //int count = 0;
            //string text = null;
            //while (true)
            //{
            //    text = sr.ReadLine();
            //    if(text=="*")
            //    {
            //        break;
            //    }

            //    for (int i = 0; i < alphabet.Length; i++)
            //    {
            //        for (int j = 0; j < text.Length; j++)
            //        {
            //            if (alphabet[i].ToString() == text[j].ToString() || text[j].ToString()== " ")
            //            {
            //                cnt++;
            //            }
            //            else
            //            {
            //                count++;
            //            }
            //        }
            //    }
            //    if (cnt >= text.Length)
            //    {
            //        sw.WriteLine("Y");
            //    }
            //    else
            //    {
            //        sw.WriteLine("N");
            //    }
            //}

            //sr.Close();
            //sw.Close();

            //과제 안내신 분?
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //전체 학생 수를 담는 배열
            //int[] student = new int[30];
            //for (int i = 0; i < 30; i++)
            //{
            //    student[i] = i + 1;
            //}
            //출석한 학생 수를 담는 배열
            //int[] exist = new int[28];
            //for (int i = 0; i < 28; i++)
            //{
            //    int num = int.Parse(sr.ReadLine());
            //    exist[i] = num;
            //    for (int j = 0; j < student.Length; j++)
            //    {
            //        if (exist[i] == student[j])
            //        {
            //            student[j] = 0;
            //        }
            //    }
            //}
            //Array.Sort(student);
            //for (int i = 0; i < student.Length; i++)
            //{
            //    if (student[i] != 0)
            //    {
            //        sw.WriteLine(student[i]);
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string text = sr.ReadLine();
            //    sw.Write(text[0]);
            //    sw.WriteLine(text[text.Length-1]);
            //}
            //sr.Close();
            //sw.Close();



            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    string text = sr.ReadLine();
            //    sw.WriteLine(i + ". " + text);
            //}
            //sr.Close();
            //sw.Close();

            //공

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int tmp = 0;
            //int[] arr = new int[3] { 1, 0, 0 };
            //for (int i = 0; i < num; i++)
            //{
            //    string cup = sr.ReadLine();
            //    int a =int.Parse(cup.Split()[0]);
            //    int b = int.Parse(cup.Split()[1]);
            //    //tmp를 이용해서 값을 swap 한다
            //    tmp = arr[b-1];
            //    arr[b-1] = arr[a-1];
            //    arr[a-1] = tmp;
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    if (arr[i] == 1)
            //    {
            //        int ret = Array.IndexOf(arr, 1);
            //        sw.WriteLine(ret+1);
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //몇개고?

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string sushi = sr.ReadLine();
            //int a = int.Parse(sushi.Split()[0]);
            //int b = int.Parse(sushi.Split()[1]);

            ////아침
            //if (a <= 11)
            //{
            //    Console.WriteLine("280");
            //}
            //else if (a >= 12 && a <= 16 && b == 1)
            //{
            //    Console.WriteLine("280");
            //}
            //else if(a >= 12 && a <= 16 && b == 0)
            //{
            //    Console.WriteLine("320");
            //}else if (a > 16)
            //{
            //    Console.WriteLine("280");
            //}
            //sr.Close();
            //sw.Close();

            //이상한 기호
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string num = sr.ReadLine();
            //int a = int.Parse(num.Split()[0]);
            //int b = int.Parse(num.Split()[1]);
            //double math_a = Math.Pow(a, 2);
            //double math_b = Math.Pow(b, 2);
            //sw.WriteLine(math_a - math_b);
            //sr.Close();
            //sw.Close();

            //문어 숫자
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //Dictionary<string, int> octopus = new Dictionary<string, int>()
            //{
            //    {"-", 0},{@"\",1},{"(", 2},{"@", 3},{"?", 4},{">", 5},{"&", 6},{"%", 7},{"/", -1}
            //};
            //double answer = 0;
            //int cnt = 0;
            //while (true)
            //{
            //    string text = sr.ReadLine();
            //    if (text == "#")
            //    {
            //        break;
            //    }
            //    for (int i = text.Length - 1; i >= 0; i--)
            //    {
            //        for (int j = 0; j < octopus.Count ; j++)
            //        {
            //            if (octopus.Keys.ToList()[j] == text[i].ToString())
            //            {
            //                //첫번째 문자열 원소
            //                //sw.WriteLine(text[i]);
            //                //문자열 원소의 밸류값을 가져와서 저장
            //                int tmp = octopus[text[i].ToString()];
            //                //sw.WriteLine("tmp "+tmp);
            //                //8진수 곱할건데 반대로 곱해야하는데 의문..
            //                double mul = Math.Pow(8, cnt);
            //                //sw.WriteLine(mul);
            //                //8진수와 원소의 밸류값을 곱함
            //                double ret = tmp * mul;
            //                //sw.WriteLine(ret);
            //                //곱함걸 계속 더함
            //                answer += ret;
            //                //카운트변수
            //                cnt++;
            //            }
            //        }
            //    }
            //    sw.WriteLine((int)answer);
            //    cnt = 0;
            //    answer= 0;
            //}

            //sr.Close();
            //sw.Close();

            //오르막길
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string numbers = sr.ReadLine();
            //int[] arr = new int[num];
            //int[] ret = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    int a = int.Parse(numbers.Split()[i]);
            //    arr[i] = a;
            //}
            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    if (arr[i] < arr[i+1])
            //    {

            //    }
            //    else
            //    {
            //        ret[i] = 0;
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //int R = int.Parse(text.Split()[0]);
            //int C = int.Parse(text.Split()[1]);
            //int ZR = int.Parse(text.Split()[2]);
            //int ZC = int.Parse(text.Split()[3]);
            ////이차원배열
            //string[,] arr =new string[R,C];
            //for (int i = 0; i < R; i++)
            //{
            //    string tx = sr.ReadLine();
            //    for (int j = 0; j < C; j++)
            //    {

            //        //2차원 배열에 담기
            //        arr[i, j] = tx[j].ToString();
            //    }
            //}

            //int row = R * ZR;   //3 3행
            //int col = C * ZC;   //6 6열짜리

            //int bigger = ZR * ZC;

            //for (int i = 0; i < R; i++)
            //{
            //    for (int j = 0; j < C; j++)
            //    {
            //        for (int k = 0; k < ZR; k++)
            //        {
            //            sw.Write(arr[i,j]);

            //        }
            //    }
            //    sw.WriteLine("");
            //}


            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int[] arr = new int[3];
            //for (int i = 1; i <= num; i++)
            //{
            //    string triangle = sr.ReadLine();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        int a = int.Parse(triangle.Split()[j]);
            //        arr[j] = a;
            //    }
            //    Array.Sort(arr);
            //    double aa = Math.Pow(arr[0], 2);
            //    double bb = Math.Pow(arr[1], 2);
            //    double cc = Math.Pow(arr[2], 2);

            //    if ((aa + bb) == cc)
            //    {
            //        sw.WriteLine("Scenario #"+i+":");
            //        sw.WriteLine("yes");
            //    }
            //    else
            //    {
            //        sw.WriteLine("Scenario #" + i + ":");
            //        sw.WriteLine("no");
            //    }
            //    sw.WriteLine("");
            //}
            //sr.Close();
            //sw.Close();

            //주차의 신

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int[] arr;
            //int sum = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    int number = int.Parse(sr.ReadLine());
            //    arr = new int[number];
            //    string shops = sr.ReadLine();
            //    for (int j = 0; j < number  ; j++)
            //    {
            //        int a = int.Parse(shops.Split()[j]);
            //        arr[j] = a;
            //    }
            //    Array.Sort(arr);
            //    for (int k = 0; k < arr.Length-1; k++)
            //    {
            //        int kk = arr[k + 1] - arr[k];
            //        sum += kk;
            //    }
            //    int tmp = arr[arr.Length-1] - arr[0];
            //    sw.WriteLine(tmp + sum);
            //    sum = 0;
            //    Array.Clear(arr,0,arr.Length);
            //}
            //sr.Close();
            //sw.Close();

            //숫자의 개수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //ulong A = ulong.Parse(sr.ReadLine());
            //ulong B = ulong.Parse(sr.ReadLine());
            //ulong C = ulong.Parse(sr.ReadLine());
            //ulong ret = A * B * C;
            //string text = ret.ToString();
            //int cnt = 0;
            //int count = 0;
            //int zero = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    cnt++;
            //}
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i].ToString() == "0") 
            //    { 
            //        zero++;
            //    }
            //}
            //sw.WriteLine(zero);

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 0; j < text.Length; j++)
            //    {
            //        if (text[j].ToString() == i.ToString())
            //        {
            //            count++;
            //        }
            //    }
            //    sw.WriteLine(count);
            //    count = 0;
            //}
            //sr.Close();
            //sw.Close();

            //일우는 야바위꾼

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            ////N : n개의 컵
            //int N = int.Parse(text.Split()[0]);
            ////X : x번쨰에 공을 숨김
            //int X = int.Parse(text.Split()[1]);
            ////K : k번 반복
            //int K = int.Parse(text.Split()[2]);

            ////먼저 N개의 컵 숫자를 배열에 넣어준다
            //int[] cups = new int[N];
            //for (int i = 1; i <= N; i++)
            //{
            //    cups[i - 1] = i;
            //}
            //int cnt = 0;
            //for (int i = 0; i < K; i++)
            //{
            //    string change = sr.ReadLine();

            //    int a = int.Parse(change.Split()[0]);
            //    int b = int.Parse(change.Split()[1]);

            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            if(a == cups[j] && b == cups[k])
            //            {
            //                sw.WriteLine("a "+cups[j]);
            //                sw.WriteLine("b  " + cups[k]);

            //                int tmp = cups[j];
            //                cups[j] = cups[k]; ;
            //                cups[k] = tmp;
            //            }
            //            //cnt++;
            //        }
            //        //cnt = 0;
            //    }
            //}
            //int ret = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    if (cups[i] == X)
            //    {
            //        ret = Array.IndexOf(cups,X);
            //    }
            //}
            //sw.WriteLine(ret+1);

            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //while (true)
            //{
            //    string num = sr.ReadLine();
            //    string[] t = num.Split();
            //    int a = int.Parse(t[0]);
            //    int b = int.Parse(t[1]);
            //    int c = int.Parse(t[2]);

            //    if (a == 0 && b == 0 && c == 0)
            //    {
            //        break;
            //    }

            //    long ap1 = c - b;
            //    long ap2 = b - a;
            //    long gp1 = c / b;
            //    long gp2 = b / a;

            //    if (ap1 == ap2)
            //    {
            //        sw.WriteLine("AP " + (c + ap1));
            //    }
            //    else if (gp1 == gp2)
            //    {
            //        sw.WriteLine("GP " + (c * gp1));
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //long middle = 0;
            //long mul = 0;
            //long add = 0;
            //while(true)
            //{
            //    string num = sr.ReadLine();
            //    long a = long.Parse(num.Split()[0]);
            //    long b = long.Parse(num.Split()[1]);

            //    if (a == 0 && b == 0)
            //    {
            //        break;
            //    }

            //    if (a > b)
            //    {
            //        middle = b;
            //    }
            //    else if(a < b)
            //    {
            //        middle = a;
            //    }
            //    else
            //    {
            //        middle = a;
            //    }
            //    mul = middle * 3;
            //    add = a + b;
            //    long ret = mul - add;
            //    sw.WriteLine(ret);
            //}
            //sr.Close();
            //sw.Close();

            //삼각무늬
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string triangle = sr.ReadLine();
            //    int big = int.Parse(triangle.Split()[0]);
            //    int small = int.Parse(triangle.Split()[1]);

            //    float bigger = (float)big * big / 2;
            //    float smaller = (float)small * small / 2;
            //    float ret = bigger / smaller;
            //    sw.WriteLine(ret);
            //}
            //sr.Close();
            //sw.Close();

            //가뭄
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string rain = sr.ReadLine();
            //float ab = float.Parse(rain.Split()[0]);
            //float ac = float.Parse(rain.Split()[1]);
            //float bc = float.Parse(rain.Split()[2]);

            //float A_section = ((ab / 2) + (ac / 2)) / 2f;
            //float B_section = ((ac / 2) + (bc / 2)) / 2f;
            //float C_section = ((ac / 2) + (bc / 2)) / 2f;

            //if(A_section/2 == B_section/2 && B_section / 2 == C_section /2)
            //{
            //    sw.WriteLine("1");
            //    sw.Write(A_section + " " + B_section + " " + C_section);
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //while(true)
            //{
            //    string text = sr.ReadLine();
            //    if(String.IsNullOrWhiteSpace(text))
            //    {
            //        break;
            //    }
            //    sw.WriteLine(text);
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string txt  = sr.ReadLine();
            //string[] text = new string[txt.Length+1];
            //for (int i = 0; i < txt.Length; i++)
            //{
            //    text[i] = txt[i].ToString();
            //    //sw.WriteLine(text[i]);
            //}


            //string[] alphabet = new string[] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n",
            //                                    "o","p","q","r","s","t","u","v","w","x","y","z"};
            //for (int i = 0; i < alphabet.Length; i++)
            //{
            //    for (int j = 0; j < text.Length; j++)
            //    {
            //        if (text[j] == alphabet[i])
            //        {
            //            int arr = Array.IndexOf(text, alphabet[i]);

            //            //int array = Array.FindIndex(text, x => x.Equals(alphabet[i]));
            //            if (text[j] == text[j+1])
            //            {
            //                Array.Clear(text, j, 2);
            //            }
            //            sw.Write(arr);
            //            //sw.Write(array);
            //        }
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //while(true)
            //{
            //    string text = sr.ReadLine();
            //    if(String.IsNullOrWhiteSpace(text))
            //    {
            //        break;
            //    }
            //    int a = int.Parse(text.Split()[0]);
            //    int b = int.Parse(text.Split()[1]);
            //    sw.WriteLine(a+b);
            //}
            //sr.Close();
            //sw.Close();

            //행렬덧셈
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //int a = int.Parse(text.Split()[0]);
            //int b = int.Parse(text.Split()[1]);
            //int[,] arr = new int[a*2,b];
            //int u = 0;
            //int l = 0;

            //for (int i = 0; i < a * 2; i++)
            //{
            //    string num = sr.ReadLine();
            //    for (int j = 0; j < b; j++)
            //    {
            //        int temp = int.Parse(num.Split()[j]);
            //        arr[i,j] = temp;
            //    }
            //}

            //int[,] array = new int[100 * 2, 100 * 2];
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        array[i, j] = arr[i, j] + arr[i+a, j];
            //        sw.Write(array[i, j] + " ");
            //    }
            //    sw.WriteLine("");
            //}
            //sr.Close();
            //sw.Close();

            //알파벳찾기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //string[] input = new string [text.Length];
            //string[] alphabet = new string[26] {"a","b","c","d","e","f","g","h","i","j","k", 
            //                                    "l","m","n","o","p","q","r","s","t","u","v",
            //                                    "w","x","y","z"};
            //int cnt = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    input[i] = text[i].ToString();
            //}

            //for (int i = 0; i < alphabet.Length; i++)
            //{
            //    for (int j = 0; j < input.Length; j++)
            //    {
            //        //if (text[i].ToString().Contains(alphabet[j]))
            //        //{
            //        //    int ret = Array.IndexOf(alphabet, text[i].ToString());
            //        //    sw.Write(ret+" ");
            //        //}

            //        if (input[j] == alphabet[i])
            //        {

            //            //int ret = Array.IndexOf(alphabet, input[i]);
            //            sw.Write(j + " ");
            //            cnt = 0;
            //            break;
            //        }
            //        else
            //        {
            //            cnt = 1;
            //        }
            //    }
            //    if(cnt == 1)
            //    {
            //        sw.Write("-1 ");
            //    }
            //}

            ////sw.Write(cnt);
            //sr.Close();
            //sw.Close();

            //문자열 반복

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int num = int.Parse(sr.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    string text = sr.ReadLine();
            //    int a = int.Parse(text.Split()[0]);
            //    string b = text.Split()[1];
            //    for (int j = 0; j < b.Length; j++)
            //    {
            //        for (int k = 0; k < a; k++)
            //        {
            //            sw.Write(b[j]);
            //        }
            //    }
            //    sw.WriteLine("");
            //}
            //sr.Close();
            //sw.Close();

            //숫자의 합
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string number = sr.ReadLine();
            //string[] arr = new string[number.Length];
            //int sum = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    arr[i] = number[i].ToString();
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int a = int.Parse(arr[i]);
            //    sum += a;
            //}
            //sw.WriteLine(sum);
            //sr.Close();
            //sw.Close();

            //음계

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //int[] arr = new int[8];
            //int cnt = 0;
            //int count = 0;
            //for (int i = 0; i < 8; i++)
            //{
            //    int temp = int.Parse(text.Split()[i]);
            //    arr[i] = temp;
            //}
            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    if (arr[i] < arr[i+1])
            //    {
            //        cnt++;
            //    }
            //    else if (arr[i] > arr[i+1])
            //    {
            //        count++;
            //    }
            //}
            //if(cnt >=7)
            //{
            //    sw.WriteLine("ascending");
            //}
            //else if( count >=7)
            //{
            //    sw.WriteLine("descending");
            //}
            //else if( cnt < 7 || count < 7)
            //{
            //    sw.WriteLine("mixed");
            //}
            //sr.Close();
            //sw.Close();

            //ox 퀴즈

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string[] symbol = new string[80];
            //int cnt = 0;
            //int sum = 0;

            //for (int i = 0; i < num; i++)
            //{
            //    string OX = sr.ReadLine();
            //    for (int j = 0; j < OX.Length; j++)
            //    {
            //        symbol[j] = OX[j].ToString();
            //    }
            //    for (int k = 0; k < symbol.Length; k++)
            //    {
            //        if (symbol[k] == "O")
            //        {
            //            cnt++;
            //            sum += cnt;
            //        }
            //        else
            //        {
            //            cnt = 0;
            //        }
            //        //sw.WriteLine(sum);

            //    }
            //    sw.WriteLine(sum);
            //    Array.Clear(symbol,0,symbol.Length);
            //    sum = 0;
            //    cnt = 0;
            //}
            //    sr.Close();
            //    sw.Close();

            //최소, 최대
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string number = sr.ReadLine();
            //string[] s = number.Split();
            //int[] arr = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    int a = int.Parse(s[i]);
            //    arr[i] = a;
            //}
            //Array.Sort(arr);
            //sw.WriteLine(arr[0] + " " + arr[arr.Length-1]);
            //sr.Close();
            //sw.Close();

            //나머지
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[] arr = new int[10];
            //int cnt = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    int num = int.Parse(sr.ReadLine());
            //    int ret = num % 42;
            //    arr[i] = ret;
            //}


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] != arr[j])
            //        {
            //            cnt++;
            //        }
            //    }
            //}

            //sw.WriteLine(cnt);

            //sr.Close();
            //sw.Close();

            //별찍기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string star = "*";
            //for (int i = 1; i <= num; i++)
            //{
            //    for (int j = 0; j < num-i; j++)
            //    {
            //        sw.Write(" ");
            //    }
            //    for (int k = 0; k < i; k++)
            //    {
            //        sw.Write(star);
            //    }
            //    sw.WriteLine();
            //}

            //sr.Close();
            //sw.Close();

            //숫자의 개수

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int a = int.Parse(sr.ReadLine());
            //int B = int.Parse(sr.ReadLine());
            //int C = int.Parse(sr.ReadLine());
            //int mul = a * B * C;
            //string multiply = mul.ToString();
            //int cnt = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < multiply.Length; j++)
            //    {
            //        if (multiply[j].ToString() == i.ToString())
            //        {
            //            cnt++;
            //        }
            //    }
            //    sw.WriteLine(cnt);
            //    cnt = 0;
            //}
            //sr.Close();
            //sw.Close();

            //상수
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //string a = text.Split()[0];
            //string b = text.Split()[1];

            //string[] Aarr = new string[a.Length];
            //string[] Barr = new string[b.Length];

            //for (int i = 0; i < 3; i++)
            //{
            //    Aarr[i] = a[i].ToString();
            //    Barr[i] = b[i].ToString();
            //}
            //Array.Reverse(Aarr);
            //Array.Reverse(Barr);
            //int Aret = int.Parse(Aarr[0] + Aarr[1] + Aarr[2]);
            //int Bret = int.Parse(Barr[0] + Barr[1] + Barr[2]);
            //if(Aret > Bret)
            //{
            //    sw.WriteLine(Aret);
            //}
            //else
            //{
            //    sw.WriteLine(Bret);
            //}
            //sr.Close();
            //sw.Close();

            //나머지

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    int a = int.Parse(sr.ReadLine());
            //    int ret = a % 42;
            //    arr[i] = ret;
            //    //sw.WriteLine(arr[i]);
            //}
            //int cnt = 0;
            //int result = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            cnt++;
            //        }
            //    }
            //    if(cnt == 0)
            //    {
            //        result++;
            //    }
            //    cnt = 0;
            //}
            //sw.WriteLine(result);
            //sr.Close();
            //sw.Close();

            //단어공부

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string[] alphabet = new string[]
            //{
            //    "a","A","b","B","c","C","d","D","e","E","f","F","g","G",
            //    "h","H","i","I","j","J","k","K","l","L","m","M","n","N",
            //    "o","O","p","P","q","Q","r","R","s","S","t","T","u","u",
            //    "v","V","w","x","y","Y","z","Z",
            //};

            //string text = sr.ReadLine();
            //string[] tArr = new string[text.Length];
            //for (int i = 0; i < text.Length; i++)
            //{
            //    tArr[i] = text[i].ToString();
            //}
            //string[] newArr = new string[tArr.Length];
            //int cnt = 0;
            //for (int i = 0; i < tArr.Length; i++)
            //{
            //    for (int j = 0; j < alphabet.Length; j++)
            //    {
            //        if (tArr[i] == alphabet[j])
            //        {
            //            newArr[i] = alphabet[j];
            //        }
            //    }
            //}
            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    sw.WriteLine(newArr[i]);
            //}

            //sr.Close();
            //sw.Close();



            //평균
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string score = sr.ReadLine();
            //float[] ret = new float[num];

            //for (int i = 0; i < num; i++)
            //{
            //    float a = float.Parse(score.Split()[i]);
            //    ret[i] = a;
            //}
            //Array.Sort(ret);
            //float average = 0f;
            //for (int i = 0; i < num; i++)
            //{
            //    float result = (float)(ret[i] / ret[ret.Length - 1]) * 100f;
            //    average += result;
            //}
            //sw.WriteLine(average/num);
            //sr.Close();
            //sw.Close();

            //킹, 퀸, 룩, 비숍, 나이트, 폰

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string text = sr.ReadLine();
            //int[] intArr = new int[6];
            //for (int i = 0; i < 6; i++)
            //{
            //    int a = int.Parse(text.Split()[i]);
            //    intArr[i] = a;
            //    //sw.WriteLine(intArr[i]);
            //}

            //int King = 1;
            //int Queen = 1;
            //int Rook = 2;
            //int Bishop = 2;
            //int Knight = 2;
            //int Pawn = 8;

            //sw.WriteLine((King - (intArr[0])) + " " + (Queen - (intArr[1]))
            //            +" "+ (Rook - (intArr[2])) + " " + (Bishop - (intArr[3])
            //            + " " + (Knight - (intArr[4])) + " " + (Pawn - (intArr[5]))));
            //sr.Close();
            //sw.Close();

            //Share
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //while(true)
            //{
            //    string text = sr.ReadLine();
            //    if(string.IsNullOrEmpty(text))
            //    {
            //        break;
            //    }
            //    long a = long.Parse(text.Split()[0]);
            //    long b = long.Parse(text.Split()[1]);
            //    long ret = b / (a+1);

            //    sw.WriteLine(ret);
            //}
            //sr.Close();
            //sw.Close();

            //아!
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string jText = sr.ReadLine();
            //string docter = sr.ReadLine();
            //if(jText.Length-1 >= docter.Length-1)
            //{
            //    sw.WriteLine("go");
            //}
            //else
            //{
            //    sw.WriteLine("no");
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int cnt = 0;
            //int sum = 0;
            //while(true)
            //{
            //    int num = int.Parse(sr.ReadLine());
            //    if(num == 0)
            //    {
            //        break; 
            //    }
            //    cnt = num;
            //    while(true)
            //    {
            //        sum += cnt;
            //        cnt--;
            //        if(cnt == 0)
            //        {
            //            break;
            //        }
            //    }
            //    sw.WriteLine(sum);
            //    sum = 0;
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[] dish = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    int num = int.Parse(sr.ReadLine());
            //    dish[i] = num;
            //}
            //Array.Sort(dish);
            //sw.WriteLine(dish[1]);
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //sw.WriteLine(text[2].ToString() + text[1].ToString() + text[0].ToString());
            //sr.Close();
            //sw.Close();

            //단어공부
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string text = sr.ReadLine();
            //string[] tex = new string[text.Length];
            //for (int i = 0; i< text.Length;i++) 
            //{
            //    tex[i] = text[i].ToString().ToLower();
            //}

            //int cnt = 0;
            //List<int> list = new List<int>();
            //for (int i = 0; i < tex.Length; i++)
            //{
            //    for (int j = 0; j < tex.Length; j++)
            //    {
            //        if (tex[i] == tex[j])
            //        {
            //            cnt++;
            //        }
            //    }
            //    list.Add(cnt);
            //    cnt = 0;
            //}
            //int a = list.Max();
            //int index = list.FindIndex(x=>x==a);
            //int count = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] == a)
            //    {
            //        count++;
            //    }
            //}
            ////sw.WriteLine(count);
            //if(count <= a)
            //{
            //    sw.WriteLine(tex[index].ToUpper());
            //}
            //else
            //{
            //    sw.WriteLine("?");
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int a = (num + 1) * 2;
            //int b = (num + 1) * 3;
            //sw.WriteLine(a +" "+ b);
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int total = int.Parse(sr.ReadLine());
            //int num = int.Parse(sr.ReadLine());

            //int a = (total+num)/2;
            //int b = (total-num)/2;
            //sw.WriteLine(a);
            //sw.WriteLine(b);
            //sr.Close();
            //sw.Close();

            //Console.WriteLine("고려대학교");

            //         Console.WriteLine(@"                                                           :8DDDDDDDDDDDDDD$.                                           
            //                                                   DDDNNN8~~~~~~~~~~=~7DNNDNDDDNNI                                   
            //                                               ?NNDD=~=~~~~~~~~~~~~~~~~~=~~==~=INNDNN7                               
            //                                            +NDDI~~~~~~~~~~~~~~~~~~~~~~~=~~========~ODND+                            
            //                                         :NND~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~============7NDN                          
            //                                       $DD$~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~==============~DNN                        
            //                                     $DD=~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~=================NND                      
            //                                    ND7~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~===================DD7                    
            //                                  ~DD=~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=======================8DN.                  
            //                                 8DO~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=========================DD                  
            //                                8N~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~=~~=======================DN                 
            //                               NN::::::::~~~~~~~~~~~=~~~~~~~~~~~~~~~~~~~=~~========================DDO               
            //                              $D$:::::::::::::::~~~~DD~~~~~~~~~~~~~~~~~~=~~=========================DN.              
            //                              D8:::::::::::::::::::DN=::~~~~~~~~~~~~~~~~=~~======================~~:~DN              
            //                             DN:::::::::::::::::::ONO::::::::::::::::::::~~~~~~~~~~~~:::::::::::::::::DN             
            //                            DN::::::::::::::::::::NN.:::::::::::::::::::::::::::DN::::::::::::::::::::$DO            
            //                            DD:::::::::::::::::::DNI:::::::::::::::::::::::::::::D=::::::::::::::::::::NN            
            //                           NN~~~~:::::$N?:::::::.NN::::::::::::::::::::::::::::::ND.:::::::::::::::::::+N8           
            //                           N7~~~~~~~~OD7::::::::~DD::::::::::::::::::::::::::::::~D$::::::::::::::::::::DN           
            //                          NN~~~~~~~~IDZ~~~~~::::DN~:::::::::::::::::::::::::::::::DN::::::::::::::::::::=N~          
            //                          DD~~~~~~~~NN~~~~~~~~~=NN::::::::::::::::::::::::::::::::DN:::::::::::::::~~====NN          
            //                         8D~~~~~~~~ND~~~~~~~~~~~ND~~~~~~~~:::::::::::::::::::::::::N7:::~~===============NN          
            //                         DD~~~~~~~ON+~~~~~~~~~~~ND~~~~~~~~~~~~~~~~~~~=+NZ==========NN====================~ND         
            //            :DD7   DNDD. N8~~~~~~~NN~~~~~~~~~~DDND~~~~~~~~~~~~~~~~~~~~ND~~=========DD=====================ND         
            //            N~:DDNNN .8NDN~~~~~~~$D=~~~~~~~~+ND.DD~~~~~~~~~~~~~~~~~~~=DD~~=========~D+====================DN         
            //           :D     .  ..~ND~~~~~~~NN~~~~~~~+NN$..ND~~~~~~~~~~~~~~~~~~~7N=~~=========~ND=======~============ON         
            //           NN       ...:N?~~~~~~~N=~~~~~NNNI.. .7D+~~~~~~~~~~~~~~~~~=8NN~~==========NN=======N============$N         
            //      N  ODN       ....DN~~~~~~~DD=8NNND$..     .DD~~~=~~~~~~~~~~~~~=NNDD=~=========8D~======NN===========~N$        
            // N? =NN  ND      .....NND~~~~~~~DDNN:...        .ND=~DNN~~~~~~~~~~~~=DN.DN~=========?N+======NN============ND        
            //$D? DN    DZ    ....ND8NN~~~~~~$D                .DD~NNDD~~~~~~~~~~~~D8..DN=========~DN======NN============DN        
            //DN ~N~   NN    ..:~NN..NZ~~~~~~DN                  NNN8.ND~~~~NDN?~~~DZ...7DD=======~NN======NN============DN        
            //ND DD    :DN.  ..ND$  .N?~~~~~=NNN                   . ..DDD$~N8OND8=N+   ..DDDZ~====NN======+D+===========ND        
            //NO         DD  ZDN    8NO~~~~~~NNN..DDDNN7               ...NND...:DDD:     .:.NDND=~DD======~DO===========DN        
            //           DNDDN:.    DN~~~~~~=NNNN.ODNNNNDDNNO              ...     .         ...DNNNN=======ND===========DD        
            //    INDN7    DD.     .DD~~~~~=IDND:.:~.....?DNDNN.                        ...... ....$D=======ND===========ND        
            //    NN        ND.    8N=~~~~$ND::.:=~:.~=......=ND~                 .NNNNNNNNNNNNNNN.~N+======NN===========DN        
            //    $DD        DN:   DD~~~~7NO...~==.:~~:.....                      NNNND? ..::..7NZ.:N?======8D~==========ZN        
            //    DN?     ~D: DND.?D~~~~~DD....~:.~=~.......                            ....~=:.:~..ND======~N$==========~DO       
            //    ND    ..DD.  .DNDN=~~~~DI.......:.........                           ....=~..~~~..DN======~DD===========NN       
            //    DDD  :.:DD.  . DDI~~~~~ND................        .DNNNNNNNNNN7      ....=~:.:~~...NN=======ND===========?D~      
            //    8D. ...OD..    DD~~~~~~+ND ............          NN:~::::~~~8N      ........~~...:ND=======DN============NN      
            //    DDI:...ND     .D7~~~~~~~7NN ..........           ID8::::::::8D      .............:DN=======ON============NN      
            //     ~NNND.N=.   .NN~~~~~~~~~NDN8                       ~::::::~N8       .............DN========D=============NI     
            //            DDNNN.ND~~~~~~~~DD =DND                                       ............DN========N+~===========NN     
            //                ~:N=~~~~~~~~DD   .DDDD                                       ........ NN========DD============8D     
            //                 8N~~~~~~~~~ND    . .7NDDD? .                                      .8DDN========NN=============D:    
            //                 DD~~~~~~~~~DND:         IDNNND$.                           .+DNNNNDNIDN========DD=============DD    
            //                 ND~~~~~~~~ZN 7DD .. .:DDNDDNNDNNNNDDNDND8$?===+$8DDNNNDDDDDN8I~DN====8N========NN=============NN    
            //                 DD~~~~~~~~8N   DD.  .NN~~~~.~~=DNDNO.:7ODDDDNNDD8DDDND=~~~ =~~~ON====8N========DN=============DN    
            //                 ND~~~~~~~~DN    ZDD  DN~~~ ~~~~~=.7DDD+.......8NNN==~~~~~ ~~~~~ONN$==DN========8N=============ON    
            //                 ND~8N~=~~~ZN      DDODN=~.~~~~~=.~~~~INDNNNNDNN~~~~~~~~:~~~~~~~DN~ND=DN========DD=========~ND=8N    
            //                 IN=NDDI~~~~D8       DNN::~~~~~.~~~~~=.~~ND~~ND~~~~~~~~.~~~~~~~~NN  NDNN====ND==ND~D?======DNN=ND    
            //                  DNNI8ND=~~DN:       ZN=~~~~~ ~~~~~.~~~~DD~=DD~~~~~~~ ~~~~~~~=.ND. . ND===DNDD=NDDNN=====8NZDDDN    
            //                   NND  IDNDNNN+       D+~~~:~~~~~~ ~~~~~DDNNN+~~~~~~~~~~~~~~:=?N7   .ND=~ND  DNNN~ID====ND7 NNN     
            //                    ID                 ND~~ ~~~~~:.~~~7DDN7IDNN==~~ ~~~~~~~~ ~~DN   .:N?DDDDD NND  8N~=DDD  ZNN      
            //                                       NN~:~~~~~ =7DDDD+8N  :N8DDZ.~~~~~~~~.~~~DD.   NDD+ . DN=     OND+             
            //                                       DND~~~=8DNDDZ=~~ ND   NN~INND~~~~~.~~~~ND .    .    ..IDD                     
            //                                      DDNNNDNNN+~~~~~~.7N.    ND~~~NDDI~ ~~~~=NNN             .DDI                   
            //                                     DN=~~~~.=~~~~~~ ~~DN     +N+~~~~+DNDD~~~NNNND.            ..ND                  
            //                                      DDI~~ ~~~~~~~ ~~~ND..  ..ND~~~~:~~~DNDNNNN+            ..7O8ND+                
            //                                       .DND=~~~~=::~~=NN.   . . 8D~~.~~~~~~=DN$ODNDNDNNNDNNNNND8+~..                 
            //                                          8DNNI=.~~~~=NDDNNNNDDNDNN.~~~~~IDDNDND7:.                                  
            //                                             ?DNNDD?~DD          ~NN~~=NDD$                                          
            //                                                  :DDD.            NNNN=     ");


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int[] num = new int[5];
            //int[] ret = new int[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    string text = sr.ReadLine();
            //    for (int j = 0; j < 5; j++)
            //    {
            //        int a = int.Parse(text.Split()[j]);
            //        num[j] = a;
            //    }
            //    ret[i] =((num[0] * 6) + (num[1] * 3) + (num[2] * 2) + (num[3] * 1) + (num[4] * 2));
            //}
            //sw.WriteLine(ret[0] + " "+ret[1]);
            //sr.Close();
            //sw.Close();

            //추론
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //long num = long.Parse(sr.ReadLine());
            //long[] intArr = new long[num];
            //for (int i = 0; i < num; i++)
            //{
            //    int number = int.Parse(sr.ReadLine());
            //    intArr[i] = number;
            //}
            //long diff = intArr[1] - intArr[0];
            //long div = intArr[1] / intArr[0];
            ////sw.WriteLine(div);
            //if (intArr[intArr.Length-1] - intArr[intArr.Length-2] == diff)
            //{
            //    sw.WriteLine(intArr[intArr.Length - 1] + diff);
            //}
            //else if(intArr[intArr.Length - 1] / intArr[intArr.Length - 2] == div)
            //{
            //    sw.WriteLine(intArr[intArr.Length - 1] * div);
            //}
            //sr.Close();
            //sw.Close();

            //팬그램

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //string[] alphabet = new string[26] {"a","b","c","d","e","f","g","h","i","j","k",
            //                                  "l","m","n","o","p","q","r","s","t","u","v"
            //                                    ,"w","x","y","z"};
            //int cnt = 0;
            //while(true)
            //{
            //    string text = sr.ReadLine();
            //    if(text=="*")
            //    {
            //        break;
            //    }
            //    for (int i = 0; i < alphabet.Length; i++)
            //    {
            //        for (int j = 0; j < text.Length; j++)
            //        {
            //            if (text[j].ToString() == alphabet[i])
            //            {
            //                cnt++;
            //                break;
            //            }
            //        }
            //    }

            //    if(cnt>=26)
            //    {
            //        sw.WriteLine("Y");
            //    }
            //    else
            //    {
            //        sw.WriteLine("N");
            //    }
            //    //sw.WriteLine(cnt);
            //    cnt = 0;
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int[] intArr = new int[3];
            //string[] stringArr = new string[3];

            //string text1 = sr.ReadLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    int a = int.Parse(text1.Split()[i]);
            //    intArr[i] = a;
            //}

            //string text2 = sr.ReadLine();
            //for (int i = 0; i < 3; i++)
            //{
            //    string b = text2[i].ToString();
            //    stringArr[i] = b;
            //}
            //Array.Sort(intArr);
            //Array.Sort(stringArr);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (text2[i].ToString() == stringArr[j])
            //        {
            //            sw.Write(intArr[j] + " ");
            //        }
            //    }
            //}

            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int cnt = 0;
            //int count = 1;
            //for (int i = 0; i < num; i++)
            //{
            //    int room = int.Parse(sr.ReadLine());

            //    for (int j = 0; j < room; j++)
            //    {
            //        while(true)
            //        {
            //            double mul = Math.Pow(count, 2);
            //            count++;
            //            if(mul>room)
            //            {
            //                break;
            //            }
            //            cnt++;
            //        }
            //    }
            //    sw.WriteLine(cnt);

            //}

            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int times = 5;
            //int cnt = 0;
            //while(true)
            //{
            //    if(times<0||num==0)
            //    {
            //        break;
            //    }
            //    if (num >= times)
            //    {
            //        int a = num - times;
            //        num = a;
            //        //sw.WriteLine(num);
            //        cnt++;
            //    }
            //    else
            //    {
            //        times--;
            //    }
            //}
            //sw.WriteLine(cnt);
            //sr.Close();
            //sw.Close();


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //int smile = 0;
            //int sad = 0;

            //for (int i = 0; i < text.Length - 2; i++)
            //{
            //    if (text[i].ToString() == ":")
            //    {
            //        if (text[i+1].ToString() == "-" && text[i + 2].ToString() == ")")
            //        {
            //            smile++;
            //            //sw.WriteLine("smile " + smile);
            //        }
            //        else if (text[i+1].ToString() == "-" && text[i + 2].ToString() == "(")
            //        {
            //            sad++;
            //            //sw.WriteLine("sad " + sad);
            //        }
            //    }
            //}
            //if (smile == 0 && sad == 0)
            //{
            //    sw.WriteLine("none");
            //}else if(smile>sad)
            //{
            //    sw.WriteLine("happy");
            //}else if(smile<sad)
            //{
            //    sw.WriteLine("sad");
            //}else if(smile==sad)
            //{
            //    sw.WriteLine("unsure");
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string[] cambridge = new string[9] { "C", "A", "M", "B", "R", "I", "D", "G", "E" };
            //string text = sr.ReadLine();
            //string[] same = new string[text.Length];
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int j = 0; j < cambridge.Length; j++)
            //    {
            //        if (text[i].ToString() == cambridge[j])
            //        {
            //            same[i] = cambridge[j];
            //            string tmp = text.Replace(text[i],'x');
            //            text = tmp;
            //        }
            //    }
            //}
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i].ToString()!="x")
            //    {
            //        sw.Write(text[i]);
            //    }
            //}
            //sw.WriteLine(" ");
            //sr.Close();
            //sw.Close();

            //단어공부

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //int cnt = 0;
            //string[] stringArr1 = new string[text.Length];
            //string[] stringArr2 = new string[text.Length];
            ////받은 문자열을 소문자로 바꿔준다
            //for (int i = 0; i < text.Length; i++)
            //{
            //    stringArr1[i] = text[i].ToString().ToLower();
            //    stringArr2[i] = text[i].ToString().ToLower();
            //}
            ////중복된 값을 없애고 배열에 담아준다
            //string[] tmp = stringArr2.Distinct().ToArray();
            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //for (int i = 0; i < tmp.Length; i++)
            //{
            //    for (int j = 0; j < stringArr1.Length; j++)
            //    {
            //        if (tmp[i] == stringArr1[j])
            //        {
            //            cnt++;
            //        }
            //    }
            //    dic.Add(tmp[i], cnt);
            //    cnt = 0;
            //}
            //int max = dic.Values.Max();
            //int count = 0;
            //foreach (var item in dic)
            //{
            //    if (item.Value == max)
            //    {
            //        count++;
            //    }
            //}
            //if (count > 1)
            //{
            //    sw.WriteLine("?");
            //}
            //else
            //{
            //    foreach (var item in dic)
            //    {
            //        if (item.Value == max)
            //        {
            //            sw.WriteLine(item.Key.ToUpper());
            //        }
            //    }
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int[] numbers = new int[num];
            //int[] max = new int[num];
            //string a = sr.ReadLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int b = int.Parse(a.Split()[i]);
            //    numbers[i] = b;
            //}
            //int index = 0;
            //int stop = 0;
            //for (int i = 0; i < numbers.Length-1; i++)
            //{
            //    if (numbers[i] < numbers[i+1])
            //    {
            //        int ret = numbers[i + 1] - numbers[i];
            //        index += ret;
            //        max[stop] = index;
            //        //sw.WriteLine(max[stop]);
            //    }else if (numbers[i] >= numbers[i+1])
            //    {

            //        stop++;
            //        index = 0;
            //    }
            //}
            //int maximum = max.Max();
            //sw.WriteLine(maximum);
            //sr.Close();
            //sw.Close();

            //알람시계

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //int a = int.Parse(text.Split()[0]);
            //int b = int.Parse(text.Split()[1]);

            //b -= 45;
            //if(b<0)
            //{
            //    b += 60;
            //    a -= 1;
            //    if(a<0)
            //    {
            //        a = 23;
            //    }
            //}
            //sw.WriteLine(a + " " + b);
            //sr.Close();
            //sw.Close();

            //수 정렬하기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int[] intArr = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    int a = int.Parse(sr.ReadLine());
            //    intArr[i] = a;
            //}
            //Array.Sort(intArr);
            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    sw.WriteLine(intArr[i]);
            //}
            //sr.Close();
            //sw.Close();

            //소수찾기

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string text = sr.ReadLine();
            //int[] s = new int[1000];
            //for (int i = 0; i < num; i++)
            //{
            //    int a = int.Parse(text.Split()[i]);
            //    s[i] = a;
            //}
            //int ss = 0;
            //int cnt = 0;
            //for (int i = 2; i <= s.Length; i++)
            //{
            //    if (s[i-1] == 2)
            //    {
            //        cnt++;
            //    }
            //    else if (s[i-1]%i==1)
            //    {
            //        ss++;
            //    }
            //    if(ss==1)
            //    {
            //        cnt++;
            //    }
            //    ss = 0;
            //}
            //sw.WriteLine(cnt);


            //sr.Close();
            //sw.Close();

            //카드버리기
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //Queue<int> queue = new Queue<int>();
            //for (int i = 1; i <= num; i++)
            //{
            //    queue.Enqueue(i);
            //}

            //while(true)
            //{
            //    if(queue.Count == 1)
            //    {
            //        break;
            //    }
            //     //sw.WriteLine(queue.Dequeue());
            //     queue.Dequeue();

            //     //sw.WriteLine(queue.Peek());
            //     queue.Enqueue(queue.Peek());

            //    //sw.WriteLine(queue.Dequeue());
            //    queue.Dequeue();
            //}

            //for (int i = 0;i < 1; i++)
            //{
            //    sw.WriteLine(queue.Dequeue());
            //}
            //sr.Close();
            //sw.Close();


            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            //int num = int.Parse(sr.ReadLine());
            //int cnt = num;
            //int number = 0;
            //int five = 0;
            //int three = 0;
            //while(true)
            //{
            //    if(cnt<=0)
            //    {
            //        break;
            //    }
            //    if (cnt>5)
            //    {
            //        cnt -= 5;
            //        number++;
            //        five++;
            //    }
            //    else if (cnt % 3 == 0 || cnt > 3)
            //    {
            //        cnt -= 3;
            //        number++;
            //        three++;
            //    }
            //}

            //if (cnt == 0)
            //{
            //    sw.WriteLine(number);
            //}
            //else
            //{
            //    sw.WriteLine("-1");
            //}


            //sr.Close();
            //sw.Close();



            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //string text = sr.ReadLine();
            //int n = int.Parse(text.Split()[0]);
            //int k = int.Parse(text.Split()[1]);
            //Queue<int> queue = new Queue<int>();
            //for (int i = 1; i <= n; i++)
            //{
            //    queue.Enqueue(i);
            //}
            //sw.Write("<");
            //while(true)
            //{
            //    for (int i = 1; i < k; i++)
            //    {
            //        queue.Enqueue(queue.Peek());
            //        queue.Dequeue();
            //    }
            //    sw.Write(queue.Dequeue());
            //    if(queue.Count==0)
            //    {
            //        sw.Write(">");
            //        break;
            //    }
            //    sw.Write(", ");
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //Stack<int> stack = new Stack<int>();
            //Stack<int> stack_another = new Stack<int>();
            //int[] number = new int[num];
            //for (int i = 0; i < num; i++)
            //{
            //    int a = int.Parse(sr.ReadLine());
            //    number[i] = a;
            //}
            //Array.Reverse(number);
            //for (int i = 0; i < number.Length; i++)
            //{
            //    stack.Push(number[i]);
            //}
            //while(true)
            //{
            //    if(stack.Peek() != 0)
            //    {
            //        stack_another.Push(stack.Peek());
            //        stack.Pop();
            //    }else
            //    if(stack.Peek() == 0)   
            //    {
            //        if(stack_another.Count>=1)
            //        {
            //            stack_another.Pop();
            //        }
            //        stack.Pop();
            //    }

            //    if(stack.Count == 0)
            //    {
            //        break;
            //    }
            //}
            //int sum = 0;
            //foreach (var item in stack_another)
            //{
            //    sum+=item;
            //}
            //foreach (var item in stack)
            //{
            //    sum += item;
            //}
            //sw.WriteLine(sum);
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //while (true)
            //{
            //    Stack<string> stack = new Stack<string>();
            //    Stack<string> stack_another = new Stack<string>();
            //    Stack<string> stack_other = new Stack<string>();

            //    int one = 0;
            //    int two = 0;
            //    string text = sr.ReadLine();
            //    if(text ==".")
            //    {
            //        break;
            //    }
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (text[i].ToString() == "(" || text[i].ToString() == "[")
            //        {
            //            one++;
            //            stack.Push(text[i].ToString());
            //        }
            //        else if(text[i].ToString() == ")" || text[i].ToString() == "]")
            //        {
            //            two++;
            //            stack_other.Push(text[i].ToString());
            //        }
            //    }
            //    while(true)
            //    {
            //        if(stack_other.Count==0)
            //        {
            //            break;
            //        }
            //        stack_another.Push(stack_other.Peek());
            //        stack_other.Pop();
            //    }
            //    sw.WriteLine(one);
            //    sw.WriteLine(two);
            //    sw.WriteLine(stack.Count);
            //    sw.WriteLine(stack_other.Count);
            //    int ret = one + two;
            //    //두개의 합이 홀수이면서 대칭이 아닌 것을 먼저 거른다
            //    if(ret%2!=0 || one != two)
            //    {
            //        sw.WriteLine("no");
            //    }
            //    else
            //    {
            //        //두개의 합이 짝수이면서 대칭이다
            //        //대칭인 경우도 )( 이렇게 대칭인 경우가 있음
            //        while (true)
            //        {
            //            if (stack.Count == 0)
            //            {
            //                sw.WriteLine("yes");
            //                break;
            //            }

            //            if (stack.Peek() == "(" && stack_another.Peek() == ")")
            //            {
            //                sw.WriteLine("([ " + stack.Count + ", " + stack_another.Count);
            //                stack.Pop();
            //                stack_another.Pop();
            //            }
            //            else if (stack.Peek() == "[" && stack_another.Peek() == "]")
            //            {
            //                sw.WriteLine(")] " + stack.Count + ", " + stack_another.Count);
            //                stack.Pop();
            //                stack_another.Pop();
            //            }
            //        }
            //    }
            //    one = 0;
            //    two = 0;

            //    stack.Clear();
            //    stack_another.Clear();
            //    stack_other.Clear();
            //}
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int price = int.Parse(sr.ReadLine());
            //int num = int.Parse(sr.ReadLine());
            //int cnt = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    string a = sr.ReadLine();

            //    int aa = int.Parse(a.Split()[0]);
            //    int bb = int.Parse(a.Split()[1]);
            //    int ret = aa * bb;

            //    cnt += ret;
            //}
            //if(cnt==price)
            //{
            //    sw.WriteLine("Yes");
            //}
            //else
            //{
            //    sw.WriteLine("No");
            //}
            //sr.Close();
            //sw.Close();

            //통계학
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //int[] intArr = new int[num];
            //int sum = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    int a = int.Parse(sr.ReadLine());
            //    sum += a;
            //    intArr[i] = a;
            //}
            //double one = (double)sum / num;
            //int average = num / 2;
            //Array.Sort(intArr);
            //int two = intArr[average];
            //int four = intArr[intArr.Length - 1] - intArr[0];

            //int cnt = 0;
            //int[] recentValue = new int[num]; 
            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    for (int j = 0; j < intArr.Length; j++)
            //    {
            //        if (intArr[i] == intArr[j])
            //        {
            //            cnt++;
            //        }
            //    }
            //    recentValue[i] = cnt;
            //    cnt = 0;
            //}
            //if(num == 1)
            //{
            //    sw.WriteLine(intArr[0]);
            //    sw.WriteLine(intArr[0]);
            //    sw.WriteLine(intArr[0]);
            //    sw.WriteLine("0");
            //}
            //else
            //{
            //    //산술평균
            //    if(one<0)
            //    {
            //        double min = -one;
            //        double rd1 = Math.Round(min);
            //        sw.WriteLine(-rd1);
            //    }
            //    else
            //    {
            //        double rd3 = Math.Round(one);
            //        sw.WriteLine(rd3);
            //    }

            //    //중앙값
            //    sw.WriteLine(two);

            //    //최빈값
            //    int even = 0;
            //    int max = recentValue.Max();
            //    int store = 0;
            //    int[] frequency = new int[num];
            //    for (int i = 0; i < recentValue.Length; i++)
            //    {
            //        if (recentValue[i]==max)
            //        {
            //            even++;
            //            frequency[i] = intArr[i];
            //        }
            //        else
            //        {
            //            frequency[i] = 4000;
            //        }
            //    }
            //    if(even>=1)
            //    {
            //        Array.Sort(frequency);
            //        int[] disArr = frequency.Distinct().ToArray();
            //        if(disArr.Length<3)
            //        {
            //            sw.WriteLine(disArr[0]);
            //        }
            //        else
            //        {
            //            sw.WriteLine(disArr[0+1]);
            //        }
            //    }
            //    else if(even==1)
            //    {
            //        store = Array.FindIndex(recentValue, x => x == max);
            //        sw.WriteLine(intArr[store]);
            //    }
            //    //범위
            //    sw.WriteLine(four);
            //}
            //sr.Close();
            //sw.Close();

            //나이순 정렬
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //for (int i = 0; i < num; i++)
            //{
            //    string text = sr.ReadLine();
            //    //value
            //    int age = int.Parse(text.Split()[0]);
            //    //key
            //    string name = text.Split()[1];
            //    dic.Add(name, age);
            //    age = 0;
            //    name = "";
            //}
            //var dicAsc = dic.OrderBy(x => x.Value);
            //foreach (var item in dicAsc)
            //{
            //    sw.WriteLine(item.Value+" "+item.Key);
            //}
            //sr.Close();
            //sw.Close();

            //팩토리얼 0의 갯수
            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //long ret = 1;
            //for (int i = num; i > 0 ; i--)
            //{
            //    ret *= i;
            //}
            //sw.WriteLine(ret);
            //string str = ret.ToString();
            //int cnt = 0;
            //for (int i = str.Length-1; i >0; i--)
            //{
            //    if (str[i].ToString()=="0")
            //    {
            //        cnt++;
            //    }else
            //    {
            //        break;
            //    }
            //}
            //sw.WriteLine(cnt);
            //sr.Close();
            //sw.Close();

            //var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            //var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            //int num = int.Parse(sr.ReadLine());
            //string tmp = num.ToString();
            //int[] intArr = new int[tmp.Length];
            //for (int i = 0; i < tmp .Length; i++)
            //{
            //    intArr[i] = int.Parse(tmp[i].ToString());
            //}
            ////var dicAsc = dic.OrderBy(x => x.Value);
            //Array.Sort(intArr);
            //Array.Reverse(intArr);
            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    sw.Write(intArr[i]);
            //}
            //sr.Close();
            //sw.Close();




         }
        }
    }

