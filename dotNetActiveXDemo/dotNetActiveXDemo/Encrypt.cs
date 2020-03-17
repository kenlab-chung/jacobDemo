using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;
using System.Runtime.Serialization.Json;
using System.IO;

namespace dotNetActiveXDemo
{
    [Guid("33A6E58D-E1F5-4b53-B2E2-03B9F8BA2FAD"),
    ClassInterface(ClassInterfaceType.None),
    ComDefaultInterface(typeof(IEncrypt)),
    ComSourceInterfaces(typeof(IControlEvents)),
    ComVisible(true)]
    
    
    public class Encrypt : IEncrypt
    {
        

        public delegate void RecordStoppedDelegate();
        public event RecordStoppedDelegate RecordStopped;

        public delegate void RecordStartedDelegate(string str);
        public event RecordStartedDelegate RecordStarted;
       
        public Encrypt() { }   

        public string GetEncrypt(string str, string str2)
        {
            Entity entity = new Entity();
            entity.cost = 12.8;
            entity.charge = 32.2f;
            entity.context = "hello context";
            entity.firstname = "Jime";
            entity.lastname = "测试";
            entity.id = 12;
            entity.product.Add(new Product() { name = "苹果", price = 12.3 });
            entity.product.Add(new Product() { name = "香蕉", price = 1.3 });
            entity.product.Add(new Product() { name = "柠檬", price = 2.3 });
            entity.product.Add(new Product() { name = "百香果", price = 3.3 });

            string json = string.Empty;
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Entity));
            using (MemoryStream stream = new MemoryStream())
            {
                dcjs.WriteObject(stream, entity);
                stream.Position = 0;
                using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
                {
                    json = sr.ReadToEnd();
                }
            }

            RecordStarted(json);
            RecordStopped();
            return "测试 | " + str + "|" + str2;            
        }
        public string SetInt(int value)
        {
            return value.ToString();
        }
        public string SetEncrypt(string str)
        {
          
            RecordStarted("test1");
            RecordStopped();

         
            return "测试 | " + str;
        }
    }
}
