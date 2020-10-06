using System;
using System.Diagnostics;

namespace RunWorkPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Once run, this program will open Outlook Email, Notepad, VMWare Horizon machine for secure access to financial documents, Jabber for team chats and iceLauncher for team phone connection
            Process.Start(@"C:\Program Files\Microsoft Office\office16\outlook.exe");
            Process.Start("C:\\Windows\\notepad.exe");
            Process.Start(@"C:\Program Files (x86)\VMware\VMware Horizon View Client\vmware-view.exe");
            Process.Start(@"C:\Program Files (x86)\Cisco Systems\Cisco Jabber\CiscoJabber.exe");
            Process.Start(@"C:\Program Files\Computer Talk Technology\iceBAR\iceOfficeLauncher.exe");
        }
    }
}
