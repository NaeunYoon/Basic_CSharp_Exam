﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_81
{

    class NoteBook
    {
        int inch;
        int memoryGB;

        public NoteBook(int inch, int memoryGB)
        {
            this.inch = inch;
            this.memoryGB = memoryGB;
        }

        public int this[string propertyName]    //문자열로 인덱스를 지정
        {
            get
            {
                switch (propertyName)
                {
                    case "인치": return inch;
                    case "메모리크기": return memoryGB;
                }
                return -1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NoteBook noteBook = new NoteBook(13,4);

            Console.WriteLine("모니터인치 : " + noteBook["인치"]+"\"");
            Console.WriteLine("메모리크기 : " + noteBook["메모리크기"]+"GB");
        }
    }
}
