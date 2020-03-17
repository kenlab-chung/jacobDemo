package creation.ken;

import com.jacob.com.Variant;

public class ControlEvents {

    public void RecordStarted(String str)
    {
        System.out.println("RecordStarted() invoked "+str);
    }


    public void RecordStopped()
    {
        System.out.println("RecordStopped() invoked");
    }
}
