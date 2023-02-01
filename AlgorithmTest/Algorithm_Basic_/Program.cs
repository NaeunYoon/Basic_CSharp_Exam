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




        }
    }
}
