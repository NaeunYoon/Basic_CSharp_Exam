using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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











        }
    }
}
