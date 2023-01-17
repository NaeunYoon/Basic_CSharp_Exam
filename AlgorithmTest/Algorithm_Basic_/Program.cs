using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security;
using Microsoft.Win32;
using System.Globalization;
using System.Net.Sockets;
using System.IO.IsolatedStorage;
using System.Net.Security;

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

            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            sw.WriteLine("n e");
            sw.WriteLine("- -----------");


            for (int i = 0; i < 9; i++)
            {

            }
            
            sr.Close();
            sw.Close();




        }
    }
}
