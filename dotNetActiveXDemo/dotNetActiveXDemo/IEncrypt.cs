using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace dotNetActiveXDemo
{
   [Guid("1E2B356C-D3D0-4D54-966C-B33A0BB8A946")]
   [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IEncrypt
    {

       [DispId(1)]
       string GetEncrypt(string str, string str2);
       [DispId(2)]
       string SetEncrypt(string str);
       [DispId(3)]
       string SetInt(int value); 
    }
}
