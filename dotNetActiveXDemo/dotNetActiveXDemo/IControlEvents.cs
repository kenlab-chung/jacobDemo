using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace dotNetActiveXDemo
{
    [Guid("C71CBAA7-1733-42EA-B17E-7D7BAF254748")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IControlEvents
    {     
        [DispId(0x21)]
        void RecordStarted(string str);        
        [DispId(23)]
        void RecordStopped();
    }
}
