package creation.ken;
import com.jacob.activeX.ActiveXComponent;
import com.jacob.activeX.ActiveXDispatchEvents;
import com.jacob.com.ComThread;
import com.jacob.com.Dispatch;
import com.jacob.com.Variant;

import java.io.IOException;

public class test {
    public static void main(String[] args) {
        try
        {
//            ComThread.InitMTA(true);
            ActiveXComponent com = new ActiveXComponent("dotNetActiveXDemo.Encrypt");

            ActiveXDispatchEvents events = new ActiveXDispatchEvents(com,new ControlEvents(),"dotNetActiveXDemo.Encrypt");

            Variant var = Dispatch.call(com,"GetEncrypt","first param","second 参数");
            String str = var.toString(); //返回值
            System.out.println(str);

            Variant var1 = Dispatch.call(com,"SetEncrypt","first param");
            str = var1.toString(); //返回值
            System.out.println(str);

            Variant var2 = Dispatch.call(com,"SetInt",12);
            str = var2.toString(); //返回值
            System.out.println(str);
        }
        catch (Exception ex){
            ex.printStackTrace();
        }
    }
}
