# ozsec2021-shellcode
C# .NET project for executing shell code 

# Description: 
Running shellcode in c#
    generic process (ie, allocate memory, copy shellcode in, execute)
    poc||gtfo
    IOC's (indicators of compromise. Memory analysis, if you need help with this I'm more than happy to help)
Basic roslyn usage
    the basis of this is to change sigs of payloads
Basic covenant c2 usage/ reference - you can just introduce the tool
Running the payloads in powershell! powershell == c# terminal lol
introduction to defender check AMSI
    basically, c# is a script in the scope of AMSIScanBuffer()
basic obfuscation of payloads (aes encryption, xor encryption, and decryption **dont wory about encryption too much, just the decryption part is fine in code)

if you're interested, we can delve into process injection in c#. Basic examples using CreateRemoteThread are fine, c# has a cool assembley.load feature that is specific to .NET libraries
